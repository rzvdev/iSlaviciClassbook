using classbook.Connection;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iSlavici.Controls.Dgv
{
    public class MyCoursesDGV : TableDGV
    {
        private static MyCoursesDGV instance = null;

        private MyCoursesDGV() {
        }

        public static MyCoursesDGV Create() {
            MyCoursesDGV courseDGV = new MyCoursesDGV();
            courseDGV.InitializeTable();
            return courseDGV;
        }

        public static MyCoursesDGV GetInstance() {
            if (instance == null) {
                instance = new MyCoursesDGV();
                instance.InitializeTable();
            }
            return instance;
        }


        public override void AddColumns() {
            DataGridViewColumn idColumn = new DataGridViewColumn {
                Width = 60,
                HeaderText = "ID",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn nameColumn = new DataGridViewColumn {
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

            DataGridViewColumn profileColumn = new DataGridViewColumn {
                Width = 200,
                HeaderText = "PROFILE",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn courseTypeColumn = new DataGridViewColumn {
                Width = 250,
                HeaderText = "TYPE",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn examinationColumn = new DataGridViewColumn {
                Width = 150,
                HeaderText = "EXAMINATION",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn creditColumn = new DataGridViewColumn {
                Width = 80,
                HeaderText = "CREDIT",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn yearColumn = new DataGridViewColumn {
                Width = 80,
                HeaderText = "YEAR",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            DataGridViewColumn semesterColumn = new DataGridViewColumn {
                Width = 80,
                HeaderText = "SEMESTER",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            Columns.Insert(0, idColumn);
            Columns.Insert(1, nameColumn);
            Columns.Insert(2, abvrColumn);
            Columns.Insert(3, teacherColumn);
            Columns.Insert(4, profileColumn);
            Columns.Insert(5, courseTypeColumn);
            Columns.Insert(6, examinationColumn);
            Columns.Insert(7, creditColumn);
            Columns.Insert(8, yearColumn);
            Columns.Insert(9, semesterColumn);
        }

        public override void FillTable() {
            LoadData();
            foreach (var course in DataAccess.courses) {
                Rows.Add(course.ID, course.Name, course.Abrv, course.Teacher, course.Profile, course.Type, course.ExaminationMode, course.Credit, course.Year, course.Semester);
            }
            Refresh();
        }

        public override void FillTableFiltred(IFiltrable filtred) {
            Rows.Clear();
            List<CourseListModel> courses = filtred.GetCourseList();
            foreach (var course in courses) {
                Rows.Add(course.ID, course.Name, course.Abrv, course.Teacher, course.Profile, course.Type, course.ExaminationMode, course.Credit, course.Year, course.Semester);
            }
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
            DataAccess.LoadCoursesByStudent(DataAccess._loggedStudent);
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }

     
    }
}
