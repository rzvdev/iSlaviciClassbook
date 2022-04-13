
using classbook.Connection;
using iSlavici.Connection.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelNoteListFiltersUC : UserControl
    {
        private Profile Profile { get; set; }
        private List<Subject> Subjects { get; set; } = new List<Subject>();
        private List<Person> Students { get; set; } = new List<Person>();

        public PanelNoteListFiltersUC() {
            InitializeComponent();
            InitializeProfiles();
            InitializeCourses();
            InitializeStudents();
            InitializeYears();
            Dock = DockStyle.Fill;
        }

        private void CbProfileSelectEvent(object sender, EventArgs e) {
            string selected = cbProfile.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            Profile = (from pro in DataAccess._dbContext.Profile
                       where pro.Name == selected
                       select pro).FirstOrDefault();

            if (Profile != null) {
                InitializeYears();
                SetFilters();
            }
        }

        private void SetFilters() {
            Subjects = (from sub in DataAccess._dbContext.Subject
                       where sub.ProfileId == Profile.Id
                       select sub).ToList();
            Students = (from stu in DataAccess._dbContext.Student
                        join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                        where stu.ProfileId == Profile.Id
                        select per).ToList();

            cbCourse.Items.Clear();
            foreach (var subject in Subjects) {
                cbCourse.Items.Add(subject.Name);
            }
            cbStudentName.Items.Clear();

            foreach (var student in Students) {
                cbStudentName.Items.Add(student.FullName);
            }
        }

        private void InitializeYears() {
            cbYear.Items.Clear();
            cbYear.Items.Add("ALL");
            cbYear.SelectedItem = cbYear.Items[0];
            if (Profile != null) {
                for (int i = 1; i <= Profile.Years; i++) {
                    cbYear.Items.Add(i);
                }
            }
        }

        private void InitializeStudents() {
            DataAccess.LoadStudents();
            cbStudentName.Items.Add("ALL");
            cbStudentName.SelectedItem = cbStudentName.Items[0];
            foreach (var student in DataAccess.students) {
                cbStudentName.Items.Add(student.FullName);
            }
        }

        private void InitializeProfiles() {
            DataAccess.LoadProfiles();
            cbProfile.Items.Add("ALL");
            cbProfile.SelectedItem = cbProfile.Items[0];
            foreach (var profile in DataAccess.profiles) {
                cbProfile.Items.Add(profile.Name);
            }
        }

        private void InitializeCourses() {
            DataAccess.LoadCourses();
            cbCourse.Items.Add("ALL");
            cbCourse.SelectedItem = cbCourse.Items[0];
            foreach (var course in DataAccess.courses) {
                cbCourse.Items.Add(course.Name);
            }
        }

    }
}
