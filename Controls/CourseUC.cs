using iSlavici.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class CourseUC : UserControl
    {
        public TableDGV courseDGV { get; set; }

        public CourseUC()
        {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }

        private void CreateAndAssignTable()
        {
            courseDGV = CourseDGV.GetInstance();
            Controls.Add(courseDGV);
        }
    }
}
