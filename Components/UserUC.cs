using iSlavici.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class UserUC : UserControl
    {
        public TableDGV userDGV { get; set; }
        public UserUC() {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }

        private void CreateAndAssignTable() {
            userDGV = UserDGV.GetInstance();
            Controls.Add(userDGV);
        }
    }
}
