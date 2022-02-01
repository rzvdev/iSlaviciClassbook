using classbook.Connection;
using classbook.Utility;
using iSlavici.Utility;
using System;
using System.Windows.Forms;

namespace classbook
{
    public partial class Dashboard : Form
    {
        private readonly Resize _resize;

        public Dashboard()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            _resize = new Resize(this);
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;
            labelPersonName.Text = $"{DataAccess._loggedPerson.FirstName} { DataAccess._loggedPerson.LastName}";
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            _resize.ResizeForm();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _resize.GetInitialSize();
            SendToBack();
            ConnectionTick connectionTick = new ConnectionTick(null);
            connectionTick.StartTimer();
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            if (navigator.Pages.Contains(pageCreateUser) && pageCreateUser.Visible == false) pageCreateUser.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
