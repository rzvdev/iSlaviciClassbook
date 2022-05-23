using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Controls.Navigator;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Components.Nav.Pan
{
    public partial class PanelCourseListFiltersUC : UserControl
    {
        private ComboBox cbCoursesYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearCoursesFilter;
        private ComboBox cbProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearchProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionCreate;

        private Profile SelectedProfile { get; set; }
        private SubjectType SelectedType { get; set; }
        private int? AllYears { get; set; }


        private void InitializeComponent() {
            this.cbCoursesYear = new System.Windows.Forms.ComboBox();
            this.lblYearCoursesFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblSearchProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // cbCoursesYear
            // 
            this.cbCoursesYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCoursesYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursesYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCoursesYear.FormattingEnabled = true;
            this.cbCoursesYear.Location = new System.Drawing.Point(401, 54);
            this.cbCoursesYear.Name = "cbCoursesYear";
            this.cbCoursesYear.Size = new System.Drawing.Size(84, 21);
            this.cbCoursesYear.TabIndex = 26;
            this.cbCoursesYear.SelectedIndexChanged += new System.EventHandler(this.CourseYearActiveFilter);
            // 
            // lblYearCoursesFilter
            // 
            this.lblYearCoursesFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearCoursesFilter.Location = new System.Drawing.Point(404, 31);
            this.lblYearCoursesFilter.Name = "lblYearCoursesFilter";
            this.lblYearCoursesFilter.Size = new System.Drawing.Size(76, 20);
            this.lblYearCoursesFilter.TabIndex = 23;
            this.lblYearCoursesFilter.Values.Text = "Course Year";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(274, 54);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 20;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.ProfileActiveFilter);
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProfile.Location = new System.Drawing.Point(309, 31);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(45, 20);
            this.lblSearchProfile.TabIndex = 19;
            this.lblSearchProfile.Values.Text = "Profile";
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(24, 24);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(700, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(35, -1);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(110, 26);
            this.lblAccountSectionCreate.TabIndex = 18;
            this.lblAccountSectionCreate.Values.Text = "Filtre courses by:";
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(491, 54);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(84, 21);
            this.cbType.TabIndex = 32;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.TypeActiveFilter);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.Location = new System.Drawing.Point(514, 31);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 20);
            this.lblType.TabIndex = 31;
            this.lblType.Values.Text = "Type";
            // 
            // PanelCourseListFiltersUC
            // 
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbCoursesYear);
            this.Controls.Add(this.lblYearCoursesFilter);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.borderAccountSectionCreate);
            this.Controls.Add(this.lblAccountSectionCreate);
            this.Name = "PanelCourseListFiltersUC";
            this.Size = new System.Drawing.Size(758, 75);
            this.Load += new System.EventHandler(this.PanelCourseListFiltersUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public PanelCourseListFiltersUC() {
            InitializeComponent();
            Dock = DockStyle.Fill;
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

        private void InitializeCourseType() {
            cbType.Items.Clear();
            cbType.Items.Add("ALL");
            cbType.SelectedItem = cbType.Items[0];

            List<string> types = (from subty in DataAccess._dbContext.SubjectType
                                  select subty.TypeName).ToList();

            cbType.Items.AddRange(types.ToArray());

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


        private void AdvancedFilter(Profile profile,int? courseYear, SubjectType type) {
            List<Subject> subjects = (from sub in DataAccess._dbContext.Subject
                                      select sub).ToList();


            if(profile != null) {
                subjects = subjects.Where(s => s.ProfileId == profile.Id).ToList();
            }

            if(courseYear != null && courseYear != 0) {
                subjects = subjects.Where(s => s.YearStudy == courseYear.Value).ToList();
            }

            if(type != null) {
                subjects = subjects.Where(s => s.SubjectTypeId == type.Id).ToList();
            }



            List<CourseListModel> courseListModels = new List<CourseListModel>();
            CourseListModel crs = new CourseListModel();

            foreach(var sub in subjects) {
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
            Navigator.GetInstance().RefreshCourseDGVfiltred(crs);
        }

        private void PanelCourseListFiltersUC_Load(object sender, System.EventArgs e) {
            InitializeProfiles();
            InitializeCourseYear();
            InitializeCourseType();
        }
    }
}
