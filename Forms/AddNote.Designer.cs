namespace iSlavici.Forms
{
    partial class AddNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.splitcontainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.numBtnNoteValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblNoteValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNoteType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblYearInput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfileInput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCnpInput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNameInput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblYear = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCnp = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderStudentSection = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblStudentSection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.splitContainerTableNote = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.dgvStudentNote = new System.Windows.Forms.DataGridView();
            this.dgvNote = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.droBtnCourse = new System.Windows.Forms.ComboBox();
            this.droBtnNotetype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel1)).BeginInit();
            this.splitcontainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel2)).BeginInit();
            this.splitcontainer.Panel2.SuspendLayout();
            this.splitcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote.Panel1)).BeginInit();
            this.splitContainerTableNote.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote.Panel2)).BeginInit();
            this.splitContainerTableNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // splitcontainer
            // 
            this.splitcontainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainer.IsSplitterFixed = true;
            this.splitcontainer.Location = new System.Drawing.Point(0, 0);
            this.splitcontainer.Name = "splitcontainer";
            // 
            // splitcontainer.Panel1
            // 
            this.splitcontainer.Panel1.Controls.Add(this.droBtnNotetype);
            this.splitcontainer.Panel1.Controls.Add(this.droBtnCourse);
            this.splitcontainer.Panel1.Controls.Add(this.numBtnNoteValue);
            this.splitcontainer.Panel1.Controls.Add(this.kryptonBorderEdge1);
            this.splitcontainer.Panel1.Controls.Add(this.kryptonLabel4);
            this.splitcontainer.Panel1.Controls.Add(this.kryptonButton1);
            this.splitcontainer.Panel1.Controls.Add(this.lblNoteValue);
            this.splitcontainer.Panel1.Controls.Add(this.lblNoteType);
            this.splitcontainer.Panel1.Controls.Add(this.lblCourse);
            this.splitcontainer.Panel1.Controls.Add(this.lblYearInput);
            this.splitcontainer.Panel1.Controls.Add(this.lblProfileInput);
            this.splitcontainer.Panel1.Controls.Add(this.lblCnpInput);
            this.splitcontainer.Panel1.Controls.Add(this.lblNameInput);
            this.splitcontainer.Panel1.Controls.Add(this.lblYear);
            this.splitcontainer.Panel1.Controls.Add(this.lblProfile);
            this.splitcontainer.Panel1.Controls.Add(this.lblCnp);
            this.splitcontainer.Panel1.Controls.Add(this.lblName);
            this.splitcontainer.Panel1.Controls.Add(this.borderStudentSection);
            this.splitcontainer.Panel1.Controls.Add(this.lblStudentSection);
            this.splitcontainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitcontainer_Panel1_Paint);
            // 
            // splitcontainer.Panel2
            // 
            this.splitcontainer.Panel2.Controls.Add(this.splitContainerTableNote);
            this.splitcontainer.Panel2.Controls.Add(this.dgvNote);
            this.splitcontainer.Size = new System.Drawing.Size(1121, 450);
            this.splitcontainer.SplitterDistance = 281;
            this.splitcontainer.TabIndex = 0;
            // 
            // numBtnNoteValue
            // 
            this.numBtnNoteValue.Location = new System.Drawing.Point(79, 302);
            this.numBtnNoteValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBtnNoteValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnNoteValue.Name = "numBtnNoteValue";
            this.numBtnNoteValue.Size = new System.Drawing.Size(39, 22);
            this.numBtnNoteValue.TabIndex = 82;
            this.numBtnNoteValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnNoteValue.ValueChanged += new System.EventHandler(this.numBtnNoteValue_ValueChanged);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(27, 200);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(224, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel4.Location = new System.Drawing.Point(39, 175);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 26);
            this.kryptonLabel4.TabIndex = 78;
            this.kryptonLabel4.Values.Text = "Note";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(78, 413);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 76;
            this.kryptonButton1.Values.Text = "ADD";
            this.kryptonButton1.Click += new System.EventHandler(this.Add);
            // 
            // lblNoteValue
            // 
            this.lblNoteValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteValue.Location = new System.Drawing.Point(3, 302);
            this.lblNoteValue.Name = "lblNoteValue";
            this.lblNoteValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteValue.Size = new System.Drawing.Size(74, 20);
            this.lblNoteValue.TabIndex = 75;
            this.lblNoteValue.Values.Text = "Note Value:";
            // 
            // lblNoteType
            // 
            this.lblNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteType.Location = new System.Drawing.Point(6, 259);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteType.Size = new System.Drawing.Size(70, 20);
            this.lblNoteType.TabIndex = 74;
            this.lblNoteType.Values.Text = "Note Type:";
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourse.Location = new System.Drawing.Point(24, 219);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourse.Size = new System.Drawing.Size(51, 20);
            this.lblCourse.TabIndex = 73;
            this.lblCourse.Values.Text = "Course:";
            // 
            // lblYearInput
            // 
            this.lblYearInput.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblYearInput.Location = new System.Drawing.Point(67, 121);
            this.lblYearInput.Name = "lblYearInput";
            this.lblYearInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearInput.Size = new System.Drawing.Size(6, 2);
            this.lblYearInput.TabIndex = 72;
            this.lblYearInput.Values.Text = "";
            // 
            // lblProfileInput
            // 
            this.lblProfileInput.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblProfileInput.Location = new System.Drawing.Point(67, 95);
            this.lblProfileInput.Name = "lblProfileInput";
            this.lblProfileInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileInput.Size = new System.Drawing.Size(6, 2);
            this.lblProfileInput.TabIndex = 71;
            this.lblProfileInput.Values.Text = "";
            // 
            // lblCnpInput
            // 
            this.lblCnpInput.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCnpInput.Location = new System.Drawing.Point(67, 69);
            this.lblCnpInput.Name = "lblCnpInput";
            this.lblCnpInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnpInput.Size = new System.Drawing.Size(6, 2);
            this.lblCnpInput.TabIndex = 70;
            this.lblCnpInput.Values.Text = "";
            // 
            // lblNameInput
            // 
            this.lblNameInput.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblNameInput.Location = new System.Drawing.Point(67, 46);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNameInput.Size = new System.Drawing.Size(6, 2);
            this.lblNameInput.TabIndex = 69;
            this.lblNameInput.Values.Text = "";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.Location = new System.Drawing.Point(39, 121);
            this.lblYear.Name = "lblYear";
            this.lblYear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYear.Size = new System.Drawing.Size(37, 20);
            this.lblYear.TabIndex = 66;
            this.lblYear.Values.Text = "Year:";
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfile.Location = new System.Drawing.Point(28, 95);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfile.Size = new System.Drawing.Size(48, 20);
            this.lblProfile.TabIndex = 65;
            this.lblProfile.Values.Text = "Profile:";
            // 
            // lblCnp
            // 
            this.lblCnp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnp.Location = new System.Drawing.Point(39, 69);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnp.Size = new System.Drawing.Size(37, 20);
            this.lblCnp.TabIndex = 64;
            this.lblCnp.Values.Text = "CNP:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Location = new System.Drawing.Point(30, 46);
            this.lblName.Name = "lblName";
            this.lblName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 59;
            this.lblName.Values.Text = "Name:";
            // 
            // borderStudentSection
            // 
            this.borderStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderStudentSection.AutoSize = false;
            this.borderStudentSection.Location = new System.Drawing.Point(31, 37);
            this.borderStudentSection.Name = "borderStudentSection";
            this.borderStudentSection.Size = new System.Drawing.Size(224, 1);
            this.borderStudentSection.Text = "kryptonBorderEdge1";
            // 
            // lblStudentSection
            // 
            this.lblStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblStudentSection.Location = new System.Drawing.Point(43, 12);
            this.lblStudentSection.Name = "lblStudentSection";
            this.lblStudentSection.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblStudentSection.Size = new System.Drawing.Size(58, 26);
            this.lblStudentSection.TabIndex = 6;
            this.lblStudentSection.Values.Text = "Student";
            // 
            // splitContainerTableNote
            // 
            this.splitContainerTableNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerTableNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTableNote.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTableNote.Name = "splitContainerTableNote";
            // 
            // splitContainerTableNote.Panel1
            // 
            this.splitContainerTableNote.Panel1.Controls.Add(this.dgvStudentNote);
            this.splitContainerTableNote.Size = new System.Drawing.Size(835, 450);
            this.splitContainerTableNote.SplitterDistance = 703;
            this.splitContainerTableNote.TabIndex = 1;
            // 
            // dgvStudentNote
            // 
            this.dgvStudentNote.AllowUserToAddRows = false;
            this.dgvStudentNote.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudentNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentNote.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudentNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentNote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudentNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentNote.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentNote.EnableHeadersVisualStyles = false;
            this.dgvStudentNote.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentNote.Name = "dgvStudentNote";
            this.dgvStudentNote.ReadOnly = true;
            this.dgvStudentNote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentNote.RowHeadersWidth = 40;
            this.dgvStudentNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentNote.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentNote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentNote.Size = new System.Drawing.Size(703, 450);
            this.dgvStudentNote.TabIndex = 2;
            this.dgvStudentNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentNote_CellContentClick);
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.AllowUserToDeleteRows = false;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNote.Location = new System.Drawing.Point(0, 0);
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.ReadOnly = true;
            this.dgvNote.Size = new System.Drawing.Size(835, 450);
            this.dgvNote.TabIndex = 0;
            // 
            // droBtnCourse
            // 
            this.droBtnCourse.FormattingEnabled = true;
            this.droBtnCourse.Location = new System.Drawing.Point(78, 219);
            this.droBtnCourse.Name = "droBtnCourse";
            this.droBtnCourse.Size = new System.Drawing.Size(173, 21);
            this.droBtnCourse.TabIndex = 89;
            // 
            // droBtnNotetype
            // 
            this.droBtnNotetype.FormattingEnabled = true;
            this.droBtnNotetype.Location = new System.Drawing.Point(78, 259);
            this.droBtnNotetype.Name = "droBtnNotetype";
            this.droBtnNotetype.Size = new System.Drawing.Size(173, 21);
            this.droBtnNotetype.TabIndex = 90;
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.splitcontainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.Load += new System.EventHandler(this.AddNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel1)).EndInit();
            this.splitcontainer.Panel1.ResumeLayout(false);
            this.splitcontainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel2)).EndInit();
            this.splitcontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).EndInit();
            this.splitcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote.Panel1)).EndInit();
            this.splitContainerTableNote.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableNote)).EndInit();
            this.splitContainerTableNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitcontainer;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnpInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNameInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvNote;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerTableNote;
        private System.Windows.Forms.DataGridView dgvStudentNote;
        private System.Windows.Forms.ComboBox droBtnCourse;
        private System.Windows.Forms.ComboBox droBtnNotetype;
    }
}