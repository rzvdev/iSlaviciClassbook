using iSlavici.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kryptonProject
{
    public partial class loginForm : Form
    {
        private static bool _connected = false;

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                Timer timer = new Timer();
                timer.Interval = int.Parse(ConfigurationManager.AppSettings["CHECK_CONNECTION_INTERVAL"]);
                timer.Tick += new EventHandler(Check_Connection_Tick);
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void Check_Connection_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.TryConnection())
                {
                    labelConnectionStatusPicture.Image = iSlavici.Properties.Resources.online_24px;
                    _connected = true;
                }
                else
                {
                    labelConnectionStatusPicture.Image = iSlavici.Properties.Resources.offline_24px;
                    _connected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Check Connection Tick Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw ex;
            }
        }

    }
}
