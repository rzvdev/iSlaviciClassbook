using classbook.Connection;
using iSlavici.Connection.Models.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelAddNoteTypeUC : UserControl
    {
        public PanelAddNoteTypeUC() {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void BtnAddClickEvent(object sender, EventArgs e) {
            try {
                if (!ValidateFields()) return;
                if (CheckIfExists()) return;

                string typeName = txtboxNoteType.Text;

                DataAccess.AddNoteType(typeName);
                Navigator.Navigator.GetInstance().RefreshNoteTypesDGV();
                DataAccess.LoadNoteTypes();
                txtboxNoteType.Text = string.Empty;

            } catch (Exception ex) {
                throw ex;
            }
        }


        private bool CheckIfExists() {
            string typeName = txtboxNoteType.Text;

            NoteType noteType = (from nt in DataAccess._dbContext.NoteType
                                 where nt.TypeName == typeName
                                 select nt).FirstOrDefault();

            if (noteType != null) {
                MessageBox.Show("That note type already exists!", "Already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool ValidateFields() {
            if (string.IsNullOrEmpty(txtboxNoteType.Text)) {
                MessageBox.Show("The note type name cannot be empty!", "Invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            txtboxNoteType.Text = txtboxNoteType.Text.ToUpper();
            return true;
        }
    }
}
