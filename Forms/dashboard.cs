using classbook.Connection;
using classbook.Utility;
using iSlavici.Connection.Models.db;
using iSlavici.Utility;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using System.Globalization;

namespace classbook
{
    public partial class Dashboard : Form
    {
        private readonly Resize _resize;
        private int _profile_id_selected;
        private int _role_id_selected;

        public Dashboard()
        {
            this.DoubleBuffered = true;
            CultureInfo defaultCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
            CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

            InitializeComponent();
            _resize = new Resize(this);
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;
            labelPersonName.Text = $"{DataAccess._loggedPerson.FullName}";

            InitializeRolePanel();

            LoadDgvUserList();
        }

        /// <summary>
        /// Represents the method that initialize Student panel or Admin panel by Role type
        /// </summary>
        private void InitializeRolePanel()
        {
            if (DataAccess._loggedAccount.RoleId == 2)
            {
                panelStudent.Visible = true;
                panelStudent.Enabled = true;
                BringToFront();

                panelAdmin.Enabled = false;
                panelAdmin.Visible = false;

            }
            else
            {
                panelAdmin.Visible = true;
                panelAdmin.Enabled = true;
                BringToFront();

                panelStudent.Enabled = false;
                panelStudent.Visible = false;
            }
        }

        private void LoadDgvUserList()
        {

            var userAndPerson = (from acc in DataAccess._dbContext.Account
                                 join per in DataAccess._dbContext.Person on acc.PersonId equals per.Id
                                 join rol in DataAccess._dbContext.Role on acc.RoleId equals rol.Id
                                 join pro in DataAccess._dbContext.Profile on acc.ProfileId equals pro.Id into lftJoin
                                 from leftJoin in lftJoin.DefaultIfEmpty()
                                 select new UserList
                                 {
                                     ID = acc.Id,
                                     Username = acc.Username,
                                     Name = per.FullName,
                                     Role = rol.Name,
                                     Email = per.Email,
                                     Phone = per.Phone,
                                     Profile = (leftJoin == null ? string.Empty : leftJoin.Name),
                                     Year = 1,
                                     CreatedDate = per.CreatedDate
                                 }).ToList();

            dgvUserList.DataSource = userAndPerson;

            dgvUserList.Columns.Add("ACTION","ACTIONS");
          
            CustomizeTable(dgvUserList);
        }

        private void CustomizeTable(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 58, 68);
            dgv.ColumnHeadersHeight = 30;

            // ID
            dgv.Columns[0].Width = 50;

            // USERNAME
            dgv.Columns[1].Width = 150;

            // FULLNAME
            dgv.Columns[2].Width = 200;

            // ROLE
            dgv.Columns[3].Width = 80;

            // EMAIL
            dgv.Columns[4].Width = 200;

            // PROFILE
            dgv.Columns[6].Width = 130;

            // YEAR
            dgv.Columns[7].Width = 50;

            // CREATEDDATE
            dgv.Columns[8].Width = 150;

            dgv.Refresh();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            //if (dgvUserList.Visible)
            //{
            //    _resize.ResizeForm(dgvUserList.ColumnHeadersDefaultCellStyle.Font.FontFamily);
            //}
            //else
            //{
            //    _resize.ResizeForm();
            //}
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _resize.GetInitialSize();
        //    SendToBack();
            ConnectionTick connectionTick = new ConnectionTick(null);
            connectionTick.StartTimer();
        }

        private void BtnProfiles_Click(object sender, EventArgs e)
        {
            if (navigator.Pages.Contains(pageCreateUser) && pageCreateUser.Visible == false) pageCreateUser.Visible = true;
        }

        /// <summary>
        /// Represents the method for create user button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (DataAccess._isConnection && ValidateFields())
            {
                if (!CheckIfExist())
                {
                    try
                    {
                        Account account = new Account
                        {
                            Username = txtboxUsernameCreate.Text,
                            Password = txtboxPasswordCreate.Text,
                            ProfileId = _profile_id_selected,
                            RoleId = _role_id_selected
                        };

                        Person person = new Person()
                        {
                            FullName = txtboxFullNameCreate.Text,
                            Email = txtboxEmailCreate.Text,
                            Phone = txtboxPhoneCreate.Text,
                            Account = account
                        };


                        DataAccess._dbContext.Add(person);
                        DataAccess._dbContext.Add(account);
                        DataAccess._dbContext.SaveChanges();

                        MessageBox.Show("Account created succesfully!","Succes");
                    } catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        /// <summary>
        /// Represents the method that check if the user exist in database
        /// </summary>
        /// <returns></returns>
        private bool CheckIfExist()
        {
            try
            {
                /// SEARCH FOR USERNAME IN DATABASE
                Account searchedUsername = (from acc in DataAccess._dbContext.Account
                                            where acc.Username == txtboxUsernameCreate.Text
                                            select acc).FirstOrDefault();

                if (searchedUsername != null)
                {
                    MessageBox.Show("This username already exists!", "Change username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                /// SEARCH FOR PERSON NAME 
                Person searchedPersonName = (from per in DataAccess._dbContext.Person
                                             where per.FullName.ToLower().Trim().Equals(txtboxFullNameCreate.Text.ToLower().Trim())
                                             select per).FirstOrDefault();
                /// IF EXIST RETURN TRUE
                if (searchedPersonName != null)
                {
                    MessageBox.Show("This name already exists!", "Change name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                /// IF EMAIL FIELD ITS NOT EMPTY 
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(txtboxEmailCreate.Text))
                {
                    Person searchedPersonEmail = (from per in DataAccess._dbContext.Person
                                                  where per.Email.Equals(txtboxEmailCreate.Text)
                                                  select per).FirstOrDefault();

                    if (searchedPersonEmail != null)
                    {
                        MessageBox.Show("This email already exists!", "Change email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }

                /// IF PHONE FIELD ITS NOT EMPTY
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(txtboxPhoneCreate.Text))
                {
                    Person searchedPersonNumber = (from per in DataAccess._dbContext.Person
                                                   where per.Phone.Equals(txtboxPhoneCreate.Text)
                                                   select per).FirstOrDefault();

                    if (searchedPersonNumber != null)
                    {
                        MessageBox.Show("This phone number already exists!", "Change phone number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            } catch(Exception ex)
            {
                throw ex;
            }
            return false;
        }

        /// <summary>
        /// Represents the method that validate the creating user fields
        /// if is returning true
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            try
            {
                /// IF THE USERNAME OR PASSWORD IS NULL OR WHITESPACES THEN RETURN FALSE
                if (string.IsNullOrWhiteSpace(txtboxUsernameCreate.Text) || string.IsNullOrWhiteSpace(txtboxPasswordCreate.Text))
                {
                    MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxUsernameCreate.Text = string.Empty;
                    txtboxPasswordCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE USERNAME OR PASSWORD CONTAINS WHITESPACES THEN RETURN FALSE
                if (txtboxUsernameCreate.Text.Contains(" ") || txtboxPasswordCreate.Text.Contains(" "))
                {
                    MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxUsernameCreate.Text = string.Empty;
                    txtboxPasswordCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE FIRST NAME IS NULL OR WHITESPACE RETURN FALSE 
                if (string.IsNullOrWhiteSpace(txtboxFullNameCreate.Text))
                {
                    MessageBox.Show("The first name cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxFullNameCreate.Text = string.Empty;
                    return false;
                }

                /// FULL NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
                if (!txtboxFullNameCreate.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("The name can only contain letters and whitespaces!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxFullNameCreate.Text = string.Empty;
                    return false;
                }

                /// CHECK THE EMAIL FOR SPACES IF THEY IS NOT NULL
                if (!string.IsNullOrEmpty(txtboxEmailCreate.Text) && txtboxEmailCreate.Text.Contains(" "))
                {
                    MessageBox.Show("The email cannot contain spaces!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxEmailCreate.Text = string.Empty;
                    return false;
                }

                /// CHECK IF THIS EMAIL IS VALID ( MUST CONTAIN @ and .)
                if (!string.IsNullOrEmpty(txtboxEmailCreate.Text) && (!txtboxEmailCreate.Text.Contains("@") || !txtboxEmailCreate.Text.Contains(".")))
                {
                    MessageBox.Show("Email seems invalid!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxEmailCreate.Text = string.Empty;
                    return false;
                }


                /// PHONE FIELD CAN CONTAINS ONLY NUMBER AND MAXIMUM 10 NUMBERS
                if (!string.IsNullOrEmpty(txtboxPhoneCreate.Text) && (!txtboxPhoneCreate.Text.All(char.IsDigit) || txtboxPhoneCreate.Text.Length < 10))
                {
                    MessageBox.Show("Phone number seems invalid!", "Invalid phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxPhoneCreate.Text = string.Empty;
                    return false;
                }

                /// IF THE STUDENT OR ADMINISTRATOR IS NOT CHECKED THEN RETURN FALSE
                if (!radBtnStudentCreate.Checked && !radBtnAdminCreate.Checked)
                {
                    MessageBox.Show("You must define a role for this account!", "Set role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// IF THE PROFILE WAS NOT SELECTED AND ADMINISTRATOR ROLE IS NOT CHECKED RETURN FALSE
                /// WE CAN HAVE ADMINISTRATOR ACCOUNT WHICH DONT HAVE PROFILE 
                if (_profile_id_selected == 0 && !radBtnAdminCreate.Checked)
                {
                    MessageBox.Show("You must select a profile for this account!", "Set profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// MAKE NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
                /// EX: andrei razvan to Andrei Razvan
                string[] lastNameSpliter = txtboxFullNameCreate.Text.Split(' ');
                foreach (string name in lastNameSpliter)
                {
                    string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                    txtboxFullNameCreate.Text = txtboxFullNameCreate.Text.Replace(name, withFirstLetterUp);
                }

                /// MAKE EMAIL TO LOWER
                txtboxEmailCreate.Text = txtboxEmailCreate.Text.ToLower();

                /// MAKE USERNAME TO LOWER
                txtboxUsernameCreate.Text = txtboxUsernameCreate.Text.ToLower();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SelectProfileCalculatoare_Execute(object sender, EventArgs e)
        {
            try
            {
                _profile_id_selected = 1;
                droBtnProfilesCreate.Text = "CALCULATOARE";
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        private void SelectProfileContabilitate_Execute(object sender, EventArgs e)
        {
            try
            {
                _profile_id_selected = 2;
                droBtnProfilesCreate.Text = "CONTABILITATE";
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RadBtnStudentCreate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 2;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        private void radBtnAdminCreate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 1;
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
