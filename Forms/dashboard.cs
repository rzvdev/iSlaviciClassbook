using classbook.Connection;
using classbook.Utility;
using iSlavici.Connection.Models.db;
using iSlavici.Models;
using iSlavici.Utility;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace classbook
{
    public partial class Dashboard : Form
    {
        private static readonly string _APP_CULTURE = ConfigurationManager.AppSettings.Get("APP_CULTURE");

        private readonly Resize _resize;
        private int _profile_id_selected;
        private int _role_id_selected = 2;
        private string currentAccountId;
        private string currentUsernameEdit;
        private string currentCnpEdit;
        private string currentEmailEdit;
        private string currentPhoneEdit;

        private int _course_type_selected = 1;
        private int _course_profile_selected = 0;
        private int _course_examination_selected = 0;

        public Dashboard()
        {
            SetCulture(_APP_CULTURE);

            DoubleBuffered = true;

            InitializeComponent();

            _resize = new Resize(this);
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;

            labelPersonName.Text = $"{DataAccess._loggedPerson.FullName}";

            InitializeRolePanel();

            pageEditUser.Visible = false;
        }

        private void SetCulture(string cultureString)
        {
            CultureInfo defaultCulture = new CultureInfo(cultureString);
            CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
            CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;
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

        private void LoadDgvCourseList()
        {
            try
            {
                AddButtons(dgvCourseList, TableType.CourseTable);
                dgvCourseList.DataSource = DataAccess.LoadCourseList();
                CustomizeTable(dgvCourseList, TableType.CourseTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region DGV METHODS
        /// <summary>
        /// This method add EDIT,DELETE buttons to dgv tables
        /// </summary>
        /// <param name="dgv"></param>
        private void AddButtons(DataGridView dgv, TableType tableType)
        {
            DGVimageButtonDeleteColumn deleteBtn = new DGVimageButtonDeleteColumn
            {
                HeaderText = "",
                Width = 20,
                Text = "Delete this user",
                Tag = "dgvDeleteBtn"
            };


            DGVimageButtonEditColumn editBtn = new DGVimageButtonEditColumn()
            {
                HeaderText = "",
                Width = 20,
                Text = "Edit this user",
                Tag = "dgvEditBtn"
            };

            /// This collides re-adding these buttons
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Tag == deleteBtn.Tag || column.Tag == editBtn.Tag)
                {
                    return;
                }
            }

            switch (tableType)
            {
                case TableType.UserTable:
                    dgv.Columns.Add(deleteBtn);
                    dgv.Columns.Add(editBtn);
                    break;
                case TableType.CourseTable:
                    dgv.Columns.Add(deleteBtn);
                    break;
            }
        }

        /// <summary>
        /// Customize columns and more for the User List DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void CustomizeTable(DataGridView dgv, TableType type)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 58, 68);
            dgv.ColumnHeadersHeight = 30;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Tahoma", 11f, FontStyle.Regular);
            }

            switch (type)
            {
                case TableType.UserTable:
                    // DELETE
                    dgv.Columns[0].Width = 20;

                    // EDIT
                    dgv.Columns[1].Width = 20;

                    // ID
                    dgv.Columns[2].Width = 50;

                    // USERNAME
                    dgv.Columns[3].Width = 150;

                    // FULLNAME
                    dgv.Columns[4].Width = 200;

                    // CNP
                    dgv.Columns[5].Width = 200;

                    // ROLE
                    dgv.Columns[6].Width = 100;

                    // EMAIL
                    dgv.Columns[7].Width = 250;

                    // PHONE
                    dgv.Columns[8].Width = 200;

                    // PROFILE
                    dgv.Columns[9].Width = 150;

                    // YEAR
                    dgv.Columns[10].Width = 50;

                    // CREATEDDATE
                    dgv.Columns[11].Width = 200;
                    dgv.Columns[11].HeaderText = "Date Created";

                    break;

                case TableType.CourseTable:
                    // DELETE
                    dgv.Columns[0].Width = 20;

                    // ID
                    dgv.Columns[1].Width = 40;

                    // Course Name
                    dgv.Columns[2].Width = 150;

                    // Abvr
                    dgv.Columns[3].Width = 40;
                    dgv.Columns[3].HeaderText = "Abv";

                    // Teacher Name
                    dgv.Columns[4].Width = 160;

                    // Profile Name
                    dgv.Columns[5].Width = 140;

                    // Subject Type
                    dgv.Columns[6].Width = 80;

                    // Year
                    dgv.Columns[7].Width = 50;

                    // Semester
                    dgv.Columns[8].Width = 50;
                    dgv.Columns[8].HeaderText = "Sem.";
                    break;
            }
            dgv.Refresh();
        }
        #endregion

        #region CREATE USER PAGE
        /// <summary>
        /// Represents the method that load user list and make some pages visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProfiles_Click(object sender, EventArgs e)
        {
            foreach (var page in navigator.Pages) page.Visible = false;

            pageCreateUser.Visible = true;

            LoadDgvUserList();
            pageUserList.Visible = true;

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


                        if (DataAccess.CreateUser(username, password, profileId, roleId, fullName, email, cnp, phone))
                        {
                            MessageBox.Show("Account created succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        /// <summary>
        /// Represents the method that check if the user exist in database
        /// </summary>
        /// <returns></returns>
        private bool CheckIfExist(bool editMode = false)
        {
            try
            {
                if (!editMode)
                {
                    string username = txtboxUsernameCreate.Text;
                    string cnp = textboxCnpCreate.Text;
                    string email = txtboxEmailCreate.Text;
                    string phone = txtboxPhoneCreate.Text;

                    string result = DataAccess.CheckIfUserExist(username, cnp, email, phone);

                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return !string.IsNullOrEmpty(result);
                }
                else if (editMode)
                {
                    string username = txtboxUsernameEdit.Text;
                    string cnp = txtboxCnpEdit.Text;
                    string email = txtboxEmailEdit.Text;
                    string phone = txtboxPhoneEdit.Text;

                    string result = DataAccess.CheckIfUserExist(username, cnp, email, phone, true, currentUsernameEdit, currentCnpEdit, currentEmailEdit, currentPhoneEdit);

                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return !string.IsNullOrEmpty(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        /// <summary>
        /// Represents the method that validate the creating user fields
        /// if is returning true
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields(bool editMode = false)
        {
            try
            {
                if (!editMode)
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

                    /// IF THE NAME IS NULL OR WHITESPACE RETURN FALSE 
                    if (string.IsNullOrWhiteSpace(txtboxFullNameCreate.Text))
                    {
                        MessageBox.Show("The name cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    /// CNP MUST CONTAINS ONLY NUMBERS
                    if (!textboxCnpCreate.Text.All(c => char.IsDigit(c)))
                    {
                        MessageBox.Show("The CNP can only contain numbers!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textboxCnpCreate.Text = string.Empty;
                        return false;
                    }

                    /// CNP MUST CONTAINS ONLY 13 digits
                    if (textboxCnpCreate.Text.Length != 13 && !radBtnAdminCreate.Checked)
                    {
                        MessageBox.Show("The CNP seems to be invalid!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textboxCnpCreate.Text = string.Empty;
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
                    if (!string.IsNullOrEmpty(txtboxPhoneCreate.Text) && (!txtboxPhoneCreate.Text.All(char.IsDigit) || txtboxPhoneCreate.Text.Length != 10))
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
                }
                else if (editMode)
                {
                    /// IF THE USERNAME OR PASSWORD IS NULL OR WHITESPACES THEN RETURN FALSE
                    if (string.IsNullOrWhiteSpace(txtboxUsernameEdit.Text) || string.IsNullOrWhiteSpace(txtboxPasswordEdit.Text))
                    {
                        MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxUsernameEdit.Text = string.Empty;
                        txtboxPasswordEdit.Text = string.Empty;
                        return false;
                    }

                    /// IF THE USERNAME OR PASSWORD CONTAINS WHITESPACES THEN RETURN FALSE
                    if (txtboxUsernameEdit.Text.Contains(" ") || txtboxPasswordEdit.Text.Contains(" "))
                    {
                        MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxUsernameEdit.Text = string.Empty;
                        txtboxPasswordEdit.Text = string.Empty;
                        return false;
                    }

                    /// IF THE NAME IS NULL OR WHITESPACE RETURN FALSE 
                    if (string.IsNullOrWhiteSpace(txtboxFullNameEdit.Text))
                    {
                        MessageBox.Show("The name cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxFullNameEdit.Text = string.Empty;
                        return false;
                    }

                    /// FULL NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
                    if (!txtboxFullNameEdit.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("The name can only contain letters and whitespaces!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxFullNameEdit.Text = string.Empty;
                        return false;
                    }

                    /// CNP MUST CONTAINS ONLY NUMBERS
                    if (!txtboxCnpEdit.Text.All(c => char.IsDigit(c)))
                    {
                        MessageBox.Show("The CNP can only contain numbers!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxCnpEdit.Text = string.Empty;
                        return false;
                    }

                    /// CNP MUST CONTAINS ONLY 13 digits
                    if (txtboxCnpEdit.Text.Length != 13 && !radBtnAdminEdit.Checked)
                    {
                        MessageBox.Show("The CNP seems to be invalid!", "Invalid CNP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxCnpEdit.Text = string.Empty;
                        return false;
                    }


                    /// CHECK THE EMAIL FOR SPACES IF THEY IS NOT NULL
                    if (!string.IsNullOrEmpty(txtboxEmailEdit.Text) && txtboxEmailEdit.Text.Contains(" "))
                    {
                        MessageBox.Show("The email cannot contain spaces!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxEmailEdit.Text = string.Empty;
                        return false;
                    }

                    /// CHECK IF THIS EMAIL IS VALID ( MUST CONTAIN @ and .)
                    if (!string.IsNullOrEmpty(txtboxEmailEdit.Text) && (!txtboxEmailEdit.Text.Contains("@") || !txtboxEmailEdit.Text.Contains(".")))
                    {
                        MessageBox.Show("Email seems invalid!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxEmailEdit.Text = string.Empty;
                        return false;
                    }


                    /// PHONE FIELD CAN CONTAINS ONLY NUMBER AND MAXIMUM 10 NUMBERS
                    if (!string.IsNullOrEmpty(txtboxPhoneEdit.Text) && (!txtboxPhoneEdit.Text.All(char.IsDigit) || txtboxPhoneEdit.Text.Length != 10))
                    {
                        MessageBox.Show("Phone number seems invalid!", "Invalid phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtboxPhoneEdit.Text = string.Empty;
                        return false;
                    }

                    /// IF THE STUDENT OR ADMINISTRATOR IS NOT CHECKED THEN RETURN FALSE
                    if (!radBtnStudentEdit.Checked && !radBtnAdminEdit.Checked)
                    {
                        MessageBox.Show("You must define a role for this account!", "Set role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    /// IF THE PROFILE WAS NOT SELECTED AND ADMINISTRATOR ROLE IS NOT CHECKED RETURN FALSE
                    /// WE CAN HAVE ADMINISTRATOR ACCOUNT WHICH DONT HAVE PROFILE 
                    if (_profile_id_selected == 0 && !radBtnAdminEdit.Checked)
                    {
                        MessageBox.Show("You must select a profile for this account!", "Set profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    /// MAKE NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
                    /// EX: andrei razvan to Andrei Razvan
                    string[] lastNameSpliter = txtboxFullNameEdit.Text.Split(' ');
                    foreach (string name in lastNameSpliter)
                    {
                        string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                        txtboxFullNameEdit.Text = txtboxFullNameEdit.Text.Replace(name, withFirstLetterUp);
                    }

                    /// MAKE EMAIL TO LOWER
                    txtboxEmailEdit.Text = txtboxEmailEdit.Text.ToLower();

                    /// MAKE USERNAME TO LOWER
                    txtboxUsernameEdit.Text = txtboxUsernameEdit.Text.ToLower();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void RadBtnStudentCreate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RadBtnAdminCreate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region USER LIST PAGE
        /// <summary>
        /// Represents the method which load or update the user list dgv
        /// </summary>
        /// <param name="update"></param>
        private void LoadDgvUserList(bool update = false)
        {
            try
            {
                if (!update)
                {
                    AddButtons(dgvUserList, TableType.UserTable);
                    dgvUserList.DataSource = DataAccess.LoadUserList();
                    CustomizeTable(dgvUserList, TableType.UserTable);
                }
                else
                {
                    dgvUserList.DataSource = DataAccess.LoadUserList();
                    dgvUserList.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Represents the method which perform actions for EDIT,DELETE buttons from
        /// User List DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
                {
                    if ((dgvUserList.Columns[e.ColumnIndex].GetType().Equals(typeof(DGVimageButtonDeleteColumn))) ||
                        (dgvUserList.Columns[e.ColumnIndex].GetType().Equals(typeof(DGVimageButtonEditColumn))))
                    {
                        string id = dgvUserList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string username = dgvUserList.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string fullname = dgvUserList.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string cnp = dgvUserList.Rows[e.RowIndex].Cells[5].Value != null ? dgvUserList.Rows[e.RowIndex].Cells[5].Value.ToString() : "";
                        string role = dgvUserList.Rows[e.RowIndex].Cells[6].Value.ToString();
                        string email = dgvUserList.Rows[e.RowIndex].Cells[7].Value.ToString();
                        string phone = dgvUserList.Rows[e.RowIndex].Cells[8].Value.ToString();
                        string profile = dgvUserList.Rows[e.RowIndex].Cells[9].Value.ToString();
                        string year = dgvUserList.Rows[e.RowIndex].Cells[10].Value.ToString();

                        currentAccountId = id;
                        currentUsernameEdit = username;
                        currentPhoneEdit = phone;
                        currentCnpEdit = cnp;
                        currentEmailEdit = email;


                        switch (e.ColumnIndex)
                        {

                            case 0:
                                DialogResult deleteDialog = MessageBox.Show($"Do you really want to delete this user?\n\nID: {id}\nUsername: {username}\nName: {fullname}\nCNP: {cnp}\n Profile: {profile}\n Role: {role}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (deleteDialog == DialogResult.Yes)
                                {
                                    DataAccess.DeleteUser(int.Parse(id));
                                    dgvUserList.DataSource = DataAccess.LoadUserList();
                                    dgvUserList.Refresh();
                                }
                                break;
                            case 1:
                                Account account = (from acc in DataAccess._dbContext.Account
                                                   where acc.Id == int.Parse(id)
                                                   select acc).FirstOrDefault();

                                txtboxUsernameEdit.Text = username;
                                txtboxPasswordEdit.Text = account.Password;
                                txtboxFullNameEdit.Text = fullname;
                                txtboxCnpEdit.Text = cnp;
                                txtboxPhoneEdit.Text = phone;
                                txtboxEmailEdit.Text = email;
                                numBtnYearEdit.Value = int.Parse(year);
                                droBtnProfilesEdit.Text = profile;

                                switch (role)
                                {
                                    case "STUDENT":
                                        radBtnStudentEdit.Checked = true;
                                        radBtnAdminEdit.Checked = false;
                                        _role_id_selected = 2;
                                        break;
                                    case "ADMIN":
                                        radBtnAdminEdit.Checked = true;
                                        radBtnStudentEdit.Checked = false;
                                        _role_id_selected = 1;
                                        break;
                                }

                                switch (profile)
                                {
                                    case "CALCULATOARE":
                                        _profile_id_selected = 1;
                                        break;
                                    case "CONTABILITATE":
                                        _profile_id_selected = 2;
                                        break;
                                }

                                pageEditUser.Visible = true;
                                navigator.SelectedPage = pageEditUser;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method for update user from User List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdateEdit_Click(object sender, EventArgs e)
        {
            if (DataAccess._isConnection && ValidateFields(true))
            {
                if (!CheckIfExist(true))
                {
                    try
                    {
                        /// ACCOUNT 
                        string editUsername = txtboxUsernameEdit.Text;
                        string editPassword = txtboxPasswordEdit.Text;
                        int editProfile = _profile_id_selected;
                        int editRole = _role_id_selected;

                        /// PERSON
                        string fullname = txtboxFullNameEdit.Text;
                        string email = txtboxEmailEdit.Text;
                        string CNP = txtboxCnpEdit.Text;
                        string phone = txtboxPhoneEdit.Text;

                        if (DataAccess.UpdateUser(currentAccountId, editUsername, editPassword, editProfile, editRole, fullname, email, CNP, phone))
                        {
                            MessageBox.Show("Account updated succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDgvUserList(true);
                            pageEditUser.Visible = false;
                            pageUserList.Select();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Represents the radio button for ADMINISTRATOR from Edit User page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBtnAdminEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the radio button for STUDENT from Edit User page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBtnStudentEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _role_id_selected = 2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region COURSE LIST PAGE

        /// <summary>
        /// Represents the method that load course list and set make course list visible to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCourse_Click(object sender, EventArgs e)
        {
            foreach (var page in navigator.Pages) page.Visible = false;

            LoadDgvCourseList();
            pageCourseList.Visible = true;
            pageCreateCourse.Visible = true;
        }
        /// <summary>
        /// Represents the method that validate,check if exist and then create de course
        /// Its actionate by btnCreateCourse from Create Course page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess._isConnection && ValidateCourseFields())
                {
                    /// COURSE
                    string courseName = txtboxCourseNameCreateCourse.Text;
                    string courseAbrv = txtboxAbvrCreateCourse.Text;
                    string courseTeacherName = txtboxTeacherNameCreateCourse.Text;
                    int courseType = _course_type_selected;
                    int courseYear = (int)numBtnYearCreateCourse.Value;
                    int courseSemester = (int)numBtnSemesterCreateCourse.Value;
                    int courseProfile = _course_profile_selected;
                    int courseExamMode = _course_examination_selected;
                    int courseCredit = int.Parse(numBtnCreditCreateCourse.Value.ToString());

                    Tuple<bool, string> courseExist = DataAccess.CheckIfCourseExist(courseName, courseAbrv, courseProfile);

                    if (courseExist.Item1)
                    {
                        MessageBox.Show($"{courseExist.Item2}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Tuple<bool, string> createCourse = DataAccess.CreateCourse(courseName, courseAbrv, courseTeacherName, courseType, courseYear, courseSemester, courseProfile,courseExamMode,courseCredit);
                    MessageBox.Show($"{createCourse.Item2}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Represents the method that validate course fields for creating 
        /// </summary>
        /// <returns></returns>
        private bool ValidateCourseFields()
        {
            try
            {
                /// Course name cannot be empty
                if (string.IsNullOrWhiteSpace(txtboxCourseNameCreateCourse.Text))
                {
                    MessageBox.Show("The course name cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Abbreviation cannot be empty
                if (string.IsNullOrWhiteSpace(txtboxAbvrCreateCourse.Text))
                {
                    MessageBox.Show("The abbreviation cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Teacher name cannot be null
                if (string.IsNullOrWhiteSpace(txtboxTeacherNameCreateCourse.Text))
                {
                    MessageBox.Show("The teacher name cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Teacher NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
                if (!txtboxTeacherNameCreateCourse.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("The teacher name can only contain letters and whitespaces!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxTeacherNameCreateCourse.Text = string.Empty;
                    return false;
                }

                if(_course_examination_selected == 0)
                {
                    MessageBox.Show("The examination mode of course was not selected!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(numBtnCreditCreateCourse.Value.ToString(), out var credit))
                {
                    MessageBox.Show("The credit number cannot have decimals!", "Incorrect field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numBtnCreditCreateCourse.Value = 0;
                    return false;
                }

                /// Must select a profile for this course
                if (_course_profile_selected == 0)
                {
                    MessageBox.Show("The profile of course was not selected!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// MAKE COURSE NAME WITH ALL LETTERS UPERCASE
                txtboxCourseNameCreateCourse.Text = txtboxCourseNameCreateCourse.Text.ToUpper();

                /// MAKE ABVR WITH ALL LETTERS UPERCASE
                txtboxAbvrCreateCourse.Text = txtboxAbvrCreateCourse.Text.ToUpper();

                /// MAKE TEACHER NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
                /// EX: lungu razvan to Lungu Razvan
                string[] lastNameSpliter = txtboxTeacherNameCreateCourse.Text.Split(' ');
                foreach (string name in lastNameSpliter)
                {
                    string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                    txtboxTeacherNameCreateCourse.Text = txtboxTeacherNameCreateCourse.Text.Replace(name, withFirstLetterUp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void DgvCourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
                {
                    if ((dgvCourseList.Columns[e.ColumnIndex].GetType().Equals(typeof(DGVimageButtonDeleteColumn))))
                    {
                        string id = dgvCourseList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string courseName = dgvCourseList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string courseAbrv = dgvCourseList.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string teacherName = dgvCourseList.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string profileName = dgvCourseList.Rows[e.RowIndex].Cells[5].Value.ToString();
                        string type = dgvCourseList.Rows[e.RowIndex].Cells[6].Value.ToString();
                        string year = dgvCourseList.Rows[e.RowIndex].Cells[7].Value.ToString();
                        string semester = dgvCourseList.Rows[e.RowIndex].Cells[8].Value.ToString();

                        switch (e.ColumnIndex)
                        {

                            case 0:
                                DialogResult deleteDialog = MessageBox.Show($"Do you really want to delete this course?\n\nID: {id}\nCourse Name: {courseName}\nName: {courseAbrv}\nType: {type}\nTeacher Name: {teacherName}\nYear: {year}\nSemester: {semester}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (deleteDialog == DialogResult.Yes)
                                {
                                    Tuple<bool, string> isDeleted = DataAccess.DeleteCourse(int.Parse(id));
                                    if (isDeleted.Item1)
                                    {
                                        MessageBox.Show(isDeleted.Item2, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvCourseList.DataSource = DataAccess.LoadCourseList();
                                        dgvCourseList.Update();
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RadbtnExamenCourseType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _course_type_selected = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RadBtnColocviuCourseType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _course_type_selected = 2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
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
            ConnectionTick connectionTick = new ConnectionTick(null);
            connectionTick.StartTimer();
        }

        private void SelectProfileCalculatoare_Execute(object sender, EventArgs e)
        {
            try
            {
                _profile_id_selected = 1;
                droBtnProfilesCreate.Text = "CALCULATOARE";
                droBtnProfilesEdit.Text = "CALCULATOARE";
                droBtnProfilesCreateCourse.Text = "CALCULATOARE";
                _course_profile_selected = 1;
            }
            catch (Exception ex)
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
                droBtnProfilesEdit.Text = "CONTABILITATE";
                droBtnProfilesCreateCourse.Text = "CONTABILITATE";
                _course_profile_selected = 2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            foreach (var page in navigator.Pages) page.Visible = false;
        }

        private void btnPresence_Click(object sender, EventArgs e)
        {
            foreach (var page in navigator.Pages) page.Visible = false;
        }

        private void Dashboard_MaximumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        /// <summary>
        /// Represents the method that fix the visual bug of course dgv 
        /// when appear .. in some cells by resizing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Resize_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                if (navigator.SelectedPage == pageCourseList)
                {
                    CustomizeTable(dgvCourseList, TableType.CourseTable);
                }
            }
        }

        private void kryptonRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void togBtnWrittenCreateCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (togBtnWrittenCreateCourse.Checked)
            {
                togBtnOralCreateCourse.Checked = false;
                togBtnWrittenCreateCourse.BackColor = Color.LightSeaGreen;
                togBtnWrittenCreateCourse.ForeColor = Color.White;
                _course_examination_selected = 1;
            }
            else
            {
                togBtnWrittenCreateCourse.Checked = false;
                togBtnWrittenCreateCourse.BackColor = Color.White;
                togBtnWrittenCreateCourse.ForeColor = Color.Black;
                _course_examination_selected = 0;
            }
        }

        private void togBtnOralCreateCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (togBtnOralCreateCourse.Checked)
            {
                togBtnWrittenCreateCourse.Checked = false;
                togBtnOralCreateCourse.BackColor = Color.LightSeaGreen;
                togBtnOralCreateCourse.ForeColor = Color.White;
                _course_examination_selected = 2;
            }
            else
            {
                togBtnOralCreateCourse.Checked = false;
                togBtnOralCreateCourse.BackColor = Color.White;
                togBtnOralCreateCourse.ForeColor = Color.Black;
                _course_examination_selected = 0;
            }
        }
    }
}
