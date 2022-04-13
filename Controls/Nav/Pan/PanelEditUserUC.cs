using classbook.Connection;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iSlavici.Controls.Navigator;
using ComponentFactory.Krypton.Toolkit;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelEditUserUC : UserControl
    {
        private int _profile_id_selected;
        private string currentUsernameEdit;
        private string currentPhoneEdit;
        private string currentCnpEdit;
        private string currentEmailEdit;
        private int _role_id_selected;
        private int _account_id;

        public PanelEditUserUC(int id, string username, string password, string fullname, string email, string cnp, string phone, string role, string profile, int year) {
            InitializeComponent();

            txtboxFullNameEdit.Text = fullname;
            txtboxEmailEdit.Text = email;
            txtboxCnpEdit.Text = cnp;
            txtboxPasswordEdit.Text = password;
            txtboxUsernameEdit.Text = username;
            txtboxPhoneEdit.Text = phone;
            numBtnYearEdit.Value = year;

            currentUsernameEdit = username;
            currentPhoneEdit = phone;
            currentCnpEdit = cnp;
            currentEmailEdit = email;
            _account_id = id;


            SetRole(role);
            InitializeProfiles();
            SetProfile(profile);
        }

        private void InitializeProfiles() {
            DataAccess.LoadProfiles();
            foreach (var profile in DataAccess.profiles) {
                cbProfilesEdit.Items.Add(profile.Name);
            }
        }

        private void SetProfile(string profile) {
            cbProfilesEdit.Text = profile;
            _profile_id_selected = DataAccess.profiles.Where(x => x.Name.Equals(profile)).Select(x => x.Id).FirstOrDefault();
        }

        private void SetRole(string role) {
            if (role == "ADMINISTRATOR") {
                radBtnAdminEdit.Checked = true;
                _role_id_selected = 1;
            }
            if (role == "STUDENT") {
                radBtnStudentEdit.Checked = true;
                _role_id_selected = 2;
            }
        }

        private void BtnRoleClickEvent(object sender, EventArgs e) {
            KryptonRadioButton radioBtn = (KryptonRadioButton)sender;

            if(radioBtn == radBtnAdminEdit) {
                _role_id_selected = 1;
            } else if(radioBtn == radBtnStudentEdit) {
                _role_id_selected = 2;
            }
        }

        private void BtnProfileSelectedEvent(object sender, EventArgs e) {
            string selected = cbProfilesEdit.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            _profile_id_selected = DataAccess.profiles.Where(x => x.Name.Equals(selected)).Select(x => x.Id).FirstOrDefault();
        }

        private void BtnUpdateClickEvent(object sender, EventArgs e) {
            if (!DataAccess._isConnection) return;
            if (!ValidateFields()) return;
            if (CheckIfExist()) return;


            /// ACCOUNT 
            string editUsername = txtboxUsernameEdit.Text;
            string editPassword = txtboxPasswordEdit.Text;
            int editRole = _role_id_selected;

            /// PERSON
            string fullname = txtboxFullNameEdit.Text;
            string email = txtboxEmailEdit.Text;
            string CNP = txtboxCnpEdit.Text;
            string phone = txtboxPhoneEdit.Text;

            /// STUDENT
            int editProfile = _profile_id_selected;
            int inYear = int.Parse(numBtnYearEdit.Value.ToString());


            if (DataAccess.UpdateUser(_account_id, editUsername, editPassword, editRole, fullname, email, CNP, phone, editProfile, inYear)) {
                MessageBox.Show("Account updated succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navigator.Navigator.GetInstance().SetEditUserPageHiden();
                Navigator.Navigator.GetInstance().SelectUserListPage();
                Navigator.Navigator.GetInstance().GetPageUserList().spliitterUserList.userUC.userDGV.RefreshData();
            }
        }

        private bool CheckIfExist() {
            string username = txtboxUsernameEdit.Text;
            string cnp = txtboxCnpEdit.Text;
            string email = txtboxEmailEdit.Text;
            string phone = txtboxPhoneEdit.Text;

            string result = DataAccess.CheckIfEditUserExist(username, cnp, email, phone, currentUsernameEdit, currentCnpEdit, currentEmailEdit, currentPhoneEdit);

            if (!string.IsNullOrEmpty(result)) {
                MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return !string.IsNullOrEmpty(result);
        }

        private bool ValidateFields() {
            /// IF THE USERNAME OR PASSWORD IS NULL OR WHITESPACES THEN RETURN FALSE
            if (string.IsNullOrWhiteSpace(txtboxUsernameEdit.Text) || string.IsNullOrWhiteSpace(txtboxPasswordEdit.Text)) {
                MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxUsernameEdit.Text = string.Empty;
                txtboxPasswordEdit.Text = string.Empty;
                return false;
            }

            /// IF THE USERNAME OR PASSWORD CONTAINS WHITESPACES THEN RETURN FALSE
            if (txtboxUsernameEdit.Text.Contains(" ") || txtboxPasswordEdit.Text.Contains(" ")) {
                MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxUsernameEdit.Text = string.Empty;
                txtboxPasswordEdit.Text = string.Empty;
                return false;
            }

            /// IF THE NAME IS NULL OR WHITESPACE RETURN FALSE 
            if (string.IsNullOrWhiteSpace(txtboxFullNameEdit.Text)) {
                MessageBox.Show("The name cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxFullNameEdit.Text = string.Empty;
                return false;
            }

            /// FULL NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
            if (!txtboxFullNameEdit.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) {
                MessageBox.Show("The name can only contain letters and whitespaces!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxFullNameEdit.Text = string.Empty;
                return false;
            }

            /// CNP MUST CONTAINS ONLY NUMBERS
            if (!txtboxCnpEdit.Text.All(c => char.IsDigit(c))) {
                MessageBox.Show("The CNP can only contain numbers!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxCnpEdit.Text = string.Empty;
                return false;
            }

            /// CNP MUST CONTAINS ONLY 13 digits
            if (txtboxCnpEdit.Text.Length != 13 && !radBtnAdminEdit.Checked) {
                MessageBox.Show("The CNP seems to be invalid!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxCnpEdit.Text = string.Empty;
                return false;
            }


            /// CHECK THE EMAIL FOR SPACES IF THEY IS NOT NULL
            if (!string.IsNullOrEmpty(txtboxEmailEdit.Text) && txtboxEmailEdit.Text.Contains(" ")) {
                MessageBox.Show("The email cannot contain spaces!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxEmailEdit.Text = string.Empty;
                return false;
            }

            /// CHECK IF THIS EMAIL IS VALID ( MUST CONTAIN @ and .)
            if (!string.IsNullOrEmpty(txtboxEmailEdit.Text) && (!txtboxEmailEdit.Text.Contains("@") || !txtboxEmailEdit.Text.Contains("."))) {
                MessageBox.Show("Email seems invalid!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxEmailEdit.Text = string.Empty;
                return false;
            }


            /// PHONE FIELD CAN CONTAINS ONLY NUMBER AND MAXIMUM 10 NUMBERS
            if (!string.IsNullOrEmpty(txtboxPhoneEdit.Text) && (!txtboxPhoneEdit.Text.All(char.IsDigit) || txtboxPhoneEdit.Text.Length != 10)) {
                MessageBox.Show("Phone number seems invalid!", "Invalid phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxPhoneEdit.Text = string.Empty;
                return false;
            }

            /// IF THE STUDENT OR ADMINISTRATOR IS NOT CHECKED THEN RETURN FALSE
            if (!radBtnStudentEdit.Checked && !radBtnAdminEdit.Checked) {
                MessageBox.Show("You must define a role for this account!", "Set role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /// IF THE PROFILE WAS NOT SELECTED AND ADMINISTRATOR ROLE IS NOT CHECKED RETURN FALSE
            /// WE CAN HAVE ADMINISTRATOR ACCOUNT WHICH DONT HAVE PROFILE 
            if (_profile_id_selected == 0 && !radBtnAdminEdit.Checked) {
                MessageBox.Show("You must select a profile for this account!", "Set profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /// MAKE NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
            /// EX: andrei razvan to Andrei Razvan
            string[] lastNameSpliter = txtboxFullNameEdit.Text.Split(' ');
            foreach (string name in lastNameSpliter) {
                string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                txtboxFullNameEdit.Text = txtboxFullNameEdit.Text.Replace(name, withFirstLetterUp);
            }

            /// MAKE EMAIL TO LOWER
            txtboxEmailEdit.Text = txtboxEmailEdit.Text.ToLower();

            /// MAKE USERNAME TO LOWER
            txtboxUsernameEdit.Text = txtboxUsernameEdit.Text.ToLower();

            return true;
        }


        ///// <summary>
        ///// Represents the method for update user from User List
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private async void BtnUpdateEdit_Click(object sender, EventArgs e) {
        //    if (DataAccess._isConnection && ValidateFields(true)) {
        //        if (!CheckIfExist(true)) {
        //            try {
        //                /// ACCOUNT 
        //                string editUsername = txtboxUsernameEdit.Text;
        //                string editPassword = txtboxPasswordEdit.Text;
        //                int editRole = _role_id_selected;

        //                /// PERSON
        //                string fullname = txtboxFullNameEdit.Text;
        //                string email = txtboxEmailEdit.Text;
        //                string CNP = txtboxCnpEdit.Text;
        //                string phone = txtboxPhoneEdit.Text;

        //                /// STUDENT
        //                int editProfile = _profile_id_selected;
        //                int inYear = int.Parse(numBtnYearEdit.Value.ToString());


        //                if (DataAccess.UpdateUser(currentAccountId, editUsername, editPassword, editRole, fullname, email, CNP, phone, editProfile, inYear)) {
        //                    MessageBox.Show("Account updated succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    //  dgvUserList = new UserDGV();
        //                    pageEditUser.Visible = false;
        //                    pageUserList.Select();
        //                }
        //            } catch (Exception ex) {
        //                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }
}