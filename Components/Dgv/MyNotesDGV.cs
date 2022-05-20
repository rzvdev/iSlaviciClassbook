using classbook.Connection;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Controls.Dgv
{
    public class MyNotesDGV : TableDGV
    {
        private static MyNotesDGV instance = null;

        private MyNotesDGV() {
        }

        public static MyNotesDGV Create() {
            MyNotesDGV noteDGV = new MyNotesDGV();
            noteDGV.InitializeTable();
            return noteDGV;
        }

        public static MyNotesDGV GetInstance() {
            if (instance == null) {
                instance = new MyNotesDGV();
                instance.InitializeTable();
            }
            return instance;
        }

        public override void AddColumns() {
            DataGridViewColumn idColumn = new DataGridViewColumn {
                Width = 50,
                HeaderText = "ID",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn courseColumn = new DataGridViewColumn {
                Width = 400,
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
            Columns.Insert(1, courseColumn);
            Columns.Insert(2, abvrColumn);
            Columns.Insert(3, teacherColumn);
            Columns.Insert(4, typeColumn);
            Columns.Insert(5, noteColumn);
            Columns.Insert(6, addDateColumn);
        }

        public override void FillTable() {
            LoadData();
            foreach (var note in DataAccess.studentNotes.OrderBy(n => n.DateAdded)) {
                Rows.Add(note.NoteId, note.SubjectName, note.SubjectAbvr, note.TeacherName, note.NoteType, note.Note, FormattedDate(note.DateAdded));
            }
            Refresh();
        }

        private string FormattedDate(DateTime date) {
            return date.ToString("dd/MM/yyyy");
        }


        public override void FillTableFiltred(IFiltrable filtred) {
            throw new System.NotImplementedException();
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                throw new NotImplementedException();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void InitializeTable() {
            CellClick += ButtonCellClick;
            SetTableSettings(this);
            AddColumns();
            FillTable();
        }

        public override void LoadData() {
            DataAccess.LoadMyNotes(DataAccess._loggedPerson);
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }

    }
}
