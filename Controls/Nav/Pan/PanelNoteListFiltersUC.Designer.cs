namespace iSlavici.Controls.Nav.Pan
{
    partial class PanelNoteListFiltersUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSearchProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblCourseFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lblYearCoursesFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStudentName = new System.Windows.Forms.ComboBox();
            this.lblStudentNameFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCoursesYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.cbStudentsYear = new System.Windows.Forms.ComboBox();
            this.lblYearStudentsFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(25, 23);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(700, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(36, -2);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(99, 26);
            this.lblAccountSectionCreate.TabIndex = 2;
            this.lblAccountSectionCreate.Values.Text = "Filtre notes by:";
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProfile.Location = new System.Drawing.Point(59, 30);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(51, 20);
            this.lblSearchProfile.TabIndex = 3;
            this.lblSearchProfile.Values.Text = "Profiles";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(24, 53);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 4;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.CbProfileSelectEvent);
            // 
            // lblCourseFilter
            // 
            this.lblCourseFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseFilter.Location = new System.Drawing.Point(311, 30);
            this.lblCourseFilter.Name = "lblCourseFilter";
            this.lblCourseFilter.Size = new System.Drawing.Size(54, 20);
            this.lblCourseFilter.TabIndex = 5;
            this.lblCourseFilter.Values.Text = "Courses";
            // 
            // cbCourse
            // 
            this.cbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(243, 53);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(181, 21);
            this.cbCourse.TabIndex = 6;
            // 
            // lblYearCoursesFilter
            // 
            this.lblYearCoursesFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearCoursesFilter.Location = new System.Drawing.Point(154, 30);
            this.lblYearCoursesFilter.Name = "lblYearCoursesFilter";
            this.lblYearCoursesFilter.Size = new System.Drawing.Size(81, 20);
            this.lblYearCoursesFilter.TabIndex = 7;
            this.lblYearCoursesFilter.Values.Text = "Courses Year";
            // 
            // cbStudentName
            // 
            this.cbStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(523, 53);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(128, 21);
            this.cbStudentName.TabIndex = 10;
            // 
            // lblStudentNameFilter
            // 
            this.lblStudentNameFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNameFilter.Location = new System.Drawing.Point(543, 30);
            this.lblStudentNameFilter.Name = "lblStudentNameFilter";
            this.lblStudentNameFilter.Size = new System.Drawing.Size(89, 20);
            this.lblStudentNameFilter.TabIndex = 9;
            this.lblStudentNameFilter.Values.Text = "Student Name";
            // 
            // cbCoursesYear
            // 
            this.cbCoursesYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCoursesYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursesYear.FormattingEnabled = true;
            this.cbCoursesYear.Location = new System.Drawing.Point(151, 53);
            this.cbCoursesYear.Name = "cbCoursesYear";
            this.cbCoursesYear.Size = new System.Drawing.Size(84, 21);
            this.cbCoursesYear.TabIndex = 12;
            this.cbCoursesYear.SelectedIndexChanged += new System.EventHandler(this.CbYearSelectEvent);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(661, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "1C24D41BC8A14D00F08EFA78DCFE5574";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "60C05A4FACBC4A9D4480CDBED9C37121";
            // 
            // cbStudentsYear
            // 
            this.cbStudentsYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStudentsYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsYear.FormattingEnabled = true;
            this.cbStudentsYear.Location = new System.Drawing.Point(431, 53);
            this.cbStudentsYear.Name = "cbStudentsYear";
            this.cbStudentsYear.Size = new System.Drawing.Size(84, 21);
            this.cbStudentsYear.TabIndex = 16;
            // 
            // lblYearStudentsFilter
            // 
            this.lblYearStudentsFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearStudentsFilter.Location = new System.Drawing.Point(433, 30);
            this.lblYearStudentsFilter.Name = "lblYearStudentsFilter";
            this.lblYearStudentsFilter.Size = new System.Drawing.Size(86, 20);
            this.lblYearStudentsFilter.TabIndex = 15;
            this.lblYearStudentsFilter.Values.Text = "Students Year";
            // 
            // PanelNoteListFiltersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbStudentsYear);
            this.Controls.Add(this.lblYearStudentsFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCoursesYear);
            this.Controls.Add(this.cbStudentName);
            this.Controls.Add(this.lblStudentNameFilter);
            this.Controls.Add(this.lblYearCoursesFilter);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lblCourseFilter);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.borderAccountSectionCreate);
            this.Controls.Add(this.lblAccountSectionCreate);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Name = "PanelNoteListFiltersUC";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Size = new System.Drawing.Size(758, 77);
            this.Enter += new System.EventHandler(this.PageOnLoadEvent);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearchProfile;
        private System.Windows.Forms.ComboBox cbProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseFilter;
        private System.Windows.Forms.ComboBox cbCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearCoursesFilter;
        private System.Windows.Forms.ComboBox cbStudentName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentNameFilter;
        private System.Windows.Forms.ComboBox cbCoursesYear;
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.ComboBox cbStudentsYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearStudentsFilter;
    }
}
