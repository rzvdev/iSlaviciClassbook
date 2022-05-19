using iSlavici.Controls.Dgv;
using iSlavici.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class StudentNoteUC : UserControl
    {
        public static StudentNoteDGV StudentNoteDGV { get; set; }

        public StudentNoteUC(string studentCnp, string courseName) {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable(studentCnp,courseName);
        }

        private void CreateAndAssignTable(string studentCnp,string courseName) {
            StudentNoteDGV = StudentNoteDGV.Create(studentCnp, courseName);
            Controls.Add(StudentNoteDGV);
        }
    }
}
