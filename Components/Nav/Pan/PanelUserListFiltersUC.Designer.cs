namespace iSlavici.Components.Nav.Pan
{
    partial class PanelUserListFiltersUC
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYearCoursesFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblSearchProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblFilterText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblSearch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(217, 50);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(84, 21);
            this.cbYear.TabIndex = 38;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.YearActiveFilterClickEvent);
            // 
            // lblYearCoursesFilter
            // 
            this.lblYearCoursesFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearCoursesFilter.Location = new System.Drawing.Point(243, 27);
            this.lblYearCoursesFilter.Name = "lblYearCoursesFilter";
            this.lblYearCoursesFilter.Size = new System.Drawing.Size(34, 20);
            this.lblYearCoursesFilter.TabIndex = 37;
            this.lblYearCoursesFilter.Values.Text = "Year";
            // 
            // cbProfile
            // 
            this.cbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(85, 50);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 36;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.ProfileActiveFilterClickEvent);
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProfile.Location = new System.Drawing.Point(120, 27);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(45, 20);
            this.lblSearchProfile.TabIndex = 35;
            this.lblSearchProfile.Values.Text = "Profile";
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(28, 20);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(700, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // lblFilterText
            // 
            this.lblFilterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilterText.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblFilterText.Location = new System.Drawing.Point(39, -5);
            this.lblFilterText.Name = "lblFilterText";
            this.lblFilterText.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblFilterText.Size = new System.Drawing.Size(97, 26);
            this.lblFilterText.TabIndex = 34;
            this.lblFilterText.Values.Text = "Filtre users by:";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(378, 22);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1, 50);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.Location = new System.Drawing.Point(409, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 20);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Values.Text = "Search:";
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSearch.DropDownHeight = 200;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.IntegralHeight = false;
            this.cbSearch.ItemHeight = 13;
            this.cbSearch.Location = new System.Drawing.Point(458, 42);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(225, 21);
            this.cbSearch.TabIndex = 45;
            this.cbSearch.SelectionChangeCommitted += new System.EventHandler(this.SearchActiveFilter);
            // 
            // PanelUserListFiltersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblYearCoursesFilter);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.borderAccountSectionCreate);
            this.Controls.Add(this.lblFilterText);
            this.Name = "PanelUserListFiltersUC";
            this.Size = new System.Drawing.Size(757, 73);
            this.Load += new System.EventHandler(this.PanelUserListFiltersUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearCoursesFilter;
        private System.Windows.Forms.ComboBox cbProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearchProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFilterText;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearch;
        private System.Windows.Forms.ComboBox cbSearch;
    }
}
