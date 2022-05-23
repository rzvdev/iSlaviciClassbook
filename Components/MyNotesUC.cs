using iSlavici.Controls.Dgv;
using System;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class MyNotesUC : UserControl
    {
        public MyNotesDGV MyNotesDGV { get; set; }

        public MyNotesUC() {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }

        private void CreateAndAssignTable() {
            MyNotesDGV = MyNotesDGV.Create();
            Controls.Add(MyNotesDGV);
        }
    }
}
