using classbook.Connection;
using ComponentFactory.Krypton.Toolkit;
using iSlavici.Connection.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelAddNoteUC : UserControl
    {
        private Person _person;
        private Account _account;
        private Profile _profile;
        private Student _student;
        private Subject _subject;
        private NoteType _noteType;
        private int _selected_year = 0;
        private int _selected_semester = 0;
        private List<Student> students = new List<Student>();
        private List<Subject> subjects = new List<Subject>();
        private List<NoteType> notetypes = new List<NoteType>();

        public PanelAddNoteUC() {
            InitializeComponent();
        }

        private void PanelAddNoteUC_Load(object sender, EventArgs e) {
            InitializeProfiles();
            InitializeNoteTypes();
        }

        private void CbStudentNameSelectedEvent(object sender, EventArgs e) {
            string selectedPersonName = cbNameAddNote.SelectedItem.ToString().Split('.')[1].ToString();
            string selectedIdName = cbNameAddNote.SelectedItem.ToString().Split('.')[0].ToString();

            _person = (from per in DataAccess._dbContext.Person
                             where per.FullName == selectedPersonName
                             && per.Id == int.Parse(selectedIdName)
                             select per).FirstOrDefault();

            _student = (from stu in DataAccess._dbContext.Student
                               where stu.PersonId == _person.Id
                               select stu).FirstOrDefault();

            _profile = (from pro in DataAccess._dbContext.Profile
                               where pro.Id == _student.ProfileId
                               select pro).FirstOrDefault();

            SetStudentInfo(_person, _profile, _student);
        }

        public void ResetAllFields() {
            lblCourseAbvr.Text = string.Empty;
            lblCourseProfileValue.Text = string.Empty;
            lblCourseTeacherValue.Text = string.Empty;
            cbCourseAddNote.Text = string.Empty;

            lblYearValueAddNote.Text = string.Empty;
            lblProfileValueAddNote.Text = string.Empty;
            lblYearValueAddNote.Text = string.Empty;
            lblCnpValueAddNote.Text = string.Empty;
        }

        private void CbCourseSelectedEvent(object sender,EventArgs e) {
            string selectedCourse = cbCourseAddNote.SelectedItem.ToString();

            _subject = (from sub in DataAccess._dbContext.Subject
                        where sub.Name == selectedCourse
                        select sub).FirstOrDefault();

            SetCourseInfo(_subject);
        }

        private void SetCourseInfo(Subject subject) {
            lblCourseAbvr.Text = subject.Abvr;
            lblCourseProfileValue.Text = subject.ProfileName;
            lblCourseTeacherValue.Text = subject.TeacherName;
        }

        private void SetStudentInfo(Person person, Profile profile, Student student) {

            lblCnpValueAddNote.Text = person.CNP;
            lblYearValueAddNote.Text = student.InYear.ToString();
            lblProfileValueAddNote.Text = profile.Name;
        }

        private void InitializeNoteTypes() {
            notetypes = DataAccess._dbContext.NoteType.ToList();

            foreach (var type in notetypes) {
                cbNoteTypeAddNote.Items.Add(type.TypeName);
            }
        }

        private void SetFilters() {
            if (_profile == null) {
                students = (from stu in DataAccess._dbContext.Student
                            select stu).ToList();
                subjects = (from sub in DataAccess._dbContext.Subject
                            select sub).ToList();
            } else if (_profile != null && _selected_year != 0 && _selected_semester == 0) {
                students = (from stu in DataAccess._dbContext.Student
                            where stu.ProfileId == _profile.Id && stu.InYear == _selected_year
                            select stu).ToList();
                subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == _profile.Id && sub.YearStudy == _selected_year
                            select sub).ToList();
            } else if (_selected_year == 0 && _selected_semester == 0) {
                students = (from stu in DataAccess._dbContext.Student
                            where stu.ProfileId == _profile.Id
                            select stu).ToList();
                subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == _profile.Id
                            select sub).ToList();
            } else if (_selected_semester != 0) {
                students = (from stu in DataAccess._dbContext.Student
                            where stu.ProfileId == _profile.Id && stu.InYear == _selected_year
                            select stu).ToList();
                subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == _profile.Id && sub.YearStudy == _selected_year && sub.SemesterStudy == _selected_semester
                            select sub).ToList();
            }
            LoadStudentsAndCoursesComboboxes();
        }

        private void LoadStudentsAndCoursesComboboxes() {
            cbNameAddNote.Items.Clear();
            cbCourseAddNote.Items.Clear();

            foreach (var student in students) {
                Person person = DataAccess._dbContext.Person.Where(x => x.Id == student.PersonId).FirstOrDefault();
                string idAndName = string.Format("{0}.{1}", person.Id, person.FullName);
                cbNameAddNote.Items.Add(idAndName);
            }
            foreach (var subject in subjects) {
                string subjectName = subject.Name;
                cbCourseAddNote.Items.Add(subjectName);
            }
        }

        private void CbYearAndSemesterSelectEvent(object sender, EventArgs e) {
            KryptonComboBox cb = (KryptonComboBox)sender;

            if (cb == cbYearFilter) {
                _selected_year = int.Parse(cb.SelectedItem.ToString());
                cbNameAddNote.Items.Clear();
                cbNameAddNote.Text = string.Empty;
                cbSemesterFilter.Enabled = true;
                ResetAllFields();
                SetFilters();
            } else if (cb == cbSemesterFilter) {
                _selected_semester = int.Parse(cb.SelectedItem.ToString());
                cbCourseAddNote.Items.Clear();
                cbCourseAddNote.Text = string.Empty;
                lblCourseAbvr.Text = string.Empty;
                lblCourseProfileValue.Text = string.Empty;
                lblCourseTeacherValue.Text = string.Empty;
                SetFilters();
            }
        }

        private void CbProfileSelectEvent(object sender, EventArgs e) {
            string selected = cbProfileFilter.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected)) return;
            cbNameAddNote.Items.Clear();
            cbNameAddNote.Text = string.Empty;
            ResetAllFields();

            _profile = (from pro in DataAccess._dbContext.Profile
                        where pro.Name == selected
                        select pro).FirstOrDefault();

            if (_profile != null) {
                InitializeYearAndSemesterFilters();
                SetFilters();
            }
        }

        private void InitializeYearAndSemesterFilters() {
            cbYearFilter.Enabled = true;
            cbYearFilter.Items.Clear();
            cbSemesterFilter.Items.Clear();


            int profileYears = _profile.Years;

            for (int i = 1; i <= profileYears; i++) {
                cbYearFilter.Items.Add(i.ToString());
            }

            cbSemesterFilter.Items.Add(1);
            cbSemesterFilter.Items.Add(2);
        }

        private void InitializeProfiles() {
            DataAccess.LoadProfiles();
            foreach (var profile in DataAccess.profiles) {
                cbProfileFilter.Items.Add(profile.Name);
            }
        }

        private void BtnAddClickEvent(object sender, EventArgs e) {
            try {
                if (!ValidateFields()) return;

                if (DataAccess.AddNote(_person, _subject, _noteType, int.Parse(numBtnAddNoteValue.Value.ToString()))) {
                    MessageBox.Show("Note was added with succes!", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navigator.Navigator.GetInstance().RefreshPageNoteList();
                    return;
                }

            } catch (Exception ex) {
                throw ex;
            }
        }

        private bool ValidateFields() {
            try {
                if(cbNameAddNote.SelectedItem == null) {
                    MessageBox.Show("Please select the student", "Invalid fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
                if (cbCourseAddNote.SelectedItem == null) {
                    MessageBox.Show("Please select the course", "Invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (cbNoteTypeAddNote.SelectedItem == null) {
                    MessageBox.Show("Please select the type of the note", "Invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                string studentName = cbNameAddNote.SelectedItem.ToString().Split('.')[1]; ;
                string subjectName = cbCourseAddNote.SelectedItem.ToString();
                string noteType = cbNoteTypeAddNote.SelectedItem.ToString();

                _person = (from p in DataAccess._dbContext.Person
                           where p.FullName == studentName
                           select p).FirstOrDefault();

                _account = (from ac in DataAccess._dbContext.Account
                            where ac.PersonId == _person.Id
                            select ac).FirstOrDefault();

                _student = (from stu in DataAccess._dbContext.Student
                            where stu.PersonId == _person.Id
                            select stu).FirstOrDefault();

                _profile = (from pr in DataAccess._dbContext.Profile
                            where pr.Id == _student.ProfileId
                            select pr).FirstOrDefault();

                _subject = (from sub in DataAccess._dbContext.Subject
                            where sub.Name == subjectName
                            select sub).FirstOrDefault();

                _noteType = (from nt in DataAccess._dbContext.NoteType
                             where nt.TypeName == noteType
                             select nt).FirstOrDefault();

                lblCnpValueAddNote.Text = _person.CNP;
                lblProfileValueAddNote.Text = _profile.Name;
                lblYearValueAddNote.Text = _student.InYear.ToString();

                if (_person == null || _account == null || _profile == null || _student == null || subjectName == null || noteType == null) return false;

            } catch (Exception ex) {
                throw ex;
            }
            return true;
        }


    }
}
