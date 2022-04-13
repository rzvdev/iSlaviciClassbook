using iSlavici.Controls.Navigator;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Forms
{
    public partial class testNav : Form
    {
        public testNav() {
            InitializeComponent();
            InitializeNavAndAssign();
        }

        private void InitializeNavAndAssign() {
            Navigator nav = Navigator.GetInstance();
                nav.Dock = DockStyle.Fill;
                nav.Visible = true;
                Controls.Add(nav);
        }
    }
}
