
using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Models;
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


        /// FILTER VARIABLE
        private string SelectedSubject { get; set; }

        public PanelNoteListFiltersUC() {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void PageOnLoadEvent(object sender, EventArgs e) {
            InitializeProfiles();
            InitializeCourses();
            InitializeStudents();
            InitializeYears();
        }

        private void CbCourseSelectEvent(object sender, EventArgs e) {
            ApplyCourseActiveFilter();
        }

        private void CbStudentSelectEvent(object sender, EventArgs e) {
            if (cbStudentName.SelectedItem != null) {
                string selectedStudent = cbStudentName.SelectedItem.ToString();
                string selectedCourse = cbCourse.SelectedItem.ToString();
                bool allStudents = cbStudentName.SelectedItem.ToString().Equals("ALL");
                bool allCourses = cbCourse.SelectedItem.ToString().Equals("ALL");

                if (!allStudents && allCourses) {
                    NoteListModel noteListModel = new NoteListModel();
                    List<NoteListModel> filtredNotes = new List<NoteListModel>();
                    DataAccess.LoadNotes();
                    filtredNotes = DataAccess.notes.Where(s => s.StudentName == selectedStudent).ToList();
                    noteListModel.SetNoteList(filtredNotes);
                    Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
                } else if(allStudents && !allCourses) {
                    NoteListModel noteListModel = new NoteListModel();
                    List<NoteListModel> filtredNotes = new List<NoteListModel>();
                    DataAccess.LoadNotes();
                    filtredNotes = DataAccess.notes.Where(n => n.SubjectName == selectedCourse).ToList();
                    noteListModel.SetNoteList(filtredNotes);
                    Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
                } else if(!allStudents && !allCourses) {
                    NoteListModel noteListModel = new NoteListModel();
                    List<NoteListModel> filtredNotes = new List<NoteListModel>();
                    DataAccess.LoadNotes();
                    filtredNotes = DataAccess.notes.Where(n => n.SubjectName == selectedCourse && n.StudentName == selectedStudent).ToList();
                    noteListModel.SetNoteList(filtredNotes);
                    Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
                } else {
                    NoteListModel noteListModel = new NoteListModel();
                    List<NoteListModel> filtredNotes = new List<NoteListModel>();
                    if (Profile == null) {
                        filtredNotes = DataAccess.notes.ToList();
                    } else {
                        filtredNotes = DataAccess.notes.Where(n => n.ProfileId == Profile.Id).ToList();
                    }
                    noteListModel.SetNoteList(filtredNotes);
                    Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
                }
            }
        }

        private void CbStudentYearSelectEvent(object sender, EventArgs e) {
            int selectedStudentsYear = 0;
            if (cbStudentsYear.SelectedItem != null) {
                int.TryParse(cbStudentsYear.SelectedItem.ToString(), out selectedStudentsYear);
            }
            bool allProfiles = cbProfile.SelectedItem.ToString().Equals("ALL");
            bool allYears = cbStudentsYear.SelectedItem.ToString().Equals("ALL");

            if (allProfiles && allYears) {
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            select per).ToList();
            } else if (!allProfiles && !allYears) {
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            where stu.ProfileId == Profile.Id && stu.InYear == selectedStudentsYear
                            select per).ToList();
            } else if(allProfiles && !allYears){
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            where stu.InYear == selectedStudentsYear
                            select per).ToList();
            } else if(!allProfiles && allYears) {
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            where stu.ProfileId == Profile.Id
                            select per).ToList();
            }

            cbStudentName.Items.Clear();
            cbStudentName.Items.Add("ALL");

            foreach (var student in Students) {
                cbStudentName.Items.Add(student.FullName);
            }

        }

        private void ApplyCourseActiveFilter() {
            SelectedSubject = cbCourse.SelectedItem.ToString();

            if (SelectedSubject == "ALL") {
                NoteListModel noteListModel = new NoteListModel();
                List<NoteListModel> filtredNotes = new List<NoteListModel>();
                DataAccess.LoadNotes();
                if (Profile != null) {
                    filtredNotes = DataAccess.notes.Where(n => n.ProfileId == Profile.Id).ToList();
                } else {
                    filtredNotes = DataAccess.notes.ToList();
                }
                noteListModel.SetNoteList(filtredNotes);
                Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
            } else {
                NoteListModel noteListModel = new NoteListModel();
                List<NoteListModel> filtredNotes = new List<NoteListModel>();
                DataAccess.LoadNotes();
                filtredNotes = DataAccess.notes.Where(n => n.SubjectName == SelectedSubject).ToList();
                noteListModel.SetNoteList(filtredNotes);
                Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
            }
        }

        private void CbYearSelectEvent(object sender, EventArgs e) {
            string selected = cbCoursesYear.SelectedItem.ToString();
            ApplyCourseYearActiveFilter(selected);
        }

        private void ApplyCourseYearActiveFilter(string selectedYear) {
            bool allYears = selectedYear.Equals("ALL");
            NoteListModel noteListModel = new NoteListModel();
            List<NoteListModel> filtredNotes = new List<NoteListModel>();
            DataAccess.LoadNotes();

            if (allYears) {
                if (Profile == null) {
                    InitializeCourses(null, null);
                    filtredNotes = DataAccess.notes.ToList();
                } else {
                    InitializeCourses(Profile, null);
                    filtredNotes = DataAccess.notes.Where(n => n.ProfileId == Profile.Id).ToList();
                }
            } else {
                int year = int.Parse(selectedYear);
                if (Profile == null) {
                    InitializeCourses(null, year);
                    filtredNotes = DataAccess.notes.Where(n => n.CourseYear == year).ToList();
                } else {
                    InitializeCourses(Profile, year);
                    filtredNotes = DataAccess.notes.Where(n => n.ProfileId == Profile.Id && n.CourseYear == year).ToList();
                }
            }

            noteListModel.SetNoteList(filtredNotes);
            Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
        }

        private void CbProfileSelectEvent(object sender, EventArgs e) {
            string selected = cbProfile.SelectedItem.ToString();
            ApplyProfileActiveFilter(selected);
        }


        private void ApplyProfileActiveFilter(string selectedProfile) {
            bool allProfiles = selectedProfile.ToString().Equals("ALL");

            if (allProfiles) {
                // SET MAX COURSE YEAR AND STUDENT YEAR
                // BY MAXIMUM YEAR FROM PROFILES
                DataAccess.LoadProfiles();
                cbCoursesYear.Items.Clear();
                cbCoursesYear.Items.Add("ALL");
                cbStudentsYear.Items.Clear();
                cbStudentsYear.Items.Add("ALL");
                cbStudentsYear.SelectedItem = cbStudentsYear.Items[0];
                cbCoursesYear.SelectedItem = cbCoursesYear.Items[0];
                int maxYear = DataAccess.profiles.Max(x => x.Years);
                for (int i = 1; i <= maxYear; i++) {
                    cbCoursesYear.Items.Add(i);
                    cbStudentsYear.Items.Add(i);
                }

                // GET AND SET ALL COURSES
                DataAccess.LoadCourses();
                cbCourse.Items.Clear();
                cbCourse.Items.Add("ALL");
                cbCourse.SelectedItem = cbCourse.Items[0];
                foreach (var course in DataAccess.courses) {
                    cbCourse.Items.Add(course.Name);
                }

                // GET ALL STUDENTS FROM ALL PROFILES
                DataAccess.LoadStudents();
                cbStudentName.Items.Clear();
                cbStudentName.Items.Add("ALL");
                cbStudentName.SelectedItem = cbStudentName.Items[0];
                foreach (var student in DataAccess.students) {
                    cbStudentName.Items.Add(student.FullName);
                }

                Profile = null;

                // LOAD NOTES TO TABLE
                if (Navigator.Navigator.GetInstance() != null) Navigator.Navigator.GetInstance().RefreshPageNoteList();
            } else {
                Profile = (from pr in DataAccess._dbContext.Profile
                           where pr.Name == selectedProfile
                           select pr).FirstOrDefault();

                NoteListModel noteListModel = new NoteListModel();
                List<NoteListModel> filtredNotes = DataAccess.notes.Where(n => n.ProfileId == Profile.Id).ToList();
                noteListModel.SetNoteList(filtredNotes);
                Navigator.Navigator.GetInstance().RefreshNoteDGVfiltred(noteListModel);
                InitializeYears();
                InitializeCourses(Profile);
                InitializeStudents(Profile);
            }
        }




        private void ApplyFilters() {
            bool allProfiles = cbProfile.SelectedItem.ToString().Equals("ALL");
            bool allYears = cbCoursesYear.SelectedItem.ToString().Equals("ALL");
            int.TryParse(cbCoursesYear.SelectedItem.ToString(), out int year);

            if (allProfiles && allYears) {
                Subjects = (from sub in DataAccess._dbContext.Subject
                            select sub).ToList();
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            select per).ToList();
            } else if (!allProfiles && !allYears) {
                Subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == Profile.Id && sub.YearStudy == year
                            select sub).ToList();
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            where stu.ProfileId == Profile.Id && stu.InYear == year
                            select per).ToList();
            } else {
                Subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == Profile.Id
                            select sub).ToList();
                Students = (from stu in DataAccess._dbContext.Student
                            join per in DataAccess._dbContext.Person on stu.PersonId equals per.Id
                            where stu.ProfileId == Profile.Id
                            select per).ToList();
            }



            cbCourse.Items.Clear();
            foreach (var subject in Subjects) {
                cbCourse.Items.Add(subject.Name);
            }
            cbStudentName.Items.Clear();

            foreach (var student in Students) {
                string name = string.Format("{0}.{1}", student.Id, student.FullName);
                cbStudentName.Items.Add(name);
            }
        }

        private void InitializeYears() {
            cbCoursesYear.Items.Clear();
            cbCoursesYear.Items.Add("ALL");

            cbStudentsYear.Items.Clear();
            cbStudentsYear.Items.Add("ALL");

            cbStudentsYear.SelectedItem = cbStudentsYear.Items[0];
            cbCoursesYear.SelectedItem = cbCoursesYear.Items[0];

            if (Profile != null) {
                for (int i = 1; i <= Profile.Years; i++) {
                    cbStudentsYear.Items.Add(i);
                    cbCoursesYear.Items.Add(i);
                }
            } else {
                DataAccess.LoadProfiles();
                int maxYear = DataAccess.profiles.Max(x => x.Years);
                for (int i = 1; i <= maxYear; i++) {
                    cbCoursesYear.Items.Add(i);
                    cbStudentsYear.Items.Add(i);
                }
            }

        }

        private void InitializeStudents(Profile byProfile = null) {
            cbStudentName.Items.Clear();
            cbStudentName.Items.Add("ALL");
            cbStudentName.SelectedItem = cbStudentName.Items[0];

            if (byProfile == null) {
                DataAccess.LoadStudents();
                foreach (var student in DataAccess.students) {
                    cbStudentName.Items.Add(student.FullName);
                }
            } else {
                DataAccess.LoadStudents(byProfile);
                foreach (var student in DataAccess.students) {
                    cbStudentName.Items.Add(student.FullName);
                }
            }
        }

        private void InitializeProfiles() {
            cbProfile.Items.Clear();
            DataAccess.LoadProfiles();
            cbProfile.Items.Add("ALL");
            cbProfile.SelectedItem = cbProfile.Items[0];
            foreach (var profile in DataAccess.profiles) {
                cbProfile.Items.Add(profile.Name);
            }
        }

        private void InitializeCourses(Profile profile = null, int? studyYear = null) {
            cbCourse.Items.Clear();
            DataAccess.LoadCourses();
            cbCourse.Items.Add("ALL");
            cbCourse.SelectedItem = cbCourse.Items[0];

            if (profile == null) {
                if (studyYear.HasValue) {
                    foreach (var course in DataAccess.courses.Where(c => c.Year == studyYear.Value)) {
                        cbCourse.Items.Add(course.Name);
                    }
                } else {
                    foreach (var course in DataAccess.courses) {
                        cbCourse.Items.Add(course.Name);
                    }
                }
            } else {
                if (studyYear.HasValue) {
                    foreach (var course in DataAccess.courses.Where(c => c.Profile == profile.Name && c.Year == studyYear.Value)) {
                        cbCourse.Items.Add(course.Name);
                    }
                } else {
                    foreach (var course in DataAccess.courses.Where(c => c.Profile == profile.Name)) {
                        cbCourse.Items.Add(course.Name);
                    }
                }
            }
        }
    }
}
