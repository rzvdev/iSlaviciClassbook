namespace iSlavici.Components.Nav.Pan
{
    partial class PanelMyNotesListFiltersUC
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
            this.cbStudentsYear = new System.Windows.Forms.ComboBox();
            this.lblYearStudentsFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCoursesYear = new System.Windows.Forms.ComboBox();
            this.cbStudentName = new System.Windows.Forms.ComboBox();
            this.lblStudentNameFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblYearCoursesFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourseFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblSearchProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // cbStudentsYear
            // 
            this.cbStudentsYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStudentsYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsYear.Enabled = false;
            this.cbStudentsYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudentsYear.FormattingEnabled = true;
            this.cbStudentsYear.Location = new System.Drawing.Point(470, 55);
            this.cbStudentsYear.Name = "cbStudentsYear";
            this.cbStudentsYear.Size = new System.Drawing.Size(84, 21);
            this.cbStudentsYear.TabIndex = 29;
            // 
            // lblYearStudentsFilter
            // 
            this.lblYearStudentsFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearStudentsFilter.Location = new System.Drawing.Point(472, 32);
            this.lblYearStudentsFilter.Name = "lblYearStudentsFilter";
            this.lblYearStudentsFilter.Size = new System.Drawing.Size(80, 20);
            this.lblYearStudentsFilter.TabIndex = 28;
            this.lblYearStudentsFilter.Values.Text = "Student Year";
            // 
            // cbCoursesYear
            // 
            this.cbCoursesYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCoursesYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursesYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCoursesYear.FormattingEnabled = true;
            this.cbCoursesYear.Location = new System.Drawing.Point(190, 55);
            this.cbCoursesYear.Name = "cbCoursesYear";
            this.cbCoursesYear.Size = new System.Drawing.Size(84, 21);
            this.cbCoursesYear.TabIndex = 26;
            this.cbCoursesYear.SelectionChangeCommitted += new System.EventHandler(this.FilterClickEvent);
            // 
            // cbStudentName
            // 
            this.cbStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentName.Enabled = false;
            this.cbStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(562, 55);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(128, 21);
            this.cbStudentName.TabIndex = 25;
            // 
            // lblStudentNameFilter
            // 
            this.lblStudentNameFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNameFilter.Location = new System.Drawing.Point(582, 32);
            this.lblStudentNameFilter.Name = "lblStudentNameFilter";
            this.lblStudentNameFilter.Size = new System.Drawing.Size(89, 20);
            this.lblStudentNameFilter.TabIndex = 24;
            this.lblStudentNameFilter.Values.Text = "Student Name";
            // 
            // lblYearCoursesFilter
            // 
            this.lblYearCoursesFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearCoursesFilter.Location = new System.Drawing.Point(193, 32);
            this.lblYearCoursesFilter.Name = "lblYearCoursesFilter";
            this.lblYearCoursesFilter.Size = new System.Drawing.Size(81, 20);
            this.lblYearCoursesFilter.TabIndex = 23;
            this.lblYearCoursesFilter.Values.Text = "Courses Year";
            // 
            // cbCourse
            // 
            this.cbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(282, 55);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(181, 21);
            this.cbCourse.TabIndex = 22;
            this.cbCourse.SelectionChangeCommitted += new System.EventHandler(this.FilterClickEvent);
            // 
            // lblCourseFilter
            // 
            this.lblCourseFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseFilter.Location = new System.Drawing.Point(350, 32);
            this.lblCourseFilter.Name = "lblCourseFilter";
            this.lblCourseFilter.Size = new System.Drawing.Size(54, 20);
            this.lblCourseFilter.TabIndex = 21;
            this.lblCourseFilter.Values.Text = "Courses";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.Enabled = false;
            this.cbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(63, 55);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 20;
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProfile.Location = new System.Drawing.Point(98, 32);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(51, 20);
            this.lblSearchProfile.TabIndex = 19;
            this.lblSearchProfile.Values.Text = "Profiles";
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(24, 25);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(700, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(35, 0);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(99, 26);
            this.lblAccountSectionCreate.TabIndex = 18;
            this.lblAccountSectionCreate.Values.Text = "Filtre notes by:";
            // 
            // PanelMyNotesListFiltersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbStudentsYear);
            this.Controls.Add(this.lblYearStudentsFilter);
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
            this.Name = "PanelMyNotesListFiltersUC";
            this.Size = new System.Drawing.Size(758, 77);
            this.Load += new System.EventHandler(this.PageOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudentsYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearStudentsFilter;
        private System.Windows.Forms.ComboBox cbCoursesYear;
        private System.Windows.Forms.ComboBox cbStudentName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentNameFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearCoursesFilter;
        private System.Windows.Forms.ComboBox cbCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseFilter;
        private System.Windows.Forms.ComboBox cbProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearchProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionCreate;
    }
}
