using classbook.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelMyProfileUC : UserControl
    {
        public PanelMyProfileUC() {
            InitializeComponent();
        }

        private void PanelMyProfileUC_Load(object sender, EventArgs e) {
            InitializeProfileInfo();
        }


        private void InitializeProfileInfo() {
            string username = DataAccess._loggedAccount.Username;
            string role = DataAccess._loggedRole.Name;
            string createdDate = DataAccess._loggedPerson.CreatedDate.ToString("dd/MM/yyyy");
            string fullName = DataAccess._loggedPerson.FullName;
            string cnp = DataAccess._loggedPerson.CNP;
            string email = DataAccess._loggedPerson.Email;
            string phone = DataAccess._loggedPerson.Phone;

            string profile = string.Empty;
            string currentStudyYear = string.Empty;
            string promotionYear = string.Empty;

            if(DataAccess._loggedStudent != null) {
                profile = DataAccess._loggedProfile.Name;
                currentStudyYear = DataAccess._loggedStudent.InYear.ToString();
                promotionYear = String.Format("{0} - {1}",DataAccess._loggedStudent.StartYear.Year,DataAccess._loggedStudent.EndYear.Year);

                lblProfileValue.Text = profile;
                lblCurrStudyYearValue.Text = currentStudyYear;
                lblPromYearValue.Text = promotionYear;
            }

            lblUsernameValue.Text = username;
            lblRoleValue.Text = role;
            lblCreatedDateValue.Text = createdDate;
            lblFullNameValue.Text = fullName;
            lblCnpValue.Text = cnp;
            lblEmailValue.Text = email;
            lblPhoneValue.Text = phone;
        }
    }
}
