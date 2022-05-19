using iSlavici.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class NoteUC : UserControl
    {
        public TableDGV noteDGV;

        public NoteUC() {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }

        private void CreateAndAssignTable() {

            noteDGV = NoteDGV.Create();
            Controls.Add(noteDGV);
        }
    }
}
