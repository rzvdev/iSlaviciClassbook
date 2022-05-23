using classbook.Connection;
using classbook.Utility;
using ComponentFactory.Krypton.Toolkit;
using iSlavici.Controls.Navigator;
using iSlavici.Utility;
using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace classbook
{
    public partial class Dashboard : Form
    {
        private static readonly string _APP_CULTURE = ConfigurationManager.AppSettings.Get("APP_CULTURE");
        private readonly Resize _resize;


        public Dashboard() {
            SetCulture(_APP_CULTURE);
            DoubleBuffered = true;
            InitializeComponent();
            _resize = new Resize(this);
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;
            labelPersonName.Text = $"{DataAccess._loggedPerson.FullName}";
            InitializeRolePanel();
        }

        private void SetCulture(string cultureString) {
            CultureInfo defaultCulture = new CultureInfo(cultureString);
            CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
            CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;
        }

        /// <summary>
        /// Represents the method that initialize Student panel or Admin panel by Role type
        /// </summary>
        private void InitializeRolePanel() {
            if (DataAccess._loggedAccount.RoleId == 2) {
                panelStudent.Visible = true;
                panelStudent.Enabled = true;
                BringToFront();

                panelAdmin.Enabled = false;
                panelAdmin.Visible = false;

            } else {
                panelAdmin.Visible = true;
                panelAdmin.Enabled = true;
                BringToFront();

                panelStudent.Enabled = false;
                panelStudent.Visible = false;
            }
        }



        private void BtnSelectGroup(object sender, EventArgs e) {
            KryptonButton btn = (KryptonButton)sender;
            Navigator nav = Navigator.GetInstance();

            if (btn == btnCourse) {
                nav.HideAllPages();
                nav.SetCoursesPageVisible();
            } else if (btn == btnProfiles) {
                nav.HideAllPages();
                nav.SetProfilesPageVisible();
            } else if (btn == btnNotes) {
                nav.HideAllPages();
                nav.SetNotesPageVisible();
            } else if (btn == btnMyProfile) {
                nav.HideAllPages();
                nav.SetProfilesPageVisible();
            } else if (btn == btnMyCourses) {
                nav.HideAllPages();
                nav.SetCoursesPageVisible(true);
            } else if (btn == btnMyNotes) {
                nav.HideAllPages();
                nav.SetNotesPageVisible(true);
            }
        }

        private void Dashboard_Resize(object sender, EventArgs e) {
            //if (dgvUserList.Visible)
            //{
            //    _resize.ResizeForm(dgvUserList.ColumnHeadersDefaultCellStyle.Font.FontFamily);
            //}
            //else
            //{
            //    _resize.ResizeForm();
            //}
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            _resize.GetInitialSize();
            ConnectionTick connectionTick = new ConnectionTick(null);
            connectionTick.StartTimer();
        }



        private void Dashboard_MaximumSizeChanged(object sender, EventArgs e) {
            MessageBox.Show("");
        }

        /// <summary>
        /// Represents the method that fix the visual bug of course dgv 
        /// when appear .. in some cells by resizing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Resize_1(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                if (navigator.SelectedPage == pageCourseList) {
                    //       TableCustomize customize = new TableCustomize(dgvCourseList, TableType.CourseTable);
                    //     customize.MakeColumns();
                }
            }
        }



        private void Dashboard_Load_1(object sender, EventArgs e) {
            LoadNavigator();
        }

        private void LoadNavigator() {
            Navigator nav = Navigator.GetInstance();
            nav.Dock = DockStyle.Fill;
            nav.Visible = true;
            nav.HideAllPages();
            splitcontainer.Panel2.Controls.Add(nav);
        }

  
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void kryptonButton1_Click(object sender, EventArgs e) {

        }

        private void btnManageNews_Click(object sender, EventArgs e) {

        }
    }
}
