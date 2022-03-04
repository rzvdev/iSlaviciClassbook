using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Utility;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace classbook
{
    public partial class Login : Form
    {
        private static ConnectionTick _connectionTick;

        public Login()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetSavedAccount();
                _connectionTick = new ConnectionTick(labelConnectionStatusPicture);
                _connectionTick.StartTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method that write in textboxes the saved account if that was saved
        /// </summary>
        private void SetSavedAccount()
        {
            try
            {
                bool rememberIsChecked = ConfigurationManager.AppSettings.Get("REMEMBER_CHECKED").Equals("1");
                if (rememberIsChecked)
                {
                    textboxUsername.Text = ConfigurationManager.AppSettings.Get("SAVED_USERNAME");
                    textboxPassword.Text = ConfigurationManager.AppSettings.Get("SAVED_PASSWORD");
                    checkbuttonRemember.Checked = true;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method for the button login
        /// Which first validate the fields and then if it is all ok
        /// then try to login 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate(textboxUsername, textboxPassword)) return;
                if (DataAccess._isConnection && TryLogin())
                {
                    _connectionTick.StopTimer();
                    Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        /// <summary>
        /// Represents the method that return a account,person,role,profile if that exist in database
        /// </summary>
        private bool TryLogin()
        {
            try
            {
                if (DataAccess._dbContext == null) return false;
                /// SEARCH FOR ACCOUNT IN DATABASE
                Account searchedAccount = (from acc in DataAccess._dbContext.Account
                                    where acc.Username == textboxUsername.Text &&
                                          acc.Password == textboxPassword.Text
                                    select acc).FirstOrDefault();

                /// IF THE ACCOUNT SEARCHED EXIST THEN LOG IN
                if (searchedAccount != null)
                {
                    DataAccess._loggedAccount = searchedAccount;
                    DataAccess._loggedPerson = (from person in DataAccess._dbContext.Person
                                                where person.Id == searchedAccount.PersonId
                                                select person).First();
                    DataAccess._loggedRole = (from role in DataAccess._dbContext.Role
                                              where role.Id == searchedAccount.RoleId
                                              select role).First();
                    /// THE ADMINISTRATOR ROLE CANNOT HAVE PROFILE 
                    DataAccess._loggedProfile = (from pro in DataAccess._dbContext.Profile
                                                 where pro.Id == searchedAccount.ProfileId
                                                 select pro).FirstOrDefault();

                    MessageBox.Show("You have successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Represents the method that validate if the username or password meet specific the requirments
        /// no empty fiels, no spaces and is connection
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private bool Validate(ComponentFactory.Krypton.Toolkit.KryptonTextBox username, ComponentFactory.Krypton.Toolkit.KryptonTextBox password)
        {
            try
            {
                /// CHECK IF HAVE CONNECTION TO THE INTERNET 
                if (!DataAccess._isConnection)
                {
                    MessageBox.Show("The connection is down.\nCheck your internet connection or the server is down!", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                /// CHECK IF USERNAME OR PASSWORD FIELDS IT IS NOT NULL
                if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username.Text = string.Empty;
                    password.Text = string.Empty;
                    return false;
                }

                /// CHECK IF USERNAME OR PASSWORD FIELDS DOSENT CONTAINS WHITE SPACES 
                if (username.Text.Contains(" ") || password.Text.Contains(" "))
                {
                    MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username.Text = string.Empty;
                    password.Text = string.Empty;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Represents the method that perform actions for the remember button which save the account to app.config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckbuttonRemember_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkbuttonRemember.Checked)
                {
                    Writer.UpdateConfig("SAVED_USERNAME", textboxUsername.Text);
                    Writer.UpdateConfig("SAVED_PASSWORD", textboxPassword.Text);
                    Writer.UpdateConfig("REMEMBER_CHECKED", "1");
                }
                else
                {
                    Writer.UpdateConfig("SAVED_USERNAME", "");
                    Writer.UpdateConfig("SAVED_PASSWORD", "");
                    Writer.UpdateConfig("REMEMBER_CHECKED", "");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
