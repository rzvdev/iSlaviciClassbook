using classbook.Connection;
using iSlavici.Models;
using System;
using System.Windows.Forms;
using System.Linq;
using iSlavici.Connection.Models.db;
using System.Collections.Generic;

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
            throw new NotImplementedException();
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

        public override void FillTableFiltred(IFiltrable filtred) {
            throw new NotImplementedException();
        }

      
    }
}
