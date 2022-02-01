using classbook.Connection;
using iSlavici.Connection.Models.db;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace classbook
{
    public partial class Login : Form
    {
        private static bool _isConnection = false;
        private SlaviciContext _dbContext = null;
        private Timer _connection_timer = new Timer();

        public Login()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
           SetSavedAccount();

            try
            {
                _connection_timer = new Timer
                {
                    Interval = int.Parse(ConfigurationManager.AppSettings["CHECK_CONNECTION_INTERVAL"])
                };

                _connection_timer.Tick += new EventHandler(Check_Connection_Tick);
                _connection_timer.Start();
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
            bool rememberIsChecked = ConfigurationManager.AppSettings.Get("REMEMBER_CHECKED").Equals("1");
            if (rememberIsChecked)
            {
                textboxUsername.Text = ConfigurationManager.AppSettings.Get("SAVED_USERNAME");
                textboxPassword.Text = ConfigurationManager.AppSettings.Get("SAVED_PASSWORD");
                checkbuttonRemember.Checked = true;
            }
        }

        private void Check_Connection_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.TryConnection())
                {
                    labelConnectionStatusPicture.Image = iSlavici.Properties.Resources.online_24px;
                    _isConnection = true;
                    _dbContext = new SlaviciContext();
                }
                else
                {
                    if(_isConnection)
                    {
                        _connection_timer.Stop();
                        MessageBox.Show("Connection was lost!","Connection lost",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Environment.Exit(0);
                    }

                    labelConnectionStatusPicture.Image = iSlavici.Properties.Resources.offline_24px;
                    _isConnection = false;
                    _dbContext = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Connection Tick Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Validate(textboxUsername, textboxPassword);
            if (_isConnection && TryLogin())
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();          
            }
        }




        /// <summary>
        /// Represents the method that return a account if that exist in database
        /// </summary>
        private bool TryLogin()
        {
            try
            {
                /// SEARCH FOR ACCOUNT IN DATABASE
                Account searched = (from acc in _dbContext.Account
                                    where acc.Username == textboxUsername.Text &&
                                          acc.Password == textboxPassword.Text
                                    select acc).FirstOrDefault();

                /// IF THE ACCOUNT SEARCHED EXIST THEN LOG IN
                if (searched != null)
                {
                    DataAccess._loggedAccount = searched;
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
        /// Represent the method that update the configuration file
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");

        }

        /// <summary>
        /// Represents the method that validate if the username or password meet specific the requirments
        /// no empty fiels, no spaces and is connection
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void Validate(ComponentFactory.Krypton.Toolkit.KryptonTextBox username, ComponentFactory.Krypton.Toolkit.KryptonTextBox password)
        {
            try
            {
                /// CHECK IF HAVE CONNECTION TO THE INTERNET 
                if (!_isConnection)
                {
                    MessageBox.Show("The connection is down.\nCheck your internet connection or the server is down!", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                /// CHECK IF USERNAME OR PASSWORD FIELDS IT IS NOT NULL
                if (string.IsNullOrEmpty(username.Text.Trim()) || string.IsNullOrEmpty(password.Text.Trim()))
                {
                    MessageBox.Show("The username or password cannot be empty!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username.Text = string.Empty;
                    password.Text = string.Empty;
                    return;
                }

                /// CHECK IF USERNAME OR PASSWORD FIELDS DOSENT CONTAINS WHITE SPACES 
                if (username.Text.Contains(" ") || password.Text.Contains(" "))
                {
                    MessageBox.Show("The username or password cannot contain spaces!", "Spaces in fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username.Text = string.Empty;
                    password.Text = string.Empty;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Represents the method that perform actions for the remember button which save the account to app.config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckbuttonRemember_Click(object sender, EventArgs e)
        {
            if (checkbuttonRemember.Checked)
            {
                UpdateSetting("SAVED_USERNAME",textboxUsername.Text);
                UpdateSetting("SAVED_PASSWORD",textboxPassword.Text);
                UpdateSetting("REMEMBER_CHECKED","1");
            }
            else
            {
                UpdateSetting("SAVED_USERNAME","");
                UpdateSetting("SAVED_PASSWORD","");
                UpdateSetting("REMEMBER_CHECKED","");
            }
        }
    }
}
