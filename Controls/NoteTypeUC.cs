using iSlavici.Controls.Dgv;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class NoteTypeUC : UserControl
    {
        public NoteTypeDGV noteTypeDGV { get; set; }

        public NoteTypeUC() {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }
        private void CreateAndAssignTable() {
            noteTypeDGV = NoteTypeDGV.GetInstance();
            Controls.Add(noteTypeDGV);
        }
    }
}
