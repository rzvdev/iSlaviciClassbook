using classbook.Connection;
using classbook.Utility;
using iSlavici.Connection.Models.db;
using iSlavici.Forms;
using iSlavici.Models;
using iSlavici.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
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
            DataAccess.LoadUserList();
            pageEditUser.Visible = false;

            //panelAdmin.BringToFront();
            splitcontainerLeftSide.Dock = DockStyle.Fill;
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
                //panelStudent.Visible = true;
                //panelStudent.Enabled = true;
                BringToFront();

                //panelAdmin.Enabled = false;
                //panelAdmin.Visible = false;

            }
            else
            {
               //panelAdmin.Visible = true;
               // panelAdmin.Enabled = true;
                BringToFront();

                //panelStudent.Enabled = false;
                //panelStudent.Visible = false;
            }
        }

        private async Task LoadNoteListAsync()
        {
            await DataAccess.LoadNoteListAsync();
        }

        private async Task LoadDgvNoteList()
        {

            try
            {
                await LoadNoteListAsync();
                dgvNoteList.DataSource = DataAccess.noteList;
                TableCustomize customize = new TableCustomize(dgvNoteList, TableType.NoteTable);

                for (int i = 0; i < dgvNoteList.Columns.Count; i++)
                {
                    DataGridViewColumn col = dgvNoteList.Columns[i];
                    if (col.Tag != null)
                    {
                        if (col.Tag.Equals("dgvDeleteBtn") || col.Tag.Equals("dgvEditBtn"))
                        {
                            dgvNoteList.Columns.RemoveAt(i);
                        }
                    }
                }

                customize.CustomizeTable();
                customize.AddButtons();
                dgvNoteList.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadDgvCourseList()
        {
            try
            {
                TableCustomize customize = new TableCustomize(dgvCourseList, TableType.CourseTable);
                customize.AddButtons();
                dgvCourseList.DataSource = DataAccess.LoadCourseList();
                customize.CustomizeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

                        /// STUDENT
                        int inYear = int.Parse(numBtnYearCreate.Value.ToString());

                        if (DataAccess.CreateUser(username, password, profileId, roleId, fullName, email, cnp, phone,inYear))
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
                    TableCustomize customize = new TableCustomize(dgvUserList, TableType.UserTable);
                    customize.AddButtons();
                    dgvUserList.DataSource = DataAccess.userList;
                    customize.CustomizeTable();
                }
                else
                {
                    DataAccess.LoadUserList();
                    dgvUserList.DataSource = DataAccess.userList;
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
                                    dgvUserList.DataSource = DataAccess.userList;
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
                        int editRole = _role_id_selected;

                        /// PERSON
                        string fullname = txtboxFullNameEdit.Text;
                        string email = txtboxEmailEdit.Text;
                        string CNP = txtboxCnpEdit.Text;
                        string phone = txtboxPhoneEdit.Text;

                        /// STUDENT
                        int editProfile = _profile_id_selected;
                        int inYear = int.Parse(numBtnYearEdit.Value.ToString());


                        if (DataAccess.UpdateUser(currentAccountId, editUsername, editPassword, editRole, fullname, email, CNP, phone,editProfile,inYear))
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
        /// 8<param name="e"></param>
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

                    Tuple<bool, string> createCourse = DataAccess.CreateCourse(courseName, courseAbrv, courseTeacherName, courseType, courseYear, courseSemester, courseProfile, courseExamMode, courseCredit);
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

                if (_course_examination_selected == 0)
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

        private async void btnNotes_Click(object sender, EventArgs e)
        {
            foreach (var page in navigator.Pages) page.Visible = false;

            await LoadDgvNoteList();
            InitializeComboboxes();
            pageNoteList.Visible = true;
            pageAddNote.Visible = true;
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
                    TableCustomize customize = new TableCustomize(dgvCourseList, TableType.CourseTable);
                    customize.CustomizeTable();
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

        private void txtboxSearchAddNote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //  dgvAddNote.DataSource = notes.Where(n => n.StudentName.ToLower().Contains(txtboxSearchAddNote.Text.ToLower()))
                //                             .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void dgvAddNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
                {
                    if ((dgvNoteList.Columns[e.ColumnIndex].GetType().Equals(typeof(DGVimageButtonDeleteColumn))) ||
                        (dgvNoteList.Columns[e.ColumnIndex].GetType().Equals(typeof(DGVimageButtonEditColumn))))
                    {
                        string id = dgvNoteList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string personName = dgvNoteList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string subjectName = dgvNoteList.Rows[e.RowIndex].Cells[3].Value.ToString();

                        var person = (from p in DataAccess._dbContext.Person
                                      where p.FullName == personName
                                      select p).FirstOrDefault();

                        var account = (from ac in DataAccess._dbContext.Account
                                       where ac.PersonId == person.Id
                                       select ac).FirstOrDefault();

                        var student = (from st in DataAccess._dbContext.Student
                                       where st.PersonId == person.Id
                                       select st).FirstOrDefault();

                        var profile = (from pro in DataAccess._dbContext.Profile
                                       where pro.Id == student.ProfileId
                                       select pro).FirstOrDefault();

                        var subject = (from sub in DataAccess._dbContext.Subject
                                       where sub.Name == subjectName
                                       select sub).FirstOrDefault();

                        switch (e.ColumnIndex)
                        {
                            case 0:
                                SendToBack();
                                AddNote addNote = new AddNote(person, profile,subject);


                                addNote.Show();
                                addNote.BringToFront();
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



        private async void InitializeComboboxes()
        {
            try
            {
                cbNameAddNote.Items.Clear();
                cbCourseAddNote.Items.Clear();
                cbNoteTypeAddNote.Items.Clear();

                List<string> studentNames = await (from st in DataAccess._dbContext.Person
                                                   where st.Account.RoleId == 2
                                                   select st.FullName).ToListAsync();

                List<string> courseNames = await (from c in DataAccess._dbContext.Subject
                                                  select c.Name).ToListAsync();

                List<string> noteTypes = await (from nt in DataAccess._dbContext.NoteType
                                                select nt.TypeName).ToListAsync();

                cbNameAddNote.Items.AddRange(studentNames.ToArray());
                cbCourseAddNote.Items.AddRange(courseNames.ToArray());
                cbNoteTypeAddNote.Items.AddRange(noteTypes.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Person _personToAddNote;
        private Account _accountToAddNote;
        private Profile _profileToAddNote;
        private Subject _subjectToAddNote;
        private NoteType _noteTypeToAddNote;

        private void cbNameAddNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string studentName = cbNameAddNote.SelectedItem.ToString();

                _personToAddNote = (from p in DataAccess._dbContext.Person
                                    where p.FullName == studentName
                                    select p).FirstOrDefault();

                _accountToAddNote = (from ac in DataAccess._dbContext.Account
                                     where ac.PersonId == _personToAddNote.Id
                                     select ac).FirstOrDefault();

                var student = (from stu in DataAccess._dbContext.Student
                               where stu.Id == _personToAddNote.Id
                               select stu).FirstOrDefault();

                _profileToAddNote = (from pr in DataAccess._dbContext.Profile
                                     where pr.Id == student.ProfileId
                                     select pr).FirstOrDefault();

                lblCnpValueAddNote.Text = _personToAddNote.CNP;
                lblProfileValueAddNote.Text = _profileToAddNote.Name;
                lblYearValueAddNote.Text = 1.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddInAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (_personToAddNote == null || _accountToAddNote == null || _profileToAddNote == null) throw new ArgumentNullException();
                if (DataAccess.AddNote(_personToAddNote,_subjectToAddNote,_noteTypeToAddNote,int.Parse(numBtnAddNoteValue.Value.ToString())))
                {
                    dgvNoteList.DataSource = DataAccess.LoadNoteListAsync();
                    MessageBox.Show("Note was added with succes!","SUCCES",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Cannot add this note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCourseAddNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _subjectToAddNote = (from sub in DataAccess._dbContext.Subject
                                     where sub.Name == cbCourseAddNote.SelectedItem.ToString()
                                     select sub).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbNoteTypeAddNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _noteTypeToAddNote = (from nt in DataAccess._dbContext.NoteType
                                     where nt.TypeName == cbNoteTypeAddNote.SelectedItem.ToString()
                                     select nt).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitcontainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitcontainerLeftSide_Panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void pageAddNote_Click(object sender, EventArgs e)
        {

        }

        private void panelAdmin_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
