using classbook.Connection;
using iSlavici.Models;
using System;
using System.Windows.Forms;

namespace iSlavici.Controls.Dgv
{
    public class NoteTypeDGV : TableDGV
    {
        private static NoteTypeDGV instance = null;

        private NoteTypeDGV() {

        }

        public static NoteTypeDGV GetInstance() {
            if (instance == null) {
                instance = new NoteTypeDGV();
                instance.InitializeTable();
            }
            return instance;
        }

        public override void AddColumns() {
            try {
                DataGridViewColumn deleteBtnColumn = new DataGridViewColumn {
                    Width = 50,
                    HeaderText = "DEL.",
                    CellTemplate = new DataGridViewButtonCell(),
                    Tag = "btnDel",
                };

                DataGridViewColumn idColumn = new DataGridViewColumn {
                    Width = 50,
                    HeaderText = "ID",
                    CellTemplate = new DataGridViewTextBoxCell(),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                DataGridViewColumn typeColumn = new DataGridViewColumn {
                    Width = 250,
                    HeaderText = "TYPE",
                    CellTemplate = new DataGridViewTextBoxCell(),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                Columns.Insert(0, idColumn);
                Columns.Insert(1, typeColumn);
                Columns.Insert(2, deleteBtnColumn);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void FillTable() {
            LoadData();
            foreach (var type in DataAccess.noteTypes) {
                Rows.Add(type.Id, type.TypeName);
            }
            Refresh();
        }

        public override void InitializeTable() {
            CellClick += ButtonCellClick;
            SetTableSettings(this);
            BackgroundColor = System.Drawing.Color.WhiteSmoke;
            AddColumns();
            FillTable();
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                // TREATING APPEAR TWO TIMES THE DIALOG RESULT
                if (!(sender is NoteTypeDGV)) return;

                if ((e.RowIndex < 0) || (e.ColumnIndex < 0)) return;

                if (e.ColumnIndex == 2) {
                    string id = Convert.ToString(Rows[e.RowIndex].Cells[0].Value) ?? string.Empty;
                    string typeName = Convert.ToString(Rows[e.RowIndex].Cells[1].Value) ?? string.Empty;

                    switch (e.ColumnIndex) {
                        // DELETE BUTTON
                        case 2:
                            DialogResult dg = MessageBox.Show($"Do you really want to delete this note type?\nThe notes with this type of note will still exist!\n\nID: {id}\nTYPE: {typeName}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dg == DialogResult.Yes) {
                                DataAccess.DeleteNoteType(int.Parse(id));
                                RefreshData();
                                return;
                            }
                            break;
                    }
                }

            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void LoadData() {
            DataAccess.LoadNoteTypes();
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }
    }
}
