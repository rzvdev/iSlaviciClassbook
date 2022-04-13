using classbook.Connection;
using iSlavici.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls.Dgv
{
    public class StudentNoteDGV : TableDGV
    {
        private readonly string _studentCnp;
        private readonly string _courseName;
        private StudentNoteDGV(string studentCnp,string courseName) {
            _studentCnp = studentCnp;
            _courseName = courseName;
        }

        public static StudentNoteDGV Create(string studentCnp, string courseName) {
            StudentNoteDGV studentNoteDGV = new StudentNoteDGV(studentCnp,courseName);
             studentNoteDGV.InitializeTable();
            return studentNoteDGV;
        }

        public override void InitializeTable() {
             SetTableSettings(this);
             AddColumns();
             FillTable();
        }

        public override void AddColumns() {
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

                Columns.Insert(0, courseColumn);
                Columns.Insert(1, abvrColumn);
                Columns.Insert(2, teacherColumn);
                Columns.Insert(3, typeColumn);
                Columns.Insert(4, noteColumn);
                Columns.Insert(5, addDateColumn);
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            throw new NotImplementedException();
        }

        public override void FillTable() {
             LoadData();
            foreach (var note in DataAccess.studentNotes) {
                Rows.Add(note.SubjectName, note.SubjectAbvr, note.TeacherName, note.NoteType, note.Note, note.DateAdded);
            }
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
    }
}
