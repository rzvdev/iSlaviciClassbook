namespace iSlavici.Components.Nav.Pan
{
    partial class PanelMyCoursesListFiltersUC
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCoursesYear = new System.Windows.Forms.ComboBox();
            this.lblYearCoursesFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblSearchProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(496, 56);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(84, 21);
            this.cbType.TabIndex = 40;
            this.cbType.SelectionChangeCommitted += new System.EventHandler(this.TypeActiveFilter);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.Location = new System.Drawing.Point(519, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 20);
            this.lblType.TabIndex = 39;
            this.lblType.Values.Text = "Type";
            // 
            // cbCoursesYear
            // 
            this.cbCoursesYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCoursesYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursesYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCoursesYear.FormattingEnabled = true;
            this.cbCoursesYear.Location = new System.Drawing.Point(406, 56);
            this.cbCoursesYear.Name = "cbCoursesYear";
            this.cbCoursesYear.Size = new System.Drawing.Size(84, 21);
            this.cbCoursesYear.TabIndex = 38;
            this.cbCoursesYear.SelectionChangeCommitted += new System.EventHandler(this.CourseYearActiveFilter);
            // 
            // lblYearCoursesFilter
            // 
            this.lblYearCoursesFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearCoursesFilter.Location = new System.Drawing.Point(409, 33);
            this.lblYearCoursesFilter.Name = "lblYearCoursesFilter";
            this.lblYearCoursesFilter.Size = new System.Drawing.Size(76, 20);
            this.lblYearCoursesFilter.TabIndex = 37;
            this.lblYearCoursesFilter.Values.Text = "Course Year";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.Enabled = false;
            this.cbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(279, 56);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 36;
            this.cbProfile.SelectionChangeCommitted += new System.EventHandler(this.ProfileActiveFilter);
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProfile.Location = new System.Drawing.Point(314, 33);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(45, 20);
            this.lblSearchProfile.TabIndex = 35;
            this.lblSearchProfile.Values.Text = "Profile";
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(29, 26);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(700, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(40, 1);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(110, 26);
            this.lblAccountSectionCreate.TabIndex = 34;
            this.lblAccountSectionCreate.Values.Text = "Filtre courses by:";
            // 
            // PanelMyCoursesListFiltersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbCoursesYear);
            this.Controls.Add(this.lblYearCoursesFilter);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.borderAccountSectionCreate);
            this.Controls.Add(this.lblAccountSectionCreate);
            this.Name = "PanelMyCoursesListFiltersUC";
            this.Size = new System.Drawing.Size(758, 79);
            this.Load += new System.EventHandler(this.PanelCourseListFiltersUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblType;
        private System.Windows.Forms.ComboBox cbCoursesYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearCoursesFilter;
        private System.Windows.Forms.ComboBox cbProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearchProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionCreate;
    }
}
