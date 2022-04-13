using classbook.Connection;
using iSlavici.Connection.Models.db;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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


            Columns.Insert(0, idColumn);
            Columns.Insert(1, studentColumn);
            Columns.Insert(2, courseColumn);
            Columns.Insert(3, abvrColumn);
            Columns.Insert(4, teacherColumn);
            Columns.Insert(5, typeColumn);
            Columns.Insert(6, noteColumn);
            Columns.Insert(7, addDateColumn);
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
                Rows.Add(note.Id, note.StudentName, note.SubjectName, note.SubjectAbrv, note.TeacherName, note.NoteType, note.NoteValue, note.AddedDate);
            }
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            throw new NotImplementedException();
        }

    }
}
