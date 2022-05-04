using classbook.Connection;
using iSlavici.Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Models
{
    public class CourseDGV : TableDGV
    {
        private static CourseDGV instance = null;

        private CourseDGV() {
        }

        public static CourseDGV Create() {
            CourseDGV couseDGV = new CourseDGV();
            couseDGV.InitializeTable();
            return couseDGV;
        }

        public static CourseDGV GetInstance() {
            if (instance == null) {
                instance = new CourseDGV();
                instance.InitializeTable();
            }
            return instance;
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
                if (!(sender is CourseDGV)) return;

                if ((e.RowIndex < 0) || (e.ColumnIndex < 0)) return;

                if (e.ColumnIndex == 10) {
                    string id = Rows[e.RowIndex].Cells[0].Value.ToString();
                    string course = Rows[e.RowIndex].Cells[1].Value.ToString();
                    string abrv = Rows[e.RowIndex].Cells[2].Value.ToString();
                    string teacher = Rows[e.RowIndex].Cells[3].Value.ToString();
                    string profile = Rows[e.RowIndex].Cells[4].Value.ToString();
                    string type = Rows[e.RowIndex].Cells[5].Value.ToString();
                    string year = Rows[e.RowIndex].Cells[6].Value.ToString();
                    string semester = Rows[e.RowIndex].Cells[7].Value.ToString();

                    DialogResult deleteDialog = MessageBox.Show($"Do you really want to delete this course?\n\nID: {id}\nCourse Name: {course}\nName: {abrv}\nType: {type}\nTeacher Name: {teacher}\nYear: {year}\nSemester: {semester}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (deleteDialog == DialogResult.Yes) {
                        Tuple<bool, string> isDeleted = DataAccess.DeleteCourse(int.Parse(id));
                        if (isDeleted.Item1) {
                            MessageBox.Show(isDeleted.Item2, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            return;
                        }
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void FillTable() {
            LoadData();
            foreach (var course in DataAccess.courses) {
                Rows.Add(course.ID, course.Name, course.Abrv, course.Teacher, course.Profile, course.Type, course.ExaminationMode, course.Credit, course.Year, course.Semester);
            }
            Refresh();
        }

        public override void LoadData() {
            DataAccess.LoadCourses();
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }


        public override void AddColumns() {
            try {
                DataGridViewColumn deleteBtnColumn = new DataGridViewColumn {
                    Width = 40,
                    HeaderText = "DEL.",
                    CellTemplate = new DataGridViewButtonCell(),
                    Tag = "btnDel"
                };

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
                Columns.Insert(10, deleteBtnColumn);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void FillTableFiltred(IFiltrable filtred) {
            throw new NotImplementedException();
        }
    }
}
