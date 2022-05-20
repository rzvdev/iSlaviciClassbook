using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Controls.Dgv
{
    public class StudentNoteDGV : TableDGV
    {
        private readonly string _studentCnp;
        private readonly string _courseName;
        private StudentNoteDGV(string studentCnp, string courseName) {
            _studentCnp = studentCnp;
            _courseName = courseName;
        }

        public static StudentNoteDGV Create(string studentCnp, string courseName) {
            StudentNoteDGV studentNoteDGV = new StudentNoteDGV(studentCnp, courseName);
            studentNoteDGV.InitializeTable();
            return studentNoteDGV;
        }

        public override void InitializeTable() {
            CellClick += ButtonCellClick;
            SetTableSettings(this);
            AddColumns();
            FillTable();
        }

        public override void AddColumns() {
            DataGridViewColumn idColumn = new DataGridViewColumn {
                Width = 50,
                HeaderText = "ID",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn courseColumn = new DataGridViewColumn {
                Width = 300,
                HeaderText = "COURSE",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn abvrColumn = new DataGridViewColumn {
                Width = 80,
                HeaderText = "ABVR",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn teacherColumn = new DataGridViewColumn {
                Width = 250,
                HeaderText = "TEACHER",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn typeColumn = new DataGridViewColumn {
                Width = 200,
                HeaderText = "TYPE",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn noteColumn = new DataGridViewColumn {
                Width = 50,
                HeaderText = "NOTE",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn addDateColumn = new DataGridViewColumn {
                Width = 100,
                HeaderText = "DATE ADDED",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn delNoteColumn = new DataGridViewColumn {
                Width = 70,
                HeaderText = "DELETE",
                CellTemplate = new DataGridViewButtonCell(),
                Tag = "btnDelNote",
            };


            Columns.Insert(0, idColumn);
            Columns.Insert(1, courseColumn);
            Columns.Insert(2, abvrColumn);
            Columns.Insert(3, teacherColumn);
            Columns.Insert(4, typeColumn);
            Columns.Insert(5, noteColumn);
            Columns.Insert(6, addDateColumn);
            Columns.Insert(7, delNoteColumn);

        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                // TREATING APPEAR TWO TIMES THE DIALOG RESULT
                if (!(sender is StudentNoteDGV)) return;

                if ((e.RowIndex < 0) || (e.ColumnIndex < 0)) return;

                if (e.ColumnIndex == 7) {
                    string noteId = Convert.ToString(Rows[e.RowIndex].Cells[0].Value) ?? string.Empty;
                    string noteType = Convert.ToString(Rows[e.RowIndex].Cells[3].Value) ?? string.Empty;
                    string noteVal = Convert.ToString(Rows[e.RowIndex].Cells[4].Value) ?? string.Empty;
                    string date = Convert.ToString(Rows[e.RowIndex].Cells[5].Value) ?? string.Empty;

                    Note note = (from not in DataAccess._dbContext.Note
                                 where not.Id == int.Parse(noteId)
                                 select not).FirstOrDefault();

                    if (note == null) {
                        MessageBox.Show("Cannot find that note! Contact developer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    switch (e.ColumnIndex) {
                        case 7:
                            DialogResult dg = MessageBox.Show($"Are you sure you want to delete this note?\n\nID:{noteId}\nTYPE:{noteType}\nNOTE:{noteVal}\nDATE:{date}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dg == DialogResult.Yes) {
                                DataAccess.DeleteNote(int.Parse(noteId));
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

        public override void FillTable() {
            LoadData();
            foreach (var note in DataAccess.studentNotes.OrderBy(n => n.DateAdded)) {
                Rows.Add(note.NoteId,note.SubjectName, note.SubjectAbvr, note.TeacherName, note.NoteType, note.Note, FormattedDate(note.DateAdded));
            }
        }

        private string FormattedDate(DateTime date) {
            return date.ToString("dd/MM/yyyy");
        }

        public override void LoadData() {
            DataAccess.LoadStudentNotes(_studentCnp, _courseName);
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }

        public override void FillTableFiltred(IFiltrable filtred) {
            Rows.Clear();
            List<NoteOneStudentListModel> notes = filtred.GetOneStudentNoteList();
            foreach (var note in notes.OrderBy(n => n.DateAdded)) {
                Rows.Add(note.NoteId,note.SubjectName, note.SubjectAbvr, note.TeacherName, note.NoteType, note.Note, FormattedDate(note.DateAdded));
            }
        }

     
    }
}
