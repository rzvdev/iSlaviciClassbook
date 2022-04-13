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
            this.lblYearFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStudentName = new System.Windows.Forms.ComboBox();
            this.lblStudentNameFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(60, 23);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(440, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(72, -2);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(102, 26);
            this.lblAccountSectionCreate.TabIndex = 2;
            this.lblAccountSectionCreate.Values.Text = "Search note by:";
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSearchProfile.Location = new System.Drawing.Point(95, 30);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(45, 20);
            this.lblSearchProfile.TabIndex = 3;
            this.lblSearchProfile.Values.Text = "Profile";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(60, 53);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 4;
            this.cbProfile.SelectedIndexChanged += CbProfileSelectEvent;
            // 
            // lblCourseFilter
            // 
            this.lblCourseFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCourseFilter.Location = new System.Drawing.Point(223, 30);
            this.lblCourseFilter.Name = "lblCourseFilter";
            this.lblCourseFilter.Size = new System.Drawing.Size(48, 20);
            this.lblCourseFilter.TabIndex = 5;
            this.lblCourseFilter.Values.Text = "Course";
            // 
            // cbCourse
            // 
            this.cbCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(187, 53);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 21);
            this.cbCourse.TabIndex = 6;
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblYearFilter.Location = new System.Drawing.Point(449, 30);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(34, 20);
            this.lblYearFilter.TabIndex = 7;
            this.lblYearFilter.Values.Text = "Year";
            // 
            // cbStudentName
            // 
            this.cbStudentName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(315, 53);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(121, 21);
            this.cbStudentName.TabIndex = 10;
            // 
            // lblStudentNameFilter
            // 
            this.lblStudentNameFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStudentNameFilter.Location = new System.Drawing.Point(330, 30);
            this.lblStudentNameFilter.Name = "lblStudentNameFilter";
            this.lblStudentNameFilter.Size = new System.Drawing.Size(89, 20);
            this.lblStudentNameFilter.TabIndex = 9;
            this.lblStudentNameFilter.Values.Text = "Student Name";
            // 
            // cbYear
            // 
            this.cbYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(449, 53);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(41, 21);
            this.cbYear.TabIndex = 12;
            // 
            // PanelNoteListFiltersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbStudentName);
            this.Controls.Add(this.lblStudentNameFilter);
            this.Controls.Add(this.lblYearFilter);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lblCourseFilter);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.borderAccountSectionCreate);
            this.Controls.Add(this.lblAccountSectionCreate);
            this.Name = "PanelNoteListFiltersUC";
            this.Size = new System.Drawing.Size(557, 77);
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearFilter;
        private System.Windows.Forms.ComboBox cbStudentName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentNameFilter;
        private System.Windows.Forms.ComboBox cbYear;
    }
}
