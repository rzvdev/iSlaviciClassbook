using classbook.Connection;
using iSlavici.Controls.Navigator;
using iSlavici.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Components.Nav.Pan
{
    public partial class PanelMyNotesListFiltersUC : UserControl
    {
        public PanelMyNotesListFiltersUC() {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void AdvancedFilter() {
            bool allCourseYear = cbCoursesYear.SelectedItem.ToString().Equals("ALL");
            bool allCourses = cbCourse.SelectedItem.ToString().Equals("ALL");

            DataAccess.LoadStudentNotes(DataAccess._loggedPerson.CNP);

            if (!allCourseYear) {
                int year = int.Parse(cbCoursesYear.SelectedItem.ToString());
                DataAccess.studentNotes = DataAccess.studentNotes.Where(n => n.InYear == year).ToList();
            }

            if (!allCourses) {
                string course = cbCourse.SelectedItem.ToString();
                DataAccess.studentNotes = DataAccess.studentNotes.Where(n => n.SubjectName == course).ToList();
            }

            NoteOneStudentListModel notmd = new NoteOneStudentListModel();
            notmd.SetOneStudentNoteList(DataAccess.studentNotes);

            Navigator.GetInstance().RefreshMyNotesDGVfilted(notmd);
        }

        private void FilterClickEvent(object sender, EventArgs e) {
            AdvancedFilter();
        }

        private void PageOnLoad(object sender, EventArgs e) {
            InitializeProfile();
            InitializeYears();
            InitializeCourses();
        }

        private void InitializeCourses() {
            DataAccess.LoadCourses();
            DataAccess.courses = DataAccess.courses.Where(c => c.Profile == DataAccess._loggedProfile.Name &&
                                                               c.Year <= DataAccess._loggedStudent.InYear)
                                                   .OrderByDescending(c => c.Year)
                                                   .ToList();
            cbCourse.Items.Clear();
            cbCourse.Items.Add("ALL");
            cbCourse.SelectedItem = cbCourse.Items[0];
            foreach (var course in DataAccess.courses) {
                cbCourse.Items.Add(course.Name);
            }
        }

        private void InitializeYears() {
            cbCoursesYear.Items.Clear();
            cbStudentsYear.Items.Clear();

            cbCoursesYear.Items.Add("ALL");
            cbCoursesYear.SelectedItem = cbCoursesYear.Items[0];

            for (int i = 1; i <= DataAccess._loggedProfile.Years; i++) {
                cbStudentsYear.Items.Add(i);
                cbCoursesYear.Items.Add(i);
            }
        }

        private void InitializeProfile() {
            cbProfile.Items.Clear();
            cbProfile.Items.Add(DataAccess._loggedProfile.Name);
            cbProfile.SelectedItem = cbProfile.Items[0];
        }
    }
}
