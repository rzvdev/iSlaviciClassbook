using System.Windows.Forms;

namespace iSlavici.Controls.Nav.Pan
{
    partial class PanelCreateCourseUC
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
            this.togBtnOralCreateCourse = new System.Windows.Forms.CheckBox();
            this.togBtnWrittenCreateCourse = new System.Windows.Forms.CheckBox();
            this.numBtnCreditCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblCreditSectionCreateUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblExaminationModeSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numBtnSemesterCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblSectionSemesterCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTeacherNameCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxTeacherNameCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblYearSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCourseInfoSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numBtnYearCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblCourseNameCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProfilesCreateCourse = new System.Windows.Forms.ComboBox();
            this.lblProfileSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAbvrCourseCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnColocviuCourseType = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radbtnExamenCourseType = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtboxCourseNameCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblCourseTypeSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxAbvrCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // togBtnOralCreateCourse
            // 
            this.togBtnOralCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.togBtnOralCreateCourse.Appearance = System.Windows.Forms.Appearance.Button;
            this.togBtnOralCreateCourse.AutoSize = true;
            this.togBtnOralCreateCourse.BackColor = System.Drawing.Color.White;
            this.togBtnOralCreateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togBtnOralCreateCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.togBtnOralCreateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.togBtnOralCreateCourse.Location = new System.Drawing.Point(438, 285);
            this.togBtnOralCreateCourse.Name = "togBtnOralCreateCourse";
            this.togBtnOralCreateCourse.Size = new System.Drawing.Size(46, 23);
            this.togBtnOralCreateCourse.TabIndex = 116;
            this.togBtnOralCreateCourse.Text = "ORAL";
            this.togBtnOralCreateCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.togBtnOralCreateCourse.UseVisualStyleBackColor = false;
            this.togBtnOralCreateCourse.CheckedChanged += new System.EventHandler(this.TogBtnExamModeChangeEvent);
            // 
            // togBtnWrittenCreateCourse
            // 
            this.togBtnWrittenCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.togBtnWrittenCreateCourse.Appearance = System.Windows.Forms.Appearance.Button;
            this.togBtnWrittenCreateCourse.AutoSize = true;
            this.togBtnWrittenCreateCourse.BackColor = System.Drawing.Color.White;
            this.togBtnWrittenCreateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togBtnWrittenCreateCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.togBtnWrittenCreateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.togBtnWrittenCreateCourse.Location = new System.Drawing.Point(289, 285);
            this.togBtnWrittenCreateCourse.Name = "togBtnWrittenCreateCourse";
            this.togBtnWrittenCreateCourse.Size = new System.Drawing.Size(68, 23);
            this.togBtnWrittenCreateCourse.TabIndex = 115;
            this.togBtnWrittenCreateCourse.Text = "WRITTEN";
            this.togBtnWrittenCreateCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.togBtnWrittenCreateCourse.UseVisualStyleBackColor = false;
            this.togBtnWrittenCreateCourse.CheckedChanged += new System.EventHandler(this.TogBtnExamModeChangeEvent);
            // 
            // numBtnCreditCreateCourse
            // 
            this.numBtnCreditCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnCreditCreateCourse.Location = new System.Drawing.Point(351, 347);
            this.numBtnCreditCreateCourse.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBtnCreditCreateCourse.Name = "numBtnCreditCreateCourse";
            this.numBtnCreditCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnCreditCreateCourse.Size = new System.Drawing.Size(60, 22);
            this.numBtnCreditCreateCourse.TabIndex = 114;
            this.numBtnCreditCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBtnCreditCreateCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCreditSectionCreateUser
            // 
            this.lblCreditSectionCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditSectionCreateUser.AutoSize = false;
            this.lblCreditSectionCreateUser.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblCreditSectionCreateUser.Location = new System.Drawing.Point(352, 314);
            this.lblCreditSectionCreateUser.Name = "lblCreditSectionCreateUser";
            this.lblCreditSectionCreateUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCreditSectionCreateUser.Size = new System.Drawing.Size(55, 26);
            this.lblCreditSectionCreateUser.TabIndex = 113;
            this.lblCreditSectionCreateUser.Values.Text = "Credit";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(262, 282);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblExaminationModeSectionCreateCourse
            // 
            this.lblExaminationModeSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExaminationModeSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblExaminationModeSectionCreateCourse.Location = new System.Drawing.Point(277, 257);
            this.lblExaminationModeSectionCreateCourse.Name = "lblExaminationModeSectionCreateCourse";
            this.lblExaminationModeSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblExaminationModeSectionCreateCourse.Size = new System.Drawing.Size(122, 26);
            this.lblExaminationModeSectionCreateCourse.TabIndex = 112;
            this.lblExaminationModeSectionCreateCourse.Values.Text = "Examination Mode";
            // 
            // numBtnSemesterCreateCourse
            // 
            this.numBtnSemesterCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnSemesterCreateCourse.Location = new System.Drawing.Point(538, 347);
            this.numBtnSemesterCreateCourse.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBtnSemesterCreateCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnSemesterCreateCourse.Name = "numBtnSemesterCreateCourse";
            this.numBtnSemesterCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnSemesterCreateCourse.Size = new System.Drawing.Size(60, 22);
            this.numBtnSemesterCreateCourse.TabIndex = 111;
            this.numBtnSemesterCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBtnSemesterCreateCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSectionSemesterCreateCourse
            // 
            this.lblSectionSemesterCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSectionSemesterCreateCourse.AutoSize = false;
            this.lblSectionSemesterCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblSectionSemesterCreateCourse.Location = new System.Drawing.Point(535, 314);
            this.lblSectionSemesterCreateCourse.Name = "lblSectionSemesterCreateCourse";
            this.lblSectionSemesterCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblSectionSemesterCreateCourse.Size = new System.Drawing.Size(78, 26);
            this.lblSectionSemesterCreateCourse.TabIndex = 110;
            this.lblSectionSemesterCreateCourse.Values.Text = "Semester";
            // 
            // lblTeacherNameCreateCourse
            // 
            this.lblTeacherNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeacherNameCreateCourse.AutoSize = false;
            this.lblTeacherNameCreateCourse.Location = new System.Drawing.Point(259, 168);
            this.lblTeacherNameCreateCourse.Name = "lblTeacherNameCreateCourse";
            this.lblTeacherNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblTeacherNameCreateCourse.Size = new System.Drawing.Size(94, 20);
            this.lblTeacherNameCreateCourse.TabIndex = 109;
            this.lblTeacherNameCreateCourse.Values.Text = "Teacher Name:";
            // 
            // txtboxTeacherNameCreateCourse
            // 
            this.txtboxTeacherNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxTeacherNameCreateCourse.Location = new System.Drawing.Point(363, 166);
            this.txtboxTeacherNameCreateCourse.Name = "txtboxTeacherNameCreateCourse";
            this.txtboxTeacherNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxTeacherNameCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxTeacherNameCreateCourse.TabIndex = 100;
            this.txtboxTeacherNameCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge2.AutoSize = false;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(267, 92);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge4.AutoSize = false;
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(172, 341);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(436, 1);
            this.kryptonBorderEdge4.Text = "kryptonBorderEdge1";
            // 
            // lblYearSectionCreateCourse
            // 
            this.lblYearSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearSectionCreateCourse.AutoSize = false;
            this.lblYearSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblYearSectionCreateCourse.Location = new System.Drawing.Point(453, 314);
            this.lblYearSectionCreateCourse.Name = "lblYearSectionCreateCourse";
            this.lblYearSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearSectionCreateCourse.Size = new System.Drawing.Size(38, 26);
            this.lblYearSectionCreateCourse.TabIndex = 108;
            this.lblYearSectionCreateCourse.Values.Text = "Year";
            // 
            // lblCourseInfoSectionCreateCourse
            // 
            this.lblCourseInfoSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseInfoSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblCourseInfoSectionCreateCourse.Location = new System.Drawing.Point(277, 67);
            this.lblCourseInfoSectionCreateCourse.Name = "lblCourseInfoSectionCreateCourse";
            this.lblCourseInfoSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseInfoSectionCreateCourse.Size = new System.Drawing.Size(126, 26);
            this.lblCourseInfoSectionCreateCourse.TabIndex = 95;
            this.lblCourseInfoSectionCreateCourse.Values.Text = "Course Information";
            // 
            // numBtnYearCreateCourse
            // 
            this.numBtnYearCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnYearCreateCourse.Location = new System.Drawing.Point(445, 347);
            this.numBtnYearCreateCourse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBtnYearCreateCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnYearCreateCourse.Name = "numBtnYearCreateCourse";
            this.numBtnYearCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnYearCreateCourse.Size = new System.Drawing.Size(60, 22);
            this.numBtnYearCreateCourse.TabIndex = 104;
            this.numBtnYearCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBtnYearCreateCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCourseNameCreateCourse
            // 
            this.lblCourseNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseNameCreateCourse.Location = new System.Drawing.Point(262, 108);
            this.lblCourseNameCreateCourse.Name = "lblCourseNameCreateCourse";
            this.lblCourseNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseNameCreateCourse.Size = new System.Drawing.Size(87, 20);
            this.lblCourseNameCreateCourse.TabIndex = 96;
            this.lblCourseNameCreateCourse.Values.Text = "Course Name:";
            // 
            // cbProfilesCreateCourse
            // 
            this.cbProfilesCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfilesCreateCourse.Location = new System.Drawing.Point(184, 347);
            this.cbProfilesCreateCourse.Name = "cbProfilesCreateCourse";
            this.cbProfilesCreateCourse.Size = new System.Drawing.Size(133, 21);
            this.cbProfilesCreateCourse.TabIndex = 103;
            this.cbProfilesCreateCourse.SelectedValueChanged += new System.EventHandler(this.ProfileChangeEvent);
            // 
            // lblProfileSectionCreateCourse
            // 
            this.lblProfileSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblProfileSectionCreateCourse.Location = new System.Drawing.Point(220, 314);
            this.lblProfileSectionCreateCourse.Name = "lblProfileSectionCreateCourse";
            this.lblProfileSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileSectionCreateCourse.Size = new System.Drawing.Size(51, 26);
            this.lblProfileSectionCreateCourse.TabIndex = 107;
            this.lblProfileSectionCreateCourse.Values.Text = "Profile";
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateCourse.Location = new System.Drawing.Point(340, 389);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnCreateCourse.Size = new System.Drawing.Size(90, 25);
            this.btnCreateCourse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateCourse.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateCourse.StateNormal.Border.Rounding = -5;
            this.btnCreateCourse.TabIndex = 105;
            this.btnCreateCourse.Values.Text = "Create";
            this.btnCreateCourse.Click += new System.EventHandler(this.BtnCreateCourseClickEvent);
            // 
            // lblAbvrCourseCreateCourse
            // 
            this.lblAbvrCourseCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAbvrCourseCreateCourse.Location = new System.Drawing.Point(265, 138);
            this.lblAbvrCourseCreateCourse.Name = "lblAbvrCourseCreateCourse";
            this.lblAbvrCourseCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAbvrCourseCreateCourse.Size = new System.Drawing.Size(83, 20);
            this.lblAbvrCourseCreateCourse.TabIndex = 97;
            this.lblAbvrCourseCreateCourse.Values.Text = "Abbreviation:";
            // 
            // radBtnColocviuCourseType
            // 
            this.radBtnColocviuCourseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnColocviuCourseType.Location = new System.Drawing.Point(417, 232);
            this.radBtnColocviuCourseType.Name = "radBtnColocviuCourseType";
            this.radBtnColocviuCourseType.Size = new System.Drawing.Size(85, 20);
            this.radBtnColocviuCourseType.TabIndex = 102;
            this.radBtnColocviuCourseType.Values.Text = "COLLOQUY";
            this.radBtnColocviuCourseType.Click += RadBtnCourseType;
            // 
            // radbtnExamenCourseType
            // 
            this.radbtnExamenCourseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnExamenCourseType.Checked = false;
            this.radbtnExamenCourseType.Location = new System.Drawing.Point(291, 231);
            this.radbtnExamenCourseType.Name = "radbtnExamenCourseType";
            this.radbtnExamenCourseType.Size = new System.Drawing.Size(55, 20);
            this.radbtnExamenCourseType.TabIndex = 101;
            this.radbtnExamenCourseType.Values.Text = "EXAM";
            this.radbtnExamenCourseType.Click += RadBtnCourseType;
            // 
            // txtboxCourseNameCreateCourse
            // 
            this.txtboxCourseNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxCourseNameCreateCourse.Location = new System.Drawing.Point(363, 106);
            this.txtboxCourseNameCreateCourse.Name = "txtboxCourseNameCreateCourse";
            this.txtboxCourseNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxCourseNameCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxCourseNameCreateCourse.TabIndex = 98;
            this.txtboxCourseNameCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge5
            // 
            this.kryptonBorderEdge5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge5.AutoSize = false;
            this.kryptonBorderEdge5.Location = new System.Drawing.Point(262, 228);
            this.kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            this.kryptonBorderEdge5.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge5.Text = "kryptonBorderEdge1";
            // 
            // lblCourseTypeSectionCreateCourse
            // 
            this.lblCourseTypeSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseTypeSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblCourseTypeSectionCreateCourse.Location = new System.Drawing.Point(277, 203);
            this.lblCourseTypeSectionCreateCourse.Name = "lblCourseTypeSectionCreateCourse";
            this.lblCourseTypeSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseTypeSectionCreateCourse.Size = new System.Drawing.Size(84, 26);
            this.lblCourseTypeSectionCreateCourse.TabIndex = 106;
            this.lblCourseTypeSectionCreateCourse.Values.Text = "Course Type";
            // 
            // txtboxAbvrCreateCourse
            // 
            this.txtboxAbvrCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxAbvrCreateCourse.Location = new System.Drawing.Point(363, 136);
            this.txtboxAbvrCreateCourse.Name = "txtboxAbvrCreateCourse";
            this.txtboxAbvrCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxAbvrCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxAbvrCreateCourse.TabIndex = 99;
            this.txtboxAbvrCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelCreateCourseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.togBtnOralCreateCourse);
            this.Controls.Add(this.togBtnWrittenCreateCourse);
            this.Controls.Add(this.numBtnCreditCreateCourse);
            this.Controls.Add(this.lblCreditSectionCreateUser);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.lblExaminationModeSectionCreateCourse);
            this.Controls.Add(this.numBtnSemesterCreateCourse);
            this.Controls.Add(this.lblSectionSemesterCreateCourse);
            this.Controls.Add(this.lblTeacherNameCreateCourse);
            this.Controls.Add(this.txtboxTeacherNameCreateCourse);
            this.Controls.Add(this.kryptonBorderEdge2);
            this.Controls.Add(this.kryptonBorderEdge4);
            this.Controls.Add(this.lblYearSectionCreateCourse);
            this.Controls.Add(this.lblCourseInfoSectionCreateCourse);
            this.Controls.Add(this.numBtnYearCreateCourse);
            this.Controls.Add(this.lblCourseNameCreateCourse);
            this.Controls.Add(this.cbProfilesCreateCourse);
            this.Controls.Add(this.lblProfileSectionCreateCourse);
            this.Controls.Add(this.btnCreateCourse);
            this.Controls.Add(this.lblAbvrCourseCreateCourse);
            this.Controls.Add(this.radBtnColocviuCourseType);
            this.Controls.Add(this.radbtnExamenCourseType);
            this.Controls.Add(this.txtboxCourseNameCreateCourse);
            this.Controls.Add(this.kryptonBorderEdge5);
            this.Controls.Add(this.lblCourseTypeSectionCreateCourse);
            this.Controls.Add(this.txtboxAbvrCreateCourse);
            this.Name = "PanelCreateCourseUC";
            this.Size = new System.Drawing.Size(784, 481);
            this.Load += new System.EventHandler(this.PanelCreateCourseUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox togBtnOralCreateCourse;
        private System.Windows.Forms.CheckBox togBtnWrittenCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnCreditCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCreditSectionCreateUser;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblExaminationModeSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnSemesterCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSectionSemesterCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTeacherNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxTeacherNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseInfoSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnYearCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseNameCreateCourse;
        private ComboBox cbProfilesCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAbvrCourseCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnColocviuCourseType;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radbtnExamenCourseType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxCourseNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseTypeSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxAbvrCreateCourse;
    }
}
