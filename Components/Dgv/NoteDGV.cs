using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Controls;
using iSlavici.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using classbook;

namespace iSlavici.Models
{
    public class NoteDGV : TableDGV
    {
        private NoteDGV() {
        }

        public static NoteDGV Create() {
            NoteDGV noteDGV = new NoteDGV();
            noteDGV.InitializeTable();
            return noteDGV;
        }

        public override void InitializeTable() {
            CellClick += ButtonCellClick;
            SetTableSettings(this);
            AddColumns();
            FillTable();
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                // TREATING APPEAR TWO TIMES THE DIALOG RESULT
                if (!(sender is NoteDGV)) return;

                if ((e.RowIndex < 0) || (e.ColumnIndex < 0)) return;

                if (e.ColumnIndex == 8) {
                    string studentName = Convert.ToString(Rows[e.RowIndex].Cells[1].Value) ?? string.Empty;
                    string courseName = Convert.ToString(Rows[e.RowIndex].Cells[2].Value) ?? string.Empty;

                    Subject subject = (from sub in DataAccess._dbContext.Subject
                                       where sub.Name == courseName
                                       select sub).FirstOrDefault();

                    if (subject == null) {
                        MessageBox.Show("Cannot find that course!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Profile profile = (from pro in DataAccess._dbContext.Profile
                                       where pro.Id == subject.ProfileId
                                       select pro).FirstOrDefault();

                    if (profile == null) {
                        MessageBox.Show("Cannot find that profile!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Person person = (from per in DataAccess._dbContext.Person
                                     where per.FullName == studentName
                                     select per).First();

                    Student student = (from stu in DataAccess._dbContext.Student
                                       where stu.PersonId == person.Id
                                       select stu).First();


                    switch (e.ColumnIndex) {
                        // ADD NOTE BUTTON
                        case 8:
                            AddNote addNote = new AddNote(person,profile,subject,student);
                            addNote.ShowDialog(this);
                            addNote.BringToFront();
                            break;
                    }
                }

            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void AddColumns() {
            DataGridViewColumn idColumn = new DataGridViewColumn {
                Width = 50,
                HeaderText = "ID",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn studentColumn = new DataGridViewColumn {
                Width = 250,
                HeaderText = "STUDENT",
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

            DataGridViewColumn addNoteBtnColumn = new DataGridViewColumn {
                Width = 70,
                HeaderText = "ADD NOTES",
                CellTemplate = new DataGridViewButtonCell(),
                Tag = "btnAddNote",
            };

            Columns.Insert(0, idColumn);
            Columns.Insert(1, studentColumn);
            Columns.Insert(2, courseColumn);
            Columns.Insert(3, abvrColumn);
            Columns.Insert(4, teacherColumn);
            Columns.Insert(5, typeColumn);
            Columns.Insert(6, noteColumn);
            Columns.Insert(7, addDateColumn);
            Columns.Insert(8, addNoteBtnColumn);
        }

        public override void LoadData() {
            DataAccess.LoadNotes();
            Refresh();
        }
        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }

        public override void FillTable() {
            LoadData();
            foreach (var note in DataAccess.notes) {
                Rows.Add(note.Id, note.StudentName, note.SubjectName, note.SubjectAbrv, note.TeacherName, note.NoteType, note.NoteValue, FormattedDate(note.AddedDate));
            }
        }

        private string FormattedDate(DateTime date) {
            return date.ToString("dd/MM/yyyy");
        }


        public override void FillTableFiltred(IFiltrable filtrable) {
            Rows.Clear();
            List<NoteListModel> notes = filtrable.GetNoteList();
            foreach (var note in notes) {
                Rows.Add(note.Id, note.StudentName, note.SubjectName, note.SubjectAbrv, note.TeacherName, note.NoteType, note.NoteValue, FormattedDate(note.AddedDate));
            }
        }
    }
}
