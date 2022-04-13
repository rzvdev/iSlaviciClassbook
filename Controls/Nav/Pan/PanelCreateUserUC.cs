using classbook.Connection;
using ComponentFactory.Krypton.Toolkit;
using iSlavici.Controls.Nav.Pag;
using iSlavici.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelCreateUserUC : UserControl
    {
        private int _profile_id_selected;
        private int _role_id_selected;

        public PanelCreateUserUC() {
            InitializeComponent();
            InitializeProfiles();
        }

        private void InitializeProfiles() {
             DataAccess.LoadProfiles();
            foreach(var profile in DataAccess.profiles) {
                cbProfilesCreate.Items.Add(profile.Name);
            }
        }

        private void BtnCreateClickEvent(object sender, EventArgs e) {
            if (DataAccess._isConnection && ValidateFields()) {
                if (!CheckIfExist()) {
                    try {
                        /// ACCOUNT
                        string username = txtboxUsernameCreate.Text;
                        string password = txtboxPasswordCreate.Text;
                        int profileId = _profile_id_selected;
                        int roleId = _role_id_selected;

                        /// PERSON
                        string fullName = txtboxFullNameCreate.Text;
                        string email = txtboxEmailCreate.Text;
                        string cnp = textboxCnpCreate.Text;
                        string phone = txtboxPhoneCreate.Text;

                        /// STUDENT
                        int inYear = int.Parse(numBtnYearCreate.Value.ToString());

                        if (DataAccess.CreateUser(username, password, profileId, roleId, fullName, email, cnp, phone, inYear)) {
                            MessageBox.Show("Account created succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllFields();
                            UserDGV.GetInstance().RefreshData();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void ClearAllFields() {
            txtboxEmailCreate.Text = String.Empty;
            txtboxPasswordCreate.Text = String.Empty;
            txtboxEmailCreate.Text = String.Empty;
            txtboxPhoneCreate.Text = String.Empty;
            txtboxUsernameCreate.Text = String.Empty;
            txtboxFullNameCreate.Text = String.Empty;
            textboxCnpCreate.Text = String.Empty;
        }

        private bool CheckIfExist() {
            try {
                string username = txtboxUsernameCreate.Text;
                string cnp = textboxCnpCreate.Text;
                string email = txtboxEmailCreate.Text;
                string phone = txtboxPhoneCreate.Text;

                string result = DataAccess.CheckIfUserExist(username, cnp, email, phone);

                if (!string.IsNullOrEmpty(result)) {
                    MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return !string.IsNullOrEmpty(result);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool ValidateFields() {
            try {
                /// IF THE USERNAME OR PASSWORD IS NULL OR WHITESPACES THEN RETURN FALSE
                if (string.IsNullOrWhiteSpace(txtboxUsernameCreate.Text) || string.IsNullOrWhiteSpace(txtboxPasswordCreate.Text)) {
                    MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxUsernameCreate.Text = string.Empty;
                    txtboxPasswordCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE USERNAME OR PASSWORD CONTAINS WHITESPACES THEN RETURN FALSE
                if (txtboxUsernameCreate.Text.Contains(" ") || txtboxPasswordCreate.Text.Contains(" ")) {
                    MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxUsernameCreate.Text = string.Empty;
                    txtboxPasswordCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE NAME IS NULL OR WHITESPACE RETURN FALSE 
                if (string.IsNullOrWhiteSpace(txtboxFullNameCreate.Text)) {
                    MessageBox.Show("The name cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxFullNameCreate.Text = string.Empty;
                    return false;
                }

                /// FULL NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
                if (!txtboxFullNameCreate.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) {
                    MessageBox.Show("The name can only contain letters and whitespaces!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxFullNameCreate.Text = string.Empty;
                    return false;
                }

                /// CNP MUST CONTAINS ONLY NUMBERS
                if (!textboxCnpCreate.Text.All(c => char.IsDigit(c))) {
                    MessageBox.Show("The CNP can only contain numbers!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textboxCnpCreate.Text = string.Empty;
                    return false;
                }

                /// CNP MUST CONTAINS ONLY 13 digits
                if (textboxCnpCreate.Text.Length != 13 && !radBtnAdminCreate.Checked) {
                    MessageBox.Show("The CNP seems to be invalid!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textboxCnpCreate.Text = string.Empty;
                    return false;
                }


                /// CHECK THE EMAIL FOR SPACES IF THEY IS NOT NULL
                if (!string.IsNullOrEmpty(txtboxEmailCreate.Text) && txtboxEmailCreate.Text.Contains(" ")) {
                    MessageBox.Show("The email cannot contain spaces!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxEmailCreate.Text = string.Empty;
                    return false;
                }

                /// CHECK IF THIS EMAIL IS VALID ( MUST CONTAIN @ and .)
                if (!string.IsNullOrEmpty(txtboxEmailCreate.Text) && (!txtboxEmailCreate.Text.Contains("@") || !txtboxEmailCreate.Text.Contains("."))) {
                    MessageBox.Show("Email seems invalid!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxEmailCreate.Text = string.Empty;
                    return false;
                }


                /// PHONE FIELD CAN CONTAINS ONLY NUMBER AND MAXIMUM 10 NUMBERS
                if (!string.IsNullOrEmpty(txtboxPhoneCreate.Text) && (!txtboxPhoneCreate.Text.All(char.IsDigit) || txtboxPhoneCreate.Text.Length != 10)) {
                    MessageBox.Show("Phone number seems invalid!", "Invalid phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxPhoneCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE STUDENT OR ADMINISTRATOR IS NOT CHECKED THEN RETURN FALSE
                if (!radBtnStudentCreate.Checked && !radBtnAdminCreate.Checked) {
                    MessageBox.Show("You must define a role for this account!", "Set role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// IF THE PROFILE WAS NOT SELECTED AND ADMINISTRATOR ROLE IS NOT CHECKED RETURN FALSE
                /// WE CAN HAVE ADMINISTRATOR ACCOUNT WHICH DONT HAVE PROFILE 
                //if (_profile_id_selected == 0 && !radBtnAdminCreate.Checked) {
                //    MessageBox.Show("You must select a profile for this account!", "Set profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

                /// MAKE NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
                /// EX: andrei razvan to Andrei Razvan
                string[] lastNameSpliter = txtboxFullNameCreate.Text.Split(' ');
                foreach (string name in lastNameSpliter) {
                    string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                    txtboxFullNameCreate.Text = txtboxFullNameCreate.Text.Replace(name, withFirstLetterUp);
                }

                /// MAKE EMAIL TO LOWER
                txtboxEmailCreate.Text = txtboxEmailCreate.Text.ToLower();

                /// MAKE USERNAME TO LOWER
                txtboxUsernameCreate.Text = txtboxUsernameCreate.Text.ToLower();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void RadBtnRole(object sender, EventArgs e) {
            if (radBtnStudentCreate.Checked) {
                _role_id_selected = 2;
            }
            if (radBtnAdminCreate.Checked) {
                _role_id_selected = 1;
            }
        }

        private void ProfileChangeEvent(object sender, EventArgs e) {
            string selected = cbProfilesCreate.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            _profile_id_selected = DataAccess.profiles.Where(x => x.Name.Equals(selected)).Select(x => x.Id).FirstOrDefault();
        }


    }

}
