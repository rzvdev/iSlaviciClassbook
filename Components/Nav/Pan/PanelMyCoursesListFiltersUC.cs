using classbook.Connection;
using iSlavici.Connection.Models.db;
using System.Windows.Forms;
using System.Linq;
using iSlavici.Controls.Navigator;
using System;
using System.Collections.Generic;
using iSlavici.Models;

namespace iSlavici.Components.Nav.Pan
{
    public partial class PanelMyCoursesListFiltersUC : UserControl
    {
        private Profile SelectedProfile { get; set; } = DataAccess._loggedProfile;
        private SubjectType SelectedType { get; set; }
        private int? AllYears { get; set; }

        public PanelMyCoursesListFiltersUC() {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void InitializeProfiles() {
            cbProfile.Items.Clear();
            cbProfile.Items.Add(SelectedProfile.Name);
            cbProfile.SelectedItem = cbProfile.Items[0];
        }

        private void InitializeCourseYear(Profile byProfile = null) {
            cbCoursesYear.Items.Clear();
            cbCoursesYear.Items.Add("ALL");
            cbCoursesYear.SelectedItem = cbCoursesYear.Items[0];

            if (byProfile == null) {
                int possibilityMaxYear = (from pro in DataAccess._dbContext.Profile
                                          select pro).Max(x => x.Years);
                for (int i = 1; i <= possibilityMaxYear; i++) {
                    cbCoursesYear.Items.Add(i.ToString());
                }
            } else {
                for (int i = 1; i <= byProfile.Years; i++) {
                    cbCoursesYear.Items.Add(i.ToString());
                }
            }
        }
        private void ProfileActiveFilter(object sender, EventArgs e) {
            bool allProfiles = cbProfile.SelectedItem.ToString().Equals("ALL");

            if (allProfiles) {
                SelectedProfile = null;
            } else {
                SelectedProfile = (from pro in DataAccess._dbContext.Profile
                                   where pro.Name == cbProfile.SelectedItem.ToString()
                                   select pro).FirstOrDefault();
            }

            InitializeCourseYear(SelectedProfile);
            AdvancedFilter(SelectedProfile, AllYears.HasValue ? AllYears.Value : 0, SelectedType);
        }

        private void CourseYearActiveFilter(object sender, EventArgs e) {
            bool allYears = cbCoursesYear.SelectedItem.ToString().Equals("ALL");

            if (allYears) {
                AllYears = null;
            } else {
                AllYears = int.Parse(cbCoursesYear.SelectedItem.ToString());
            }

            AdvancedFilter(SelectedProfile, AllYears.HasValue ? AllYears.Value : 0, SelectedType);
        }

        private void TypeActiveFilter(object sender, EventArgs e) {
            bool allType = cbType.SelectedItem.ToString().Equals("ALL");

            if (allType) {
                SelectedType = null;
            } else {
                SelectedType = (from ty in DataAccess._dbContext.SubjectType
                                where ty.TypeName == cbType.SelectedItem.ToString()
                                select ty).FirstOrDefault();
            }

            AdvancedFilter(SelectedProfile, AllYears.HasValue ? AllYears.Value : 0, SelectedType);
        }


        private void AdvancedFilter(Profile profile, int? courseYear, SubjectType type) {
            List<Subject> subjects = (from sub in DataAccess._dbContext.Subject
                                      where sub.YearStudy <= DataAccess._loggedStudent.InYear
                                      && sub.ProfileId == DataAccess._loggedProfile.Id
                                      select sub).ToList();

            if (profile != null) {
                subjects = subjects.Where(s => s.ProfileId == profile.Id).ToList();
            }

            if (courseYear != null && courseYear != 0) {
                subjects = subjects.Where(s => s.YearStudy == courseYear.Value).ToList();
            }

            if (type != null) {
                subjects = subjects.Where(s => s.SubjectTypeId == type.Id).ToList();
            }



            List<CourseListModel> courseListModels = new List<CourseListModel>();
            CourseListModel crs = new CourseListModel();

            foreach (var sub in subjects) {
                courseListModels.Add(new CourseListModel {
                    ID = sub.Id,
                    Name = sub.Name,
                    Teacher = sub.TeacherName,
                    Abrv = sub.Abvr,
                    Credit = sub.Credit,
                    ExaminationMode = sub.CourseExaminationName,
                    Semester = sub.SemesterStudy,
                    Profile = sub.ProfileName,
                    Type = sub.SubjectTypeName,
                    Year = sub.YearStudy
                });
            }

            crs.SetCourseList(courseListModels);
            Navigator.GetInstance().RefreshMyCourseDGVfiltred(crs);
        }

        private void InitializeCourseType() {
            cbType.Items.Clear();
            cbType.Items.Add("ALL");
            cbType.SelectedItem = cbType.Items[0];

            List<string> types = (from subty in DataAccess._dbContext.SubjectType
                                  select subty.TypeName).ToList();

            cbType.Items.AddRange(types.ToArray());

        }

        private void PanelCourseListFiltersUC_Load(object sender, System.EventArgs e) {
            InitializeProfiles();
            InitializeCourseYear();
            InitializeCourseType();
            AdvancedFilter(SelectedProfile, AllYears.HasValue ? AllYears.Value : 0, SelectedType);
        }
    }
}
