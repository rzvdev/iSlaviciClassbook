namespace iSlavici.Controls.Nav.Pan
{
    partial class PanelAddNoteUC
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
            this.btnAddInAddNote = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbNoteTypeAddNote = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbCourseAddNote = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbNameAddNote = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.numBtnAddNoteValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNoteValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNoteType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblYearValueAddNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfileValueAddNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCnpValueAddNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblYear = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCnp = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderStudentSection = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblStudentSection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblCourseAbvr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCourseProfileValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCourseTeacherValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbSemesterFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonBorderEdge8 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblProfileFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfileFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblYearFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbYearFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSemester = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoteTypeAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCourseAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNameAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemesterFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProfileFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInAddNote
            // 
            this.btnAddInAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddInAddNote.Location = new System.Drawing.Point(338, 379);
            this.btnAddInAddNote.Name = "btnAddInAddNote";
            this.btnAddInAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnAddInAddNote.Size = new System.Drawing.Size(90, 25);
            this.btnAddInAddNote.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddInAddNote.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAddInAddNote.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddInAddNote.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAddInAddNote.StateNormal.Border.Rounding = -5;
            this.btnAddInAddNote.TabIndex = 144;
            this.btnAddInAddNote.Values.Text = "ADD";
            this.btnAddInAddNote.Click += new System.EventHandler(this.BtnAddClickEvent);
            // 
            // cbNoteTypeAddNote
            // 
            this.cbNoteTypeAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNoteTypeAddNote.DropDownWidth = 121;
            this.cbNoteTypeAddNote.Location = new System.Drawing.Point(539, 245);
            this.cbNoteTypeAddNote.Name = "cbNoteTypeAddNote";
            this.cbNoteTypeAddNote.Size = new System.Drawing.Size(178, 21);
            this.cbNoteTypeAddNote.TabIndex = 143;
            // 
            // cbCourseAddNote
            // 
            this.cbCourseAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCourseAddNote.DropDownWidth = 121;
            this.cbCourseAddNote.Location = new System.Drawing.Point(114, 244);
            this.cbCourseAddNote.Name = "cbCourseAddNote";
            this.cbCourseAddNote.Size = new System.Drawing.Size(221, 21);
            this.cbCourseAddNote.TabIndex = 142;
            this.cbCourseAddNote.SelectedIndexChanged += new System.EventHandler(this.CbCourseSelectedEvent);
            // 
            // cbNameAddNote
            // 
            this.cbNameAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNameAddNote.DropDownWidth = 174;
            this.cbNameAddNote.Location = new System.Drawing.Point(499, 81);
            this.cbNameAddNote.Name = "cbNameAddNote";
            this.cbNameAddNote.Size = new System.Drawing.Size(215, 21);
            this.cbNameAddNote.TabIndex = 141;
            this.cbNameAddNote.SelectedIndexChanged += new System.EventHandler(this.CbStudentNameSelectedEvent);
            // 
            // numBtnAddNoteValue
            // 
            this.numBtnAddNoteValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnAddNoteValue.Location = new System.Drawing.Point(540, 283);
            this.numBtnAddNoteValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBtnAddNoteValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnAddNoteValue.Name = "numBtnAddNoteValue";
            this.numBtnAddNoteValue.Size = new System.Drawing.Size(39, 22);
            this.numBtnAddNoteValue.TabIndex = 140;
            this.numBtnAddNoteValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel4.Location = new System.Drawing.Point(76, 212);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(52, 26);
            this.kryptonLabel4.TabIndex = 139;
            this.kryptonLabel4.Values.Text = "Course";
            // 
            // lblNoteValue
            // 
            this.lblNoteValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteValue.Location = new System.Drawing.Point(461, 285);
            this.lblNoteValue.Name = "lblNoteValue";
            this.lblNoteValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteValue.Size = new System.Drawing.Size(74, 20);
            this.lblNoteValue.TabIndex = 138;
            this.lblNoteValue.Values.Text = "Note Value:";
            // 
            // lblNoteType
            // 
            this.lblNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteType.Location = new System.Drawing.Point(463, 245);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteType.Size = new System.Drawing.Size(70, 20);
            this.lblNoteType.TabIndex = 137;
            this.lblNoteType.Values.Text = "Note Type:";
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourse.Location = new System.Drawing.Point(53, 246);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourse.Size = new System.Drawing.Size(51, 20);
            this.lblCourse.TabIndex = 136;
            this.lblCourse.Values.Text = "Course:";
            // 
            // lblYearValueAddNote
            // 
            this.lblYearValueAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearValueAddNote.AutoSize = false;
            this.lblYearValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblYearValueAddNote.Location = new System.Drawing.Point(496, 164);
            this.lblYearValueAddNote.Name = "lblYearValueAddNote";
            this.lblYearValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearValueAddNote.Size = new System.Drawing.Size(14, 29);
            this.lblYearValueAddNote.TabIndex = 135;
            this.lblYearValueAddNote.Values.Text = "";
            // 
            // lblProfileValueAddNote
            // 
            this.lblProfileValueAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileValueAddNote.AutoSize = false;
            this.lblProfileValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblProfileValueAddNote.Location = new System.Drawing.Point(495, 138);
            this.lblProfileValueAddNote.Name = "lblProfileValueAddNote";
            this.lblProfileValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileValueAddNote.Size = new System.Drawing.Size(179, 20);
            this.lblProfileValueAddNote.TabIndex = 134;
            this.lblProfileValueAddNote.Values.Text = "";
            // 
            // lblCnpValueAddNote
            // 
            this.lblCnpValueAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnpValueAddNote.AutoSize = false;
            this.lblCnpValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCnpValueAddNote.Location = new System.Drawing.Point(494, 110);
            this.lblCnpValueAddNote.Name = "lblCnpValueAddNote";
            this.lblCnpValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnpValueAddNote.Size = new System.Drawing.Size(106, 20);
            this.lblCnpValueAddNote.TabIndex = 133;
            this.lblCnpValueAddNote.Values.Text = "";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.Location = new System.Drawing.Point(459, 169);
            this.lblYear.Name = "lblYear";
            this.lblYear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYear.Size = new System.Drawing.Size(37, 20);
            this.lblYear.TabIndex = 132;
            this.lblYear.Values.Text = "Year:";
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfile.Location = new System.Drawing.Point(448, 140);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfile.Size = new System.Drawing.Size(48, 20);
            this.lblProfile.TabIndex = 131;
            this.lblProfile.Values.Text = "Profile:";
            // 
            // lblCnp
            // 
            this.lblCnp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnp.Location = new System.Drawing.Point(459, 111);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnp.Size = new System.Drawing.Size(37, 20);
            this.lblCnp.TabIndex = 130;
            this.lblCnp.Values.Text = "CNP:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Location = new System.Drawing.Point(450, 83);
            this.lblName.Name = "lblName";
            this.lblName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 129;
            this.lblName.Values.Text = "Name:";
            // 
            // borderStudentSection
            // 
            this.borderStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderStudentSection.AutoSize = false;
            this.borderStudentSection.Location = new System.Drawing.Point(451, 74);
            this.borderStudentSection.Name = "borderStudentSection";
            this.borderStudentSection.Size = new System.Drawing.Size(260, 1);
            this.borderStudentSection.Text = "kryptonBorderEdge1";
            // 
            // lblStudentSection
            // 
            this.lblStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblStudentSection.Location = new System.Drawing.Point(463, 49);
            this.lblStudentSection.Name = "lblStudentSection";
            this.lblStudentSection.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblStudentSection.Size = new System.Drawing.Size(58, 26);
            this.lblStudentSection.TabIndex = 128;
            this.lblStudentSection.Values.Text = "Student";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(63, 237);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(270, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblCourseAbvr
            // 
            this.lblCourseAbvr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseAbvr.AutoSize = false;
            this.lblCourseAbvr.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCourseAbvr.Location = new System.Drawing.Point(110, 273);
            this.lblCourseAbvr.Name = "lblCourseAbvr";
            this.lblCourseAbvr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseAbvr.Size = new System.Drawing.Size(106, 20);
            this.lblCourseAbvr.TabIndex = 150;
            this.lblCourseAbvr.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel3.Location = new System.Drawing.Point(63, 274);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel3.TabIndex = 149;
            this.kryptonLabel3.Values.Text = "Abvr:";
            // 
            // lblCourseProfileValue
            // 
            this.lblCourseProfileValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseProfileValue.AutoSize = false;
            this.lblCourseProfileValue.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCourseProfileValue.Location = new System.Drawing.Point(110, 301);
            this.lblCourseProfileValue.Name = "lblCourseProfileValue";
            this.lblCourseProfileValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseProfileValue.Size = new System.Drawing.Size(106, 20);
            this.lblCourseProfileValue.TabIndex = 152;
            this.lblCourseProfileValue.Values.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel5.Location = new System.Drawing.Point(55, 302);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel5.TabIndex = 151;
            this.kryptonLabel5.Values.Text = "Profile:";
            // 
            // lblCourseTeacherValue
            // 
            this.lblCourseTeacherValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseTeacherValue.AutoSize = false;
            this.lblCourseTeacherValue.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCourseTeacherValue.Location = new System.Drawing.Point(109, 327);
            this.lblCourseTeacherValue.Name = "lblCourseTeacherValue";
            this.lblCourseTeacherValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseTeacherValue.Size = new System.Drawing.Size(106, 20);
            this.lblCourseTeacherValue.TabIndex = 154;
            this.lblCourseTeacherValue.Values.Text = "";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel7.Location = new System.Drawing.Point(49, 328);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel7.TabIndex = 153;
            this.kryptonLabel7.Values.Text = "Teacher:";
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge2.AutoSize = false;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(457, 237);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(260, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel8.Location = new System.Drawing.Point(469, 212);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 26);
            this.kryptonLabel8.TabIndex = 156;
            this.kryptonLabel8.Values.Text = "Note";
            // 
            // cbSemesterFilter
            // 
            this.cbSemesterFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSemesterFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemesterFilter.DropDownWidth = 174;
            this.cbSemesterFilter.Enabled = false;
            this.cbSemesterFilter.Location = new System.Drawing.Point(112, 134);
            this.cbSemesterFilter.Name = "cbSemesterFilter";
            this.cbSemesterFilter.Size = new System.Drawing.Size(42, 21);
            this.cbSemesterFilter.Sorted = true;
            this.cbSemesterFilter.TabIndex = 163;
            this.cbSemesterFilter.SelectedIndexChanged += new System.EventHandler(this.CbYearAndSemesterSelectEvent);
            // 
            // kryptonBorderEdge8
            // 
            this.kryptonBorderEdge8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge8.AutoSize = false;
            this.kryptonBorderEdge8.Location = new System.Drawing.Point(64, 74);
            this.kryptonBorderEdge8.Name = "kryptonBorderEdge8";
            this.kryptonBorderEdge8.Size = new System.Drawing.Size(260, 1);
            this.kryptonBorderEdge8.Text = "kryptonBorderEdge1";
            // 
            // lblProfileFilter
            // 
            this.lblProfileFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileFilter.Location = new System.Drawing.Point(60, 81);
            this.lblProfileFilter.Name = "lblProfileFilter";
            this.lblProfileFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileFilter.Size = new System.Drawing.Size(48, 20);
            this.lblProfileFilter.TabIndex = 158;
            this.lblProfileFilter.Values.Text = "Profile:";
            // 
            // cbProfileFilter
            // 
            this.cbProfileFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfileFilter.DropDownWidth = 174;
            this.cbProfileFilter.Location = new System.Drawing.Point(112, 79);
            this.cbProfileFilter.Name = "cbProfileFilter";
            this.cbProfileFilter.Size = new System.Drawing.Size(153, 21);
            this.cbProfileFilter.TabIndex = 159;
            this.cbProfileFilter.SelectedIndexChanged += new System.EventHandler(this.CbProfileSelectEvent);
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearFilter.Location = new System.Drawing.Point(70, 107);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearFilter.Size = new System.Drawing.Size(37, 20);
            this.lblYearFilter.TabIndex = 160;
            this.lblYearFilter.Values.Text = "Year:";
            // 
            // cbYearFilter
            // 
            this.cbYearFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbYearFilter.DropDownWidth = 174;
            this.cbYearFilter.Enabled = false;
            this.cbYearFilter.Location = new System.Drawing.Point(112, 106);
            this.cbYearFilter.Name = "cbYearFilter";
            this.cbYearFilter.Size = new System.Drawing.Size(42, 21);
            this.cbYearFilter.Sorted = true;
            this.cbYearFilter.TabIndex = 161;
            this.cbYearFilter.SelectedIndexChanged += new System.EventHandler(this.CbYearAndSemesterSelectEvent);
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemester.Location = new System.Drawing.Point(68, 135);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblSemester.Size = new System.Drawing.Size(40, 20);
            this.lblSemester.TabIndex = 162;
            this.lblSemester.Values.Text = "Sem.:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel1.Location = new System.Drawing.Point(76, 49);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 26);
            this.kryptonLabel1.TabIndex = 145;
            this.kryptonLabel1.Values.Text = "Filters";
            // 
            // PanelAddNoteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSemesterFilter);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.cbYearFilter);
            this.Controls.Add(this.lblYearFilter);
            this.Controls.Add(this.cbProfileFilter);
            this.Controls.Add(this.lblProfileFilter);
            this.Controls.Add(this.kryptonBorderEdge2);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.lblCourseTeacherValue);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.lblCourseProfileValue);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.lblCourseAbvr);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.kryptonBorderEdge8);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnAddInAddNote);
            this.Controls.Add(this.cbNoteTypeAddNote);
            this.Controls.Add(this.cbCourseAddNote);
            this.Controls.Add(this.cbNameAddNote);
            this.Controls.Add(this.numBtnAddNoteValue);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.lblNoteValue);
            this.Controls.Add(this.lblNoteType);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblYearValueAddNote);
            this.Controls.Add(this.lblProfileValueAddNote);
            this.Controls.Add(this.lblCnpValueAddNote);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblCnp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.borderStudentSection);
            this.Controls.Add(this.lblStudentSection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelAddNoteUC";
            this.Size = new System.Drawing.Size(755, 473);
            this.Load += new System.EventHandler(this.PanelAddNoteUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbNoteTypeAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCourseAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNameAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemesterFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProfileFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddInAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNoteTypeAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCourseAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNameAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnAddNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnpValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseAbvr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseProfileValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseTeacherValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSemesterFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbProfileFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbYearFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSemester;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
