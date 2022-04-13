using classbook.Connection;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iSlavici.Controls;

namespace iSlavici.Controls.Nav.Pan
{
    public partial class PanelCreateCourseUC : UserControl
    {
        private int _course_type_selected;
        private int _course_profile_selected;
        private int _course_examination_selected;

        public PanelCreateCourseUC() {
            InitializeComponent();
        }

        private void BtnCreateCourseClickEvent(object sender, EventArgs e) {
            try {
                if (!DataAccess._isConnection) return;
                if (!ValidateCourseFields()) return;

                string courseName = txtboxCourseNameCreateCourse.Text;
                string courseAbvr = txtboxAbvrCreateCourse.Text;
                string courseTeacher = txtboxTeacherNameCreateCourse.Text;
                int courseType = _course_type_selected;
                int courseYear = (int)numBtnYearCreateCourse.Value;
                int courseSemester = (int)numBtnSemesterCreateCourse.Value;
                int courseProfile = _course_profile_selected;
                int courseExamMode = _course_examination_selected;
                int courseCredit = int.Parse(numBtnCreditCreateCourse.Value.ToString());

                Tuple<bool, string> courseExist = DataAccess.CheckIfCourseExist(courseName, courseAbvr, courseProfile);
                if (courseExist.Item1) {
                    MessageBox.Show($"{courseExist.Item2}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Tuple<bool, string> createCourse = DataAccess.CreateCourse(courseName, courseAbvr, courseTeacher, courseType, courseYear, courseSemester, courseProfile, courseExamMode, courseCredit);
                MessageBox.Show($"{createCourse.Item2}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navigator.Navigator.GetInstance().GetPageCourseList().splitterCourseList.courseUC.courseDGV.RefreshData();

            } catch (Exception ex) {
                throw ex;
            }
        }

        private void RadBtnCourseType(object sender, EventArgs e) {
            KryptonRadioButton kr = (KryptonRadioButton)sender;

            if (kr == radbtnExamenCourseType) {
                _course_type_selected = 1;
            } else if (kr == radBtnColocviuCourseType) {
                _course_type_selected = 2;
            }

        }

        private bool ValidateCourseFields() {
            try {
                /// Course name cannot be empty
                if (string.IsNullOrWhiteSpace(txtboxCourseNameCreateCourse.Text)) {
                    MessageBox.Show("The course name cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Abbreviation cannot be empty
                if (string.IsNullOrWhiteSpace(txtboxAbvrCreateCourse.Text)) {
                    MessageBox.Show("The abbreviation cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Teacher name cannot be null
                if (string.IsNullOrWhiteSpace(txtboxTeacherNameCreateCourse.Text)) {
                    MessageBox.Show("The teacher name cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// Teacher NAME CAN CONTAIN ONLY LETTERS AND WHITESPACES
                if (!txtboxTeacherNameCreateCourse.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) {
                    MessageBox.Show("The teacher name can only contain letters and whitespaces!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxTeacherNameCreateCourse.Text = string.Empty;
                    return false;
                }

                if(_course_type_selected == 0) {
                    MessageBox.Show("The type of course of course was not selected!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (_course_examination_selected == 0) {
                    MessageBox.Show("The examination mode of course was not selected!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(numBtnCreditCreateCourse.Value.ToString(), out var credit)) {
                    MessageBox.Show("The credit number cannot have decimals!", "Incorrect field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numBtnCreditCreateCourse.Value = 0;
                    return false;
                }

                /// Must select a profile for this course
                if (_course_profile_selected == 0) {
                    MessageBox.Show("The profile of course was not selected!", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /// MAKE COURSE NAME WITH ALL LETTERS UPERCASE
                txtboxCourseNameCreateCourse.Text = txtboxCourseNameCreateCourse.Text.ToUpper();

                /// MAKE ABVR WITH ALL LETTERS UPERCASE
                txtboxAbvrCreateCourse.Text = txtboxAbvrCreateCourse.Text.ToUpper();

                /// MAKE TEACHER NAME WITH ALL NAMES WITH FIRST LETTER UPPERCASE
                /// EX: lungu razvan to Lungu Razvan
                string[] lastNameSpliter = txtboxTeacherNameCreateCourse.Text.Split(' ');
                foreach (string name in lastNameSpliter) {
                    string withFirstLetterUp = name.First().ToString().ToUpper() + name.Substring(1);
                    txtboxTeacherNameCreateCourse.Text = txtboxTeacherNameCreateCourse.Text.Replace(name, withFirstLetterUp);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void InitializeProfiles() {
            DataAccess.LoadProfiles();
            foreach (var profile in DataAccess.profiles) {
                cbProfilesCreateCourse.Items.Add(profile.Name);
            }
        }


        private void ProfileChangeEvent(object sender, EventArgs e) {
            string selected = cbProfilesCreateCourse.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            _course_profile_selected = DataAccess.profiles.Where(x => x.Name.Equals(selected)).Select(x => x.Id).FirstOrDefault();
        }


        private void TogBtnExamModeChangeEvent(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;

            if (cb == togBtnWrittenCreateCourse) {
                if (togBtnWrittenCreateCourse.Checked) {
                    togBtnOralCreateCourse.Checked = false;
                    togBtnWrittenCreateCourse.BackColor = Color.LightSeaGreen;
                    togBtnWrittenCreateCourse.ForeColor = Color.White;
                    _course_examination_selected = 1;
                } else {
                    togBtnWrittenCreateCourse.Checked = false;
                    togBtnWrittenCreateCourse.BackColor = Color.White;
                    togBtnWrittenCreateCourse.ForeColor = Color.Black;
                    _course_examination_selected = 0;
                }
            } else if (cb == togBtnOralCreateCourse) {
                if (togBtnOralCreateCourse.Checked) {
                    togBtnWrittenCreateCourse.Checked = false;
                    togBtnOralCreateCourse.BackColor = Color.LightSeaGreen;
                    togBtnOralCreateCourse.ForeColor = Color.White;
                    _course_examination_selected = 2;
                } else {
                    togBtnOralCreateCourse.Checked = false;
                    togBtnOralCreateCourse.BackColor = Color.White;
                    togBtnOralCreateCourse.ForeColor = Color.Black;
                    _course_examination_selected = 0;
                }
            }

        }

        private void PanelCreateCourseUC_Load(object sender, EventArgs e) {
             InitializeProfiles();
        }
    }
}
