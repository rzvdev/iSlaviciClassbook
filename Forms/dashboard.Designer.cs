using iSlavici.Models;
using iSlavici.Utility;
using System.Windows.Forms;

namespace classbook
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.splitcontainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.splitcontainerLeftSide = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonBorderEdge7 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.labelPersonName = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.labelWelcome = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panelAdmin = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCourse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.paletteRolePanel = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnNotes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProfiles = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.navigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageCreateUser = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lblCnpCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textboxCnpCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.borderPersonSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.borderAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.borderProfileYearSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblYearSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAccountSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numBtnYearCreate = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblUsernameCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.droBtnProfilesCreate = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.profilesContextMenu = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.selectProfileCalculatoare = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonContextMenuSeparator3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.selectProfileContabilitate = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.lblPasswordCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfileSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPersonSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFullNameCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnAdminCreate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lblEmailCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPhoneCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnStudentCreate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtboxUsernameCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.borderRoleSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.txtboxPasswordCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRoleSectionCreate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxFullNameCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtboxEmailCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtboxPhoneCreate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pageUserList = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.splitContainerPageUserList = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.pageCourseList = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.splitContainerCourseList = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.pageEditUser = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lblCnpEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxCnpEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.borderPersonSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.borderAccountSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblYearSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAccountSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numBtnYearEdit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblUsernameEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.droBtnProfilesEdit = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.lblPasswordEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProfileSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPersonSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnUpdateEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFullnameEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnAdminEdit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lblEmailEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPhoneEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnStudentEdit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtboxUsernameEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.borderRoleSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.txtboxPasswordEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRoleSectionEdit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxFullNameEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtboxEmailEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtboxPhoneEdit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pageCreateCourse = new ComponentFactory.Krypton.Navigator.KryptonPage();
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
            this.droBtnProfilesCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.lblProfileSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAbvrCourseCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.radBtnColocviuCourseType = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radbtnExamenCourseType = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtboxCourseNameCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.lblCourseTypeSectionCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxAbvrCreateCourse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pageNoteList = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.splitContainerAddNotePage = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txtboxSearchAddNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelSearchAddNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pageAddNote = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonBorderEdge8 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dataGridViewColumn1 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn2 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn3 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn4 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn5 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn6 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn7 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn8 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn9 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn10 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel1)).BeginInit();
            this.splitcontainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel2)).BeginInit();
            this.splitcontainer.Panel2.SuspendLayout();
            this.splitcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide.Panel1)).BeginInit();
            this.splitcontainerLeftSide.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide.Panel2)).BeginInit();
            this.splitcontainerLeftSide.Panel2.SuspendLayout();
            this.splitcontainerLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdmin)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).BeginInit();
            this.navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateUser)).BeginInit();
            this.pageCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageUserList)).BeginInit();
            this.pageUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList.Panel2)).BeginInit();
            this.splitContainerPageUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageCourseList)).BeginInit();
            this.pageCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList.Panel2)).BeginInit();
            this.splitContainerCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEditUser)).BeginInit();
            this.pageEditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateCourse)).BeginInit();
            this.pageCreateCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNoteList)).BeginInit();
            this.pageNoteList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage.Panel1)).BeginInit();
            this.splitContainerAddNotePage.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage.Panel2)).BeginInit();
            this.splitContainerAddNotePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAddNote)).BeginInit();
            this.pageAddNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoteTypeAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCourseAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNameAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitcontainer
            // 
            this.splitcontainer.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.splitcontainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainer.IsSplitterFixed = true;
            this.splitcontainer.Location = new System.Drawing.Point(0, 0);
            this.splitcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitcontainer.Name = "splitcontainer";
            this.splitcontainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // splitcontainer.Panel1
            // 
            this.splitcontainer.Panel1.Controls.Add(this.splitcontainerLeftSide);
            this.splitcontainer.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.splitcontainer.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            // 
            // splitcontainer.Panel2
            // 
            this.splitcontainer.Panel2.Controls.Add(this.navigator);
            this.splitcontainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitcontainer.Size = new System.Drawing.Size(820, 467);
            this.splitcontainer.SplitterDistance = 106;
            this.splitcontainer.SplitterWidth = 0;
            this.splitcontainer.TabIndex = 0;
            // 
            // splitcontainerLeftSide
            // 
            this.splitcontainerLeftSide.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitcontainerLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainerLeftSide.IsSplitterFixed = true;
            this.splitcontainerLeftSide.Location = new System.Drawing.Point(0, 0);
            this.splitcontainerLeftSide.Margin = new System.Windows.Forms.Padding(0);
            this.splitcontainerLeftSide.Name = "splitcontainerLeftSide";
            this.splitcontainerLeftSide.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitcontainerLeftSide.Panel1
            // 
            this.splitcontainerLeftSide.Panel1.Controls.Add(this.kryptonPanel1);
            // 
            // splitcontainerLeftSide.Panel2
            // 
            this.splitcontainerLeftSide.Panel2.Controls.Add(this.panelAdmin);
            this.splitcontainerLeftSide.Size = new System.Drawing.Size(106, 467);
            this.splitcontainerLeftSide.SplitterDistance = 103;
            this.splitcontainerLeftSide.SplitterWidth = 0;
            this.splitcontainerLeftSide.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge7);
            this.kryptonPanel1.Controls.Add(this.labelPersonName);
            this.kryptonPanel1.Controls.Add(this.labelWelcome);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(106, 103);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonBorderEdge7
            // 
            this.kryptonBorderEdge7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBorderEdge7.AutoSize = false;
            this.kryptonBorderEdge7.Location = new System.Drawing.Point(2, 101);
            this.kryptonBorderEdge7.Name = "kryptonBorderEdge7";
            this.kryptonBorderEdge7.Size = new System.Drawing.Size(101, 1);
            this.kryptonBorderEdge7.Text = "kryptonBorderEdge7";
            // 
            // labelPersonName
            // 
            this.labelPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPersonName.AutoSize = false;
            this.labelPersonName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.labelPersonName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.labelPersonName.Location = new System.Drawing.Point(3, 47);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(104, 34);
            this.labelPersonName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPersonName.UseCompatibleTextRendering = true;
            this.labelPersonName.UseMnemonic = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.AutoSize = false;
            this.labelWelcome.Location = new System.Drawing.Point(3, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.labelWelcome.Size = new System.Drawing.Size(105, 33);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Values.Text = "   Welcome,";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnCourse);
            this.panelAdmin.Controls.Add(this.btnNotes);
            this.panelAdmin.Controls.Add(this.btnProfiles);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(106, 364);
            this.panelAdmin.TabIndex = 0;
            // 
            // btnCourse
            // 
            this.btnCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourse.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnCourse.Location = new System.Drawing.Point(3, 49);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(0);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Palette = this.paletteRolePanel;
            this.btnCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCourse.Size = new System.Drawing.Size(100, 40);
            this.btnCourse.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Values.Image = global::iSlavici.Properties.Resources.coursesBtn_24px;
            this.btnCourse.Values.Text = "Courses";
            this.btnCourse.Click += new System.EventHandler(this.BtnSelectGroup);
            // 
            // paletteRolePanel
            // 
            this.paletteRolePanel.ButtonStyles.ButtonCustom1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.paletteRolePanel.ButtonStyles.ButtonCustom1.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            // 
            // btnNotes
            // 
            this.btnNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnNotes.Location = new System.Drawing.Point(3, 94);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Palette = this.paletteRolePanel;
            this.btnNotes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnNotes.Size = new System.Drawing.Size(100, 40);
            this.btnNotes.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotes.TabIndex = 1;
            this.btnNotes.Values.Image = global::iSlavici.Properties.Resources.notesBtn_24px;
            this.btnNotes.Values.Text = "Notes";
            this.btnNotes.Click += new System.EventHandler(this.BtnSelectGroup);
            // 
            // btnProfiles
            // 
            this.btnProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfiles.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnProfiles.Location = new System.Drawing.Point(3, 6);
            this.btnProfiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Palette = this.paletteRolePanel;
            this.btnProfiles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnProfiles.Size = new System.Drawing.Size(100, 40);
            this.btnProfiles.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfiles.TabIndex = 0;
            this.btnProfiles.Values.Image = global::iSlavici.Properties.Resources.myProfile_24px;
            this.btnProfiles.Values.Text = "Profiles";
            this.btnProfiles.Click += new System.EventHandler(this.BtnSelectGroup);
            // 
            // navigator
            // 
            this.navigator.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.navigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.navigator.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.HidePage;
            this.navigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.ShowEnabled;
            this.navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigator.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.navigator.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.navigator.Location = new System.Drawing.Point(0, 0);
            this.navigator.Name = "navigator";
            this.navigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderGroupTab;
            this.navigator.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            this.navigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageCreateUser,
            this.pageUserList,
            this.pageCourseList,
            this.pageEditUser,
            this.pageCreateCourse,
            this.pageNoteList,
            this.pageAddNote,
            this.kryptonPage1,
            this.kryptonPage2});
            this.navigator.SelectedIndex = 0;
            this.navigator.Size = new System.Drawing.Size(714, 467);
            this.navigator.TabIndex = 0;
            this.navigator.Visible = false;
            // 
            // pageCreateUser
            // 
            this.pageCreateUser.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageCreateUser.Controls.Add(this.lblCnpCreate);
            this.pageCreateUser.Controls.Add(this.textboxCnpCreate);
            this.pageCreateUser.Controls.Add(this.borderPersonSectionCreate);
            this.pageCreateUser.Controls.Add(this.borderAccountSectionCreate);
            this.pageCreateUser.Controls.Add(this.borderProfileYearSectionCreate);
            this.pageCreateUser.Controls.Add(this.lblYearSectionCreate);
            this.pageCreateUser.Controls.Add(this.lblAccountSectionCreate);
            this.pageCreateUser.Controls.Add(this.numBtnYearCreate);
            this.pageCreateUser.Controls.Add(this.lblUsernameCreate);
            this.pageCreateUser.Controls.Add(this.droBtnProfilesCreate);
            this.pageCreateUser.Controls.Add(this.lblPasswordCreate);
            this.pageCreateUser.Controls.Add(this.lblProfileSectionCreate);
            this.pageCreateUser.Controls.Add(this.lblPersonSectionCreate);
            this.pageCreateUser.Controls.Add(this.btnCreate);
            this.pageCreateUser.Controls.Add(this.lblFullNameCreate);
            this.pageCreateUser.Controls.Add(this.radBtnAdminCreate);
            this.pageCreateUser.Controls.Add(this.lblEmailCreate);
            this.pageCreateUser.Controls.Add(this.lblPhoneCreate);
            this.pageCreateUser.Controls.Add(this.radBtnStudentCreate);
            this.pageCreateUser.Controls.Add(this.txtboxUsernameCreate);
            this.pageCreateUser.Controls.Add(this.borderRoleSectionCreate);
            this.pageCreateUser.Controls.Add(this.txtboxPasswordCreate);
            this.pageCreateUser.Controls.Add(this.lblRoleSectionCreate);
            this.pageCreateUser.Controls.Add(this.txtboxFullNameCreate);
            this.pageCreateUser.Controls.Add(this.txtboxEmailCreate);
            this.pageCreateUser.Controls.Add(this.txtboxPhoneCreate);
            this.pageCreateUser.Flags = 65534;
            this.pageCreateUser.LastVisibleSet = true;
            this.pageCreateUser.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageCreateUser.Name = "pageCreateUser";
            this.pageCreateUser.Size = new System.Drawing.Size(710, 387);
            this.pageCreateUser.Text = "Create User";
            this.pageCreateUser.TextDescription = "Here you can create accounts ";
            this.pageCreateUser.TextTitle = "Profiles";
            this.pageCreateUser.ToolTipTitle = "Page ToolTip";
            this.pageCreateUser.UniqueName = "2409C56351894675569C167421E29129";
            this.pageCreateUser.Visible = false;
            // 
            // lblCnpCreate
            // 
            this.lblCnpCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnpCreate.AutoSize = false;
            this.lblCnpCreate.Location = new System.Drawing.Point(418, 100);
            this.lblCnpCreate.Name = "lblCnpCreate";
            this.lblCnpCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnpCreate.Size = new System.Drawing.Size(71, 20);
            this.lblCnpCreate.TabIndex = 32;
            this.lblCnpCreate.Values.Text = "         CNP:";
            // 
            // textboxCnpCreate
            // 
            this.textboxCnpCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxCnpCreate.Location = new System.Drawing.Point(495, 99);
            this.textboxCnpCreate.Name = "textboxCnpCreate";
            this.textboxCnpCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.textboxCnpCreate.Size = new System.Drawing.Size(146, 23);
            this.textboxCnpCreate.TabIndex = 12;
            this.textboxCnpCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // borderPersonSectionCreate
            // 
            this.borderPersonSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderPersonSectionCreate.AutoSize = false;
            this.borderPersonSectionCreate.Location = new System.Drawing.Point(417, 57);
            this.borderPersonSectionCreate.Name = "borderPersonSectionCreate";
            this.borderPersonSectionCreate.Size = new System.Drawing.Size(224, 1);
            this.borderPersonSectionCreate.Text = "kryptonBorderEdge1";
            // 
            // borderAccountSectionCreate
            // 
            this.borderAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionCreate.AutoSize = false;
            this.borderAccountSectionCreate.Location = new System.Drawing.Point(70, 57);
            this.borderAccountSectionCreate.Name = "borderAccountSectionCreate";
            this.borderAccountSectionCreate.Size = new System.Drawing.Size(224, 1);
            this.borderAccountSectionCreate.Text = "kryptonBorderEdge2";
            // 
            // borderProfileYearSectionCreate
            // 
            this.borderProfileYearSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderProfileYearSectionCreate.AutoSize = false;
            this.borderProfileYearSectionCreate.Location = new System.Drawing.Point(70, 273);
            this.borderProfileYearSectionCreate.Name = "borderProfileYearSectionCreate";
            this.borderProfileYearSectionCreate.Size = new System.Drawing.Size(224, 1);
            this.borderProfileYearSectionCreate.Text = "kryptonBorderEdge1";
            // 
            // lblYearSectionCreate
            // 
            this.lblYearSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearSectionCreate.AutoSize = false;
            this.lblYearSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblYearSectionCreate.Location = new System.Drawing.Point(238, 248);
            this.lblYearSectionCreate.Name = "lblYearSectionCreate";
            this.lblYearSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearSectionCreate.Size = new System.Drawing.Size(38, 26);
            this.lblYearSectionCreate.TabIndex = 30;
            this.lblYearSectionCreate.Values.Text = "Year";
            // 
            // lblAccountSectionCreate
            // 
            this.lblAccountSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionCreate.Location = new System.Drawing.Point(82, 32);
            this.lblAccountSectionCreate.Name = "lblAccountSectionCreate";
            this.lblAccountSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionCreate.Size = new System.Drawing.Size(60, 26);
            this.lblAccountSectionCreate.TabIndex = 0;
            this.lblAccountSectionCreate.Values.Text = "Account";
            // 
            // numBtnYearCreate
            // 
            this.numBtnYearCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnYearCreate.Location = new System.Drawing.Point(232, 278);
            this.numBtnYearCreate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBtnYearCreate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnYearCreate.Name = "numBtnYearCreate";
            this.numBtnYearCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnYearCreate.Size = new System.Drawing.Size(60, 22);
            this.numBtnYearCreate.TabIndex = 18;
            this.numBtnYearCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBtnYearCreate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsernameCreate
            // 
            this.lblUsernameCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameCreate.Location = new System.Drawing.Point(76, 75);
            this.lblUsernameCreate.Name = "lblUsernameCreate";
            this.lblUsernameCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblUsernameCreate.Size = new System.Drawing.Size(68, 20);
            this.lblUsernameCreate.TabIndex = 2;
            this.lblUsernameCreate.Values.Text = "Username:";
            // 
            // droBtnProfilesCreate
            // 
            this.droBtnProfilesCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.droBtnProfilesCreate.KryptonContextMenu = this.profilesContextMenu;
            this.droBtnProfilesCreate.Location = new System.Drawing.Point(70, 278);
            this.droBtnProfilesCreate.Name = "droBtnProfilesCreate";
            this.droBtnProfilesCreate.Size = new System.Drawing.Size(133, 25);
            this.droBtnProfilesCreate.TabIndex = 17;
            this.droBtnProfilesCreate.Values.Text = "Profiles";
            // 
            // profilesContextMenu
            // 
            this.profilesContextMenu.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems2});
            // 
            // kryptonContextMenuItems2
            // 
            this.kryptonContextMenuItems2.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuSeparator3,
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.KryptonCommand = this.selectProfileCalculatoare;
            this.kryptonContextMenuItem1.Tag = "";
            this.kryptonContextMenuItem1.Text = "CALCULATOARE";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.KryptonCommand = this.selectProfileContabilitate;
            this.kryptonContextMenuItem2.Text = "CONTABILITATE";
            // 
            // lblPasswordCreate
            // 
            this.lblPasswordCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordCreate.Location = new System.Drawing.Point(76, 110);
            this.lblPasswordCreate.Name = "lblPasswordCreate";
            this.lblPasswordCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPasswordCreate.Size = new System.Drawing.Size(65, 20);
            this.lblPasswordCreate.TabIndex = 3;
            this.lblPasswordCreate.Values.Text = "Password:";
            // 
            // lblProfileSectionCreate
            // 
            this.lblProfileSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblProfileSectionCreate.Location = new System.Drawing.Point(82, 248);
            this.lblProfileSectionCreate.Name = "lblProfileSectionCreate";
            this.lblProfileSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileSectionCreate.Size = new System.Drawing.Size(51, 26);
            this.lblProfileSectionCreate.TabIndex = 26;
            this.lblProfileSectionCreate.Values.Text = "Profile";
            // 
            // lblPersonSectionCreate
            // 
            this.lblPersonSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblPersonSectionCreate.Location = new System.Drawing.Point(429, 32);
            this.lblPersonSectionCreate.Name = "lblPersonSectionCreate";
            this.lblPersonSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPersonSectionCreate.Size = new System.Drawing.Size(94, 26);
            this.lblPersonSectionCreate.TabIndex = 4;
            this.lblPersonSectionCreate.Values.Text = "Person Profile";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Location = new System.Drawing.Point(310, 335);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnCreate.Size = new System.Drawing.Size(90, 25);
            this.btnCreate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateNormal.Border.Rounding = -5;
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Values.Text = "Create";
            // 
            // lblFullNameCreate
            // 
            this.lblFullNameCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullNameCreate.Location = new System.Drawing.Point(418, 75);
            this.lblFullNameCreate.Name = "lblFullNameCreate";
            this.lblFullNameCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblFullNameCreate.Size = new System.Drawing.Size(68, 20);
            this.lblFullNameCreate.TabIndex = 5;
            this.lblFullNameCreate.Values.Text = "Full Name:";
            // 
            // radBtnAdminCreate
            // 
            this.radBtnAdminCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnAdminCreate.Location = new System.Drawing.Point(178, 200);
            this.radBtnAdminCreate.Name = "radBtnAdminCreate";
            this.radBtnAdminCreate.Size = new System.Drawing.Size(51, 20);
            this.radBtnAdminCreate.TabIndex = 16;
            // 
            // lblEmailCreate
            // 
            this.lblEmailCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailCreate.AutoSize = false;
            this.lblEmailCreate.Location = new System.Drawing.Point(418, 126);
            this.lblEmailCreate.Name = "lblEmailCreate";
            this.lblEmailCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblEmailCreate.Size = new System.Drawing.Size(71, 20);
            this.lblEmailCreate.TabIndex = 7;
            this.lblEmailCreate.Values.Text = "        Email:";
            // 
            // lblPhoneCreate
            // 
            this.lblPhoneCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneCreate.AutoSize = false;
            this.lblPhoneCreate.Location = new System.Drawing.Point(418, 157);
            this.lblPhoneCreate.Name = "lblPhoneCreate";
            this.lblPhoneCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPhoneCreate.Size = new System.Drawing.Size(71, 20);
            this.lblPhoneCreate.TabIndex = 8;
            this.lblPhoneCreate.Values.Text = "      Phone:";
            // 
            // radBtnStudentCreate
            // 
            this.radBtnStudentCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnStudentCreate.Location = new System.Drawing.Point(81, 200);
            this.radBtnStudentCreate.Name = "radBtnStudentCreate";
            this.radBtnStudentCreate.Size = new System.Drawing.Size(75, 20);
            this.radBtnStudentCreate.TabIndex = 15;
            this.radBtnStudentCreate.Values.Text = "STUDENT";
            // 
            // txtboxUsernameCreate
            // 
            this.txtboxUsernameCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxUsernameCreate.Location = new System.Drawing.Point(148, 71);
            this.txtboxUsernameCreate.Name = "txtboxUsernameCreate";
            this.txtboxUsernameCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxUsernameCreate.Size = new System.Drawing.Size(146, 23);
            this.txtboxUsernameCreate.TabIndex = 9;
            this.txtboxUsernameCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // borderRoleSectionCreate
            // 
            this.borderRoleSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderRoleSectionCreate.AutoSize = false;
            this.borderRoleSectionCreate.Location = new System.Drawing.Point(70, 196);
            this.borderRoleSectionCreate.Name = "borderRoleSectionCreate";
            this.borderRoleSectionCreate.Size = new System.Drawing.Size(224, 1);
            this.borderRoleSectionCreate.Text = "kryptonBorderEdge1";
            // 
            // txtboxPasswordCreate
            // 
            this.txtboxPasswordCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPasswordCreate.Location = new System.Drawing.Point(148, 109);
            this.txtboxPasswordCreate.Name = "txtboxPasswordCreate";
            this.txtboxPasswordCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxPasswordCreate.PasswordChar = '●';
            this.txtboxPasswordCreate.Size = new System.Drawing.Size(146, 23);
            this.txtboxPasswordCreate.TabIndex = 10;
            this.txtboxPasswordCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPasswordCreate.UseSystemPasswordChar = true;
            // 
            // lblRoleSectionCreate
            // 
            this.lblRoleSectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoleSectionCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblRoleSectionCreate.Location = new System.Drawing.Point(82, 174);
            this.lblRoleSectionCreate.Name = "lblRoleSectionCreate";
            this.lblRoleSectionCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblRoleSectionCreate.Size = new System.Drawing.Size(38, 26);
            this.lblRoleSectionCreate.TabIndex = 19;
            this.lblRoleSectionCreate.Values.Text = "Role";
            // 
            // txtboxFullNameCreate
            // 
            this.txtboxFullNameCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFullNameCreate.Location = new System.Drawing.Point(495, 71);
            this.txtboxFullNameCreate.Name = "txtboxFullNameCreate";
            this.txtboxFullNameCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxFullNameCreate.Size = new System.Drawing.Size(146, 23);
            this.txtboxFullNameCreate.TabIndex = 11;
            this.txtboxFullNameCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxEmailCreate
            // 
            this.txtboxEmailCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxEmailCreate.Location = new System.Drawing.Point(495, 126);
            this.txtboxEmailCreate.Name = "txtboxEmailCreate";
            this.txtboxEmailCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxEmailCreate.Size = new System.Drawing.Size(146, 23);
            this.txtboxEmailCreate.TabIndex = 13;
            this.txtboxEmailCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxPhoneCreate
            // 
            this.txtboxPhoneCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhoneCreate.CausesValidation = false;
            this.txtboxPhoneCreate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtboxPhoneCreate.Location = new System.Drawing.Point(495, 157);
            this.txtboxPhoneCreate.Name = "txtboxPhoneCreate";
            this.txtboxPhoneCreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxPhoneCreate.Size = new System.Drawing.Size(146, 23);
            this.txtboxPhoneCreate.TabIndex = 14;
            this.txtboxPhoneCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageUserList
            // 
            this.pageUserList.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageUserList.Controls.Add(this.splitContainerPageUserList);
            this.pageUserList.Flags = 65534;
            this.pageUserList.LastVisibleSet = true;
            this.pageUserList.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageUserList.Name = "pageUserList";
            this.pageUserList.Size = new System.Drawing.Size(704, 361);
            this.pageUserList.Text = "User List";
            this.pageUserList.TextDescription = "Here you can see a list of registered users as well as certain user information.";
            this.pageUserList.TextTitle = "Profiles";
            this.pageUserList.ToolTipTitle = "Page ToolTip";
            this.pageUserList.UniqueName = "E8E7D5BE3F5C4E70B8B9D9244E28C9B0";
            this.pageUserList.Visible = false;
            // 
            // splitContainerPageUserList
            // 
            this.splitContainerPageUserList.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerPageUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPageUserList.IsSplitterFixed = true;
            this.splitContainerPageUserList.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPageUserList.Name = "splitContainerPageUserList";
            this.splitContainerPageUserList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerPageUserList.Size = new System.Drawing.Size(704, 361);
            this.splitContainerPageUserList.SplitterDistance = 35;
            this.splitContainerPageUserList.TabIndex = 1;
            // 
            // pageCourseList
            // 
            this.pageCourseList.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageCourseList.Controls.Add(this.splitContainerCourseList);
            this.pageCourseList.Flags = 65534;
            this.pageCourseList.LastVisibleSet = true;
            this.pageCourseList.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageCourseList.Name = "pageCourseList";
            this.pageCourseList.Size = new System.Drawing.Size(704, 375);
            this.pageCourseList.Text = "Course List";
            this.pageCourseList.TextDescription = "Here you can see a list with courses";
            this.pageCourseList.TextTitle = "Course";
            this.pageCourseList.ToolTipTitle = "Page ToolTip";
            this.pageCourseList.UniqueName = "F9131B569D2647BEF58475057323CBCE";
            this.pageCourseList.Visible = false;
            // 
            // splitContainerCourseList
            // 
            this.splitContainerCourseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCourseList.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCourseList.Name = "splitContainerCourseList";
            this.splitContainerCourseList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerCourseList.Size = new System.Drawing.Size(704, 375);
            this.splitContainerCourseList.SplitterDistance = 41;
            this.splitContainerCourseList.TabIndex = 0;
            // 
            // pageEditUser
            // 
            this.pageEditUser.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEditUser.Controls.Add(this.lblCnpEdit);
            this.pageEditUser.Controls.Add(this.txtboxCnpEdit);
            this.pageEditUser.Controls.Add(this.borderPersonSectionEdit);
            this.pageEditUser.Controls.Add(this.borderAccountSectionEdit);
            this.pageEditUser.Controls.Add(this.kryptonBorderEdge3);
            this.pageEditUser.Controls.Add(this.lblYearSectionEdit);
            this.pageEditUser.Controls.Add(this.lblAccountSectionEdit);
            this.pageEditUser.Controls.Add(this.numBtnYearEdit);
            this.pageEditUser.Controls.Add(this.lblUsernameEdit);
            this.pageEditUser.Controls.Add(this.droBtnProfilesEdit);
            this.pageEditUser.Controls.Add(this.lblPasswordEdit);
            this.pageEditUser.Controls.Add(this.lblProfileSectionEdit);
            this.pageEditUser.Controls.Add(this.lblPersonSectionEdit);
            this.pageEditUser.Controls.Add(this.btnUpdateEdit);
            this.pageEditUser.Controls.Add(this.lblFullnameEdit);
            this.pageEditUser.Controls.Add(this.radBtnAdminEdit);
            this.pageEditUser.Controls.Add(this.lblEmailEdit);
            this.pageEditUser.Controls.Add(this.lblPhoneEdit);
            this.pageEditUser.Controls.Add(this.radBtnStudentEdit);
            this.pageEditUser.Controls.Add(this.txtboxUsernameEdit);
            this.pageEditUser.Controls.Add(this.borderRoleSectionEdit);
            this.pageEditUser.Controls.Add(this.txtboxPasswordEdit);
            this.pageEditUser.Controls.Add(this.lblRoleSectionEdit);
            this.pageEditUser.Controls.Add(this.txtboxFullNameEdit);
            this.pageEditUser.Controls.Add(this.txtboxEmailEdit);
            this.pageEditUser.Controls.Add(this.txtboxPhoneEdit);
            this.pageEditUser.Flags = 65534;
            this.pageEditUser.LastVisibleSet = true;
            this.pageEditUser.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEditUser.Name = "pageEditUser";
            this.pageEditUser.Size = new System.Drawing.Size(704, 361);
            this.pageEditUser.Text = "Edit User";
            this.pageEditUser.TextDescription = "Here you can edit user";
            this.pageEditUser.TextTitle = "Profiles";
            this.pageEditUser.ToolTipTitle = "Page ToolTip";
            this.pageEditUser.UniqueName = "9AA046C090F1408DE38F21071F8ED967";
            // 
            // lblCnpEdit
            // 
            this.lblCnpEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnpEdit.AutoSize = false;
            this.lblCnpEdit.Location = new System.Drawing.Point(414, 84);
            this.lblCnpEdit.Name = "lblCnpEdit";
            this.lblCnpEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnpEdit.Size = new System.Drawing.Size(71, 20);
            this.lblCnpEdit.TabIndex = 58;
            this.lblCnpEdit.Values.Text = "         CNP:";
            // 
            // txtboxCnpEdit
            // 
            this.txtboxCnpEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxCnpEdit.Location = new System.Drawing.Point(492, 83);
            this.txtboxCnpEdit.Name = "txtboxCnpEdit";
            this.txtboxCnpEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxCnpEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxCnpEdit.TabIndex = 47;
            this.txtboxCnpEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // borderPersonSectionEdit
            // 
            this.borderPersonSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderPersonSectionEdit.AutoSize = false;
            this.borderPersonSectionEdit.Location = new System.Drawing.Point(414, 43);
            this.borderPersonSectionEdit.Name = "borderPersonSectionEdit";
            this.borderPersonSectionEdit.Size = new System.Drawing.Size(224, 1);
            this.borderPersonSectionEdit.Text = "kryptonBorderEdge1";
            // 
            // borderAccountSectionEdit
            // 
            this.borderAccountSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderAccountSectionEdit.AutoSize = false;
            this.borderAccountSectionEdit.Location = new System.Drawing.Point(66, 43);
            this.borderAccountSectionEdit.Name = "borderAccountSectionEdit";
            this.borderAccountSectionEdit.Size = new System.Drawing.Size(224, 1);
            this.borderAccountSectionEdit.Text = "kryptonBorderEdge2";
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge3.AutoSize = false;
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(66, 258);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(224, 1);
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge1";
            // 
            // lblYearSectionEdit
            // 
            this.lblYearSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearSectionEdit.AutoSize = false;
            this.lblYearSectionEdit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblYearSectionEdit.Location = new System.Drawing.Point(234, 234);
            this.lblYearSectionEdit.Name = "lblYearSectionEdit";
            this.lblYearSectionEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearSectionEdit.Size = new System.Drawing.Size(38, 26);
            this.lblYearSectionEdit.TabIndex = 57;
            this.lblYearSectionEdit.Values.Text = "Year";
            // 
            // lblAccountSectionEdit
            // 
            this.lblAccountSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountSectionEdit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblAccountSectionEdit.Location = new System.Drawing.Point(78, 18);
            this.lblAccountSectionEdit.Name = "lblAccountSectionEdit";
            this.lblAccountSectionEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAccountSectionEdit.Size = new System.Drawing.Size(60, 26);
            this.lblAccountSectionEdit.TabIndex = 37;
            this.lblAccountSectionEdit.Values.Text = "Account";
            // 
            // numBtnYearEdit
            // 
            this.numBtnYearEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnYearEdit.Location = new System.Drawing.Point(228, 264);
            this.numBtnYearEdit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBtnYearEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBtnYearEdit.Name = "numBtnYearEdit";
            this.numBtnYearEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnYearEdit.Size = new System.Drawing.Size(60, 22);
            this.numBtnYearEdit.TabIndex = 53;
            this.numBtnYearEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBtnYearEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsernameEdit
            // 
            this.lblUsernameEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameEdit.Location = new System.Drawing.Point(72, 61);
            this.lblUsernameEdit.Name = "lblUsernameEdit";
            this.lblUsernameEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblUsernameEdit.Size = new System.Drawing.Size(68, 20);
            this.lblUsernameEdit.TabIndex = 38;
            this.lblUsernameEdit.Values.Text = "Username:";
            // 
            // droBtnProfilesEdit
            // 
            this.droBtnProfilesEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.droBtnProfilesEdit.KryptonContextMenu = this.profilesContextMenu;
            this.droBtnProfilesEdit.Location = new System.Drawing.Point(66, 264);
            this.droBtnProfilesEdit.Name = "droBtnProfilesEdit";
            this.droBtnProfilesEdit.Size = new System.Drawing.Size(133, 25);
            this.droBtnProfilesEdit.TabIndex = 52;
            this.droBtnProfilesEdit.Values.Text = "Profiles";
            // 
            // lblPasswordEdit
            // 
            this.lblPasswordEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordEdit.Location = new System.Drawing.Point(72, 96);
            this.lblPasswordEdit.Name = "lblPasswordEdit";
            this.lblPasswordEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPasswordEdit.Size = new System.Drawing.Size(65, 20);
            this.lblPasswordEdit.TabIndex = 39;
            this.lblPasswordEdit.Values.Text = "Password:";
            // 
            // lblProfileSectionEdit
            // 
            this.lblProfileSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileSectionEdit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblProfileSectionEdit.Location = new System.Drawing.Point(78, 234);
            this.lblProfileSectionEdit.Name = "lblProfileSectionEdit";
            this.lblProfileSectionEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileSectionEdit.Size = new System.Drawing.Size(51, 26);
            this.lblProfileSectionEdit.TabIndex = 56;
            this.lblProfileSectionEdit.Values.Text = "Profile";
            // 
            // lblPersonSectionEdit
            // 
            this.lblPersonSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonSectionEdit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblPersonSectionEdit.Location = new System.Drawing.Point(426, 18);
            this.lblPersonSectionEdit.Name = "lblPersonSectionEdit";
            this.lblPersonSectionEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPersonSectionEdit.Size = new System.Drawing.Size(94, 26);
            this.lblPersonSectionEdit.TabIndex = 40;
            this.lblPersonSectionEdit.Values.Text = "Person Profile";
            // 
            // btnUpdateEdit
            // 
            this.btnUpdateEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateEdit.Location = new System.Drawing.Point(306, 321);
            this.btnUpdateEdit.Name = "btnUpdateEdit";
            this.btnUpdateEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnUpdateEdit.Size = new System.Drawing.Size(90, 25);
            this.btnUpdateEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateEdit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateEdit.StateNormal.Border.Rounding = -5;
            this.btnUpdateEdit.TabIndex = 54;
            this.btnUpdateEdit.Values.Text = "Update";
            // 
            // lblFullnameEdit
            // 
            this.lblFullnameEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullnameEdit.Location = new System.Drawing.Point(414, 61);
            this.lblFullnameEdit.Name = "lblFullnameEdit";
            this.lblFullnameEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblFullnameEdit.Size = new System.Drawing.Size(68, 20);
            this.lblFullnameEdit.TabIndex = 41;
            this.lblFullnameEdit.Values.Text = "Full Name:";
            // 
            // radBtnAdminEdit
            // 
            this.radBtnAdminEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnAdminEdit.Location = new System.Drawing.Point(174, 186);
            this.radBtnAdminEdit.Name = "radBtnAdminEdit";
            this.radBtnAdminEdit.Size = new System.Drawing.Size(118, 20);
            this.radBtnAdminEdit.TabIndex = 51;
            this.radBtnAdminEdit.Values.Text = "ADMINISTRATOR";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailEdit.AutoSize = false;
            this.lblEmailEdit.Location = new System.Drawing.Point(414, 112);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblEmailEdit.Size = new System.Drawing.Size(71, 20);
            this.lblEmailEdit.TabIndex = 42;
            this.lblEmailEdit.Values.Text = "        Email:";
            // 
            // lblPhoneEdit
            // 
            this.lblPhoneEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneEdit.AutoSize = false;
            this.lblPhoneEdit.Location = new System.Drawing.Point(414, 141);
            this.lblPhoneEdit.Name = "lblPhoneEdit";
            this.lblPhoneEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblPhoneEdit.Size = new System.Drawing.Size(71, 20);
            this.lblPhoneEdit.TabIndex = 43;
            this.lblPhoneEdit.Values.Text = "      Phone:";
            // 
            // radBtnStudentEdit
            // 
            this.radBtnStudentEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnStudentEdit.Checked = true;
            this.radBtnStudentEdit.Location = new System.Drawing.Point(77, 186);
            this.radBtnStudentEdit.Name = "radBtnStudentEdit";
            this.radBtnStudentEdit.Size = new System.Drawing.Size(75, 20);
            this.radBtnStudentEdit.TabIndex = 50;
            this.radBtnStudentEdit.Values.Text = "STUDENT";
            // 
            // txtboxUsernameEdit
            // 
            this.txtboxUsernameEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxUsernameEdit.Location = new System.Drawing.Point(144, 57);
            this.txtboxUsernameEdit.Name = "txtboxUsernameEdit";
            this.txtboxUsernameEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxUsernameEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxUsernameEdit.TabIndex = 44;
            this.txtboxUsernameEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // borderRoleSectionEdit
            // 
            this.borderRoleSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderRoleSectionEdit.AutoSize = false;
            this.borderRoleSectionEdit.Location = new System.Drawing.Point(66, 182);
            this.borderRoleSectionEdit.Name = "borderRoleSectionEdit";
            this.borderRoleSectionEdit.Size = new System.Drawing.Size(224, 1);
            this.borderRoleSectionEdit.Text = "kryptonBorderEdge1";
            // 
            // txtboxPasswordEdit
            // 
            this.txtboxPasswordEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPasswordEdit.Location = new System.Drawing.Point(144, 95);
            this.txtboxPasswordEdit.Name = "txtboxPasswordEdit";
            this.txtboxPasswordEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxPasswordEdit.PasswordChar = '●';
            this.txtboxPasswordEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxPasswordEdit.TabIndex = 45;
            this.txtboxPasswordEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPasswordEdit.UseSystemPasswordChar = true;
            // 
            // lblRoleSectionEdit
            // 
            this.lblRoleSectionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoleSectionEdit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblRoleSectionEdit.Location = new System.Drawing.Point(78, 158);
            this.lblRoleSectionEdit.Name = "lblRoleSectionEdit";
            this.lblRoleSectionEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblRoleSectionEdit.Size = new System.Drawing.Size(38, 26);
            this.lblRoleSectionEdit.TabIndex = 55;
            this.lblRoleSectionEdit.Values.Text = "Role";
            // 
            // txtboxFullNameEdit
            // 
            this.txtboxFullNameEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFullNameEdit.Location = new System.Drawing.Point(492, 57);
            this.txtboxFullNameEdit.Name = "txtboxFullNameEdit";
            this.txtboxFullNameEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxFullNameEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxFullNameEdit.TabIndex = 46;
            this.txtboxFullNameEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxEmailEdit
            // 
            this.txtboxEmailEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxEmailEdit.Location = new System.Drawing.Point(492, 110);
            this.txtboxEmailEdit.Name = "txtboxEmailEdit";
            this.txtboxEmailEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxEmailEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxEmailEdit.TabIndex = 48;
            this.txtboxEmailEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxPhoneEdit
            // 
            this.txtboxPhoneEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhoneEdit.CausesValidation = false;
            this.txtboxPhoneEdit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtboxPhoneEdit.Location = new System.Drawing.Point(492, 141);
            this.txtboxPhoneEdit.Name = "txtboxPhoneEdit";
            this.txtboxPhoneEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxPhoneEdit.Size = new System.Drawing.Size(146, 23);
            this.txtboxPhoneEdit.TabIndex = 49;
            this.txtboxPhoneEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageCreateCourse
            // 
            this.pageCreateCourse.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageCreateCourse.Controls.Add(this.togBtnOralCreateCourse);
            this.pageCreateCourse.Controls.Add(this.togBtnWrittenCreateCourse);
            this.pageCreateCourse.Controls.Add(this.numBtnCreditCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblCreditSectionCreateUser);
            this.pageCreateCourse.Controls.Add(this.kryptonBorderEdge1);
            this.pageCreateCourse.Controls.Add(this.lblExaminationModeSectionCreateCourse);
            this.pageCreateCourse.Controls.Add(this.numBtnSemesterCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblSectionSemesterCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblTeacherNameCreateCourse);
            this.pageCreateCourse.Controls.Add(this.txtboxTeacherNameCreateCourse);
            this.pageCreateCourse.Controls.Add(this.kryptonBorderEdge2);
            this.pageCreateCourse.Controls.Add(this.kryptonBorderEdge4);
            this.pageCreateCourse.Controls.Add(this.lblYearSectionCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblCourseInfoSectionCreateCourse);
            this.pageCreateCourse.Controls.Add(this.numBtnYearCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblCourseNameCreateCourse);
            this.pageCreateCourse.Controls.Add(this.droBtnProfilesCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblProfileSectionCreateCourse);
            this.pageCreateCourse.Controls.Add(this.btnCreateCourse);
            this.pageCreateCourse.Controls.Add(this.lblAbvrCourseCreateCourse);
            this.pageCreateCourse.Controls.Add(this.radBtnColocviuCourseType);
            this.pageCreateCourse.Controls.Add(this.radbtnExamenCourseType);
            this.pageCreateCourse.Controls.Add(this.txtboxCourseNameCreateCourse);
            this.pageCreateCourse.Controls.Add(this.kryptonBorderEdge5);
            this.pageCreateCourse.Controls.Add(this.lblCourseTypeSectionCreateCourse);
            this.pageCreateCourse.Controls.Add(this.txtboxAbvrCreateCourse);
            this.pageCreateCourse.Flags = 65534;
            this.pageCreateCourse.LastVisibleSet = true;
            this.pageCreateCourse.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageCreateCourse.Name = "pageCreateCourse";
            this.pageCreateCourse.Size = new System.Drawing.Size(710, 391);
            this.pageCreateCourse.Text = "Create Course";
            this.pageCreateCourse.TextDescription = "Here you can create courses";
            this.pageCreateCourse.TextTitle = "Courses";
            this.pageCreateCourse.ToolTipTitle = "Page ToolTip";
            this.pageCreateCourse.UniqueName = "B32F0B3A2CFD4B6AAFAC3B6C76788C33";
            this.pageCreateCourse.Visible = false;
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
            this.togBtnOralCreateCourse.Location = new System.Drawing.Point(408, 239);
            this.togBtnOralCreateCourse.Name = "togBtnOralCreateCourse";
            this.togBtnOralCreateCourse.Size = new System.Drawing.Size(46, 23);
            this.togBtnOralCreateCourse.TabIndex = 90;
            this.togBtnOralCreateCourse.Text = "ORAL";
            this.togBtnOralCreateCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.togBtnOralCreateCourse.UseVisualStyleBackColor = false;
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
            this.togBtnWrittenCreateCourse.Location = new System.Drawing.Point(259, 239);
            this.togBtnWrittenCreateCourse.Name = "togBtnWrittenCreateCourse";
            this.togBtnWrittenCreateCourse.Size = new System.Drawing.Size(68, 23);
            this.togBtnWrittenCreateCourse.TabIndex = 89;
            this.togBtnWrittenCreateCourse.Text = "WRITTEN";
            this.togBtnWrittenCreateCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.togBtnWrittenCreateCourse.UseVisualStyleBackColor = false;
            // 
            // numBtnCreditCreateCourse
            // 
            this.numBtnCreditCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnCreditCreateCourse.Location = new System.Drawing.Point(321, 301);
            this.numBtnCreditCreateCourse.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBtnCreditCreateCourse.Name = "numBtnCreditCreateCourse";
            this.numBtnCreditCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.numBtnCreditCreateCourse.Size = new System.Drawing.Size(60, 22);
            this.numBtnCreditCreateCourse.TabIndex = 74;
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
            this.lblCreditSectionCreateUser.Location = new System.Drawing.Point(322, 268);
            this.lblCreditSectionCreateUser.Name = "lblCreditSectionCreateUser";
            this.lblCreditSectionCreateUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCreditSectionCreateUser.Size = new System.Drawing.Size(55, 26);
            this.lblCreditSectionCreateUser.TabIndex = 73;
            this.lblCreditSectionCreateUser.Values.Text = "Credit";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(232, 236);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblExaminationModeSectionCreateCourse
            // 
            this.lblExaminationModeSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExaminationModeSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblExaminationModeSectionCreateCourse.Location = new System.Drawing.Point(247, 211);
            this.lblExaminationModeSectionCreateCourse.Name = "lblExaminationModeSectionCreateCourse";
            this.lblExaminationModeSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblExaminationModeSectionCreateCourse.Size = new System.Drawing.Size(122, 26);
            this.lblExaminationModeSectionCreateCourse.TabIndex = 71;
            this.lblExaminationModeSectionCreateCourse.Values.Text = "Examination Mode";
            // 
            // numBtnSemesterCreateCourse
            // 
            this.numBtnSemesterCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnSemesterCreateCourse.Location = new System.Drawing.Point(508, 301);
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
            this.numBtnSemesterCreateCourse.TabIndex = 64;
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
            this.lblSectionSemesterCreateCourse.Location = new System.Drawing.Point(505, 268);
            this.lblSectionSemesterCreateCourse.Name = "lblSectionSemesterCreateCourse";
            this.lblSectionSemesterCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblSectionSemesterCreateCourse.Size = new System.Drawing.Size(78, 26);
            this.lblSectionSemesterCreateCourse.TabIndex = 63;
            this.lblSectionSemesterCreateCourse.Values.Text = "Semester";
            // 
            // lblTeacherNameCreateCourse
            // 
            this.lblTeacherNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeacherNameCreateCourse.AutoSize = false;
            this.lblTeacherNameCreateCourse.Location = new System.Drawing.Point(229, 122);
            this.lblTeacherNameCreateCourse.Name = "lblTeacherNameCreateCourse";
            this.lblTeacherNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblTeacherNameCreateCourse.Size = new System.Drawing.Size(94, 20);
            this.lblTeacherNameCreateCourse.TabIndex = 58;
            this.lblTeacherNameCreateCourse.Values.Text = "Teacher Name:";
            // 
            // txtboxTeacherNameCreateCourse
            // 
            this.txtboxTeacherNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxTeacherNameCreateCourse.Location = new System.Drawing.Point(333, 120);
            this.txtboxTeacherNameCreateCourse.Name = "txtboxTeacherNameCreateCourse";
            this.txtboxTeacherNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxTeacherNameCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxTeacherNameCreateCourse.TabIndex = 47;
            this.txtboxTeacherNameCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge2.AutoSize = false;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(237, 46);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge4.AutoSize = false;
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(142, 295);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(436, 1);
            this.kryptonBorderEdge4.Text = "kryptonBorderEdge1";
            // 
            // lblYearSectionCreateCourse
            // 
            this.lblYearSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearSectionCreateCourse.AutoSize = false;
            this.lblYearSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblYearSectionCreateCourse.Location = new System.Drawing.Point(423, 268);
            this.lblYearSectionCreateCourse.Name = "lblYearSectionCreateCourse";
            this.lblYearSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearSectionCreateCourse.Size = new System.Drawing.Size(38, 26);
            this.lblYearSectionCreateCourse.TabIndex = 57;
            this.lblYearSectionCreateCourse.Values.Text = "Year";
            // 
            // lblCourseInfoSectionCreateCourse
            // 
            this.lblCourseInfoSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseInfoSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblCourseInfoSectionCreateCourse.Location = new System.Drawing.Point(247, 21);
            this.lblCourseInfoSectionCreateCourse.Name = "lblCourseInfoSectionCreateCourse";
            this.lblCourseInfoSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseInfoSectionCreateCourse.Size = new System.Drawing.Size(126, 26);
            this.lblCourseInfoSectionCreateCourse.TabIndex = 37;
            this.lblCourseInfoSectionCreateCourse.Values.Text = "Course Information";
            // 
            // numBtnYearCreateCourse
            // 
            this.numBtnYearCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBtnYearCreateCourse.Location = new System.Drawing.Point(415, 301);
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
            this.numBtnYearCreateCourse.TabIndex = 53;
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
            this.lblCourseNameCreateCourse.Location = new System.Drawing.Point(232, 62);
            this.lblCourseNameCreateCourse.Name = "lblCourseNameCreateCourse";
            this.lblCourseNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseNameCreateCourse.Size = new System.Drawing.Size(87, 20);
            this.lblCourseNameCreateCourse.TabIndex = 38;
            this.lblCourseNameCreateCourse.Values.Text = "Course Name:";
            // 
            // droBtnProfilesCreateCourse
            // 
            this.droBtnProfilesCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.droBtnProfilesCreateCourse.KryptonContextMenu = this.profilesContextMenu;
            this.droBtnProfilesCreateCourse.Location = new System.Drawing.Point(154, 301);
            this.droBtnProfilesCreateCourse.Name = "droBtnProfilesCreateCourse";
            this.droBtnProfilesCreateCourse.Size = new System.Drawing.Size(133, 25);
            this.droBtnProfilesCreateCourse.TabIndex = 52;
            this.droBtnProfilesCreateCourse.Values.Text = "Profiles";
            // 
            // lblProfileSectionCreateCourse
            // 
            this.lblProfileSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfileSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblProfileSectionCreateCourse.Location = new System.Drawing.Point(190, 268);
            this.lblProfileSectionCreateCourse.Name = "lblProfileSectionCreateCourse";
            this.lblProfileSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileSectionCreateCourse.Size = new System.Drawing.Size(51, 26);
            this.lblProfileSectionCreateCourse.TabIndex = 56;
            this.lblProfileSectionCreateCourse.Values.Text = "Profile";
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateCourse.Location = new System.Drawing.Point(310, 343);
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
            this.btnCreateCourse.TabIndex = 54;
            this.btnCreateCourse.Values.Text = "Create";
            // 
            // lblAbvrCourseCreateCourse
            // 
            this.lblAbvrCourseCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAbvrCourseCreateCourse.Location = new System.Drawing.Point(235, 92);
            this.lblAbvrCourseCreateCourse.Name = "lblAbvrCourseCreateCourse";
            this.lblAbvrCourseCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblAbvrCourseCreateCourse.Size = new System.Drawing.Size(83, 20);
            this.lblAbvrCourseCreateCourse.TabIndex = 41;
            this.lblAbvrCourseCreateCourse.Values.Text = "Abbreviation:";
            // 
            // radBtnColocviuCourseType
            // 
            this.radBtnColocviuCourseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnColocviuCourseType.Location = new System.Drawing.Point(387, 186);
            this.radBtnColocviuCourseType.Name = "radBtnColocviuCourseType";
            this.radBtnColocviuCourseType.Size = new System.Drawing.Size(85, 20);
            this.radBtnColocviuCourseType.TabIndex = 51;
            this.radBtnColocviuCourseType.Values.Text = "COLLOQUY";
            // 
            // radbtnExamenCourseType
            // 
            this.radbtnExamenCourseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnExamenCourseType.Checked = true;
            this.radbtnExamenCourseType.Location = new System.Drawing.Point(261, 185);
            this.radbtnExamenCourseType.Name = "radbtnExamenCourseType";
            this.radbtnExamenCourseType.Size = new System.Drawing.Size(55, 20);
            this.radbtnExamenCourseType.TabIndex = 50;
            this.radbtnExamenCourseType.Values.Text = "EXAM";
            // 
            // txtboxCourseNameCreateCourse
            // 
            this.txtboxCourseNameCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxCourseNameCreateCourse.Location = new System.Drawing.Point(333, 60);
            this.txtboxCourseNameCreateCourse.Name = "txtboxCourseNameCreateCourse";
            this.txtboxCourseNameCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxCourseNameCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxCourseNameCreateCourse.TabIndex = 44;
            this.txtboxCourseNameCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge5
            // 
            this.kryptonBorderEdge5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge5.AutoSize = false;
            this.kryptonBorderEdge5.Location = new System.Drawing.Point(232, 182);
            this.kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            this.kryptonBorderEdge5.Size = new System.Drawing.Size(246, 1);
            this.kryptonBorderEdge5.Text = "kryptonBorderEdge1";
            // 
            // lblCourseTypeSectionCreateCourse
            // 
            this.lblCourseTypeSectionCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseTypeSectionCreateCourse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblCourseTypeSectionCreateCourse.Location = new System.Drawing.Point(247, 157);
            this.lblCourseTypeSectionCreateCourse.Name = "lblCourseTypeSectionCreateCourse";
            this.lblCourseTypeSectionCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourseTypeSectionCreateCourse.Size = new System.Drawing.Size(84, 26);
            this.lblCourseTypeSectionCreateCourse.TabIndex = 55;
            this.lblCourseTypeSectionCreateCourse.Values.Text = "Course Type";
            // 
            // txtboxAbvrCreateCourse
            // 
            this.txtboxAbvrCreateCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxAbvrCreateCourse.Location = new System.Drawing.Point(333, 90);
            this.txtboxAbvrCreateCourse.Name = "txtboxAbvrCreateCourse";
            this.txtboxAbvrCreateCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtboxAbvrCreateCourse.Size = new System.Drawing.Size(146, 23);
            this.txtboxAbvrCreateCourse.TabIndex = 46;
            this.txtboxAbvrCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageNoteList
            // 
            this.pageNoteList.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageNoteList.Controls.Add(this.splitContainerAddNotePage);
            this.pageNoteList.Flags = 65534;
            this.pageNoteList.LastVisibleSet = true;
            this.pageNoteList.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageNoteList.Name = "pageNoteList";
            this.pageNoteList.Size = new System.Drawing.Size(710, 391);
            this.pageNoteList.Text = "Note List";
            this.pageNoteList.TextDescription = "Here you can see and add note to students";
            this.pageNoteList.TextTitle = "Notes";
            this.pageNoteList.ToolTipTitle = "Page ToolTip\r\n";
            this.pageNoteList.UniqueName = "EFBCFADB30634A97CC9CD728527F1E75";
            this.pageNoteList.Visible = false;
            // 
            // splitContainerAddNotePage
            // 
            this.splitContainerAddNotePage.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerAddNotePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAddNotePage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAddNotePage.Name = "splitContainerAddNotePage";
            this.splitContainerAddNotePage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAddNotePage.Panel1
            // 
            this.splitContainerAddNotePage.Panel1.Controls.Add(this.txtboxSearchAddNote);
            this.splitContainerAddNotePage.Panel1.Controls.Add(this.labelSearchAddNote);
            this.splitContainerAddNotePage.Size = new System.Drawing.Size(710, 391);
            this.splitContainerAddNotePage.SplitterDistance = 42;
            this.splitContainerAddNotePage.TabIndex = 0;
            // 
            // txtboxSearchAddNote
            // 
            this.txtboxSearchAddNote.Location = new System.Drawing.Point(50, 8);
            this.txtboxSearchAddNote.Name = "txtboxSearchAddNote";
            this.txtboxSearchAddNote.Size = new System.Drawing.Size(100, 23);
            this.txtboxSearchAddNote.TabIndex = 2;
            // 
            // labelSearchAddNote
            // 
            this.labelSearchAddNote.Location = new System.Drawing.Point(4, 10);
            this.labelSearchAddNote.Name = "labelSearchAddNote";
            this.labelSearchAddNote.Size = new System.Drawing.Size(49, 20);
            this.labelSearchAddNote.TabIndex = 0;
            this.labelSearchAddNote.Values.Text = "Search:";
            // 
            // pageAddNote
            // 
            this.pageAddNote.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageAddNote.Controls.Add(this.kryptonBorderEdge8);
            this.pageAddNote.Controls.Add(this.kryptonLabel1);
            this.pageAddNote.Controls.Add(this.btnAddInAddNote);
            this.pageAddNote.Controls.Add(this.cbNoteTypeAddNote);
            this.pageAddNote.Controls.Add(this.cbCourseAddNote);
            this.pageAddNote.Controls.Add(this.cbNameAddNote);
            this.pageAddNote.Controls.Add(this.numBtnAddNoteValue);
            this.pageAddNote.Controls.Add(this.kryptonLabel4);
            this.pageAddNote.Controls.Add(this.lblNoteValue);
            this.pageAddNote.Controls.Add(this.lblNoteType);
            this.pageAddNote.Controls.Add(this.lblCourse);
            this.pageAddNote.Controls.Add(this.lblYearValueAddNote);
            this.pageAddNote.Controls.Add(this.lblProfileValueAddNote);
            this.pageAddNote.Controls.Add(this.lblCnpValueAddNote);
            this.pageAddNote.Controls.Add(this.lblYear);
            this.pageAddNote.Controls.Add(this.lblProfile);
            this.pageAddNote.Controls.Add(this.lblCnp);
            this.pageAddNote.Controls.Add(this.lblName);
            this.pageAddNote.Controls.Add(this.borderStudentSection);
            this.pageAddNote.Controls.Add(this.lblStudentSection);
            this.pageAddNote.Flags = 65534;
            this.pageAddNote.LastVisibleSet = true;
            this.pageAddNote.Margin = new System.Windows.Forms.Padding(0);
            this.pageAddNote.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageAddNote.Name = "pageAddNote";
            this.pageAddNote.Size = new System.Drawing.Size(710, 387);
            this.pageAddNote.Text = "Add Note";
            this.pageAddNote.TextTitle = "Notes";
            this.pageAddNote.ToolTipTitle = "Page ToolTip";
            this.pageAddNote.UniqueName = "70E2DB3E0DD94BADDE84348A63B124AB";
            this.pageAddNote.Visible = false;
            // 
            // kryptonBorderEdge8
            // 
            this.kryptonBorderEdge8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge8.AutoSize = false;
            this.kryptonBorderEdge8.Location = new System.Drawing.Point(36, 226);
            this.kryptonBorderEdge8.Name = "kryptonBorderEdge8";
            this.kryptonBorderEdge8.Size = new System.Drawing.Size(224, 1);
            this.kryptonBorderEdge8.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel1.Location = new System.Drawing.Point(48, 202);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(58, 26);
            this.kryptonLabel1.TabIndex = 105;
            this.kryptonLabel1.Values.Text = "FILTERS";
            // 
            // btnAddInAddNote
            // 
            this.btnAddInAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddInAddNote.Location = new System.Drawing.Point(310, 315);
            this.btnAddInAddNote.Name = "btnAddInAddNote";
            this.btnAddInAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnAddInAddNote.Size = new System.Drawing.Size(90, 25);
            this.btnAddInAddNote.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddInAddNote.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddInAddNote.StateNormal.Border.Rounding = -5;
            this.btnAddInAddNote.TabIndex = 101;
            this.btnAddInAddNote.Values.Text = "ADD";
            // 
            // cbNoteTypeAddNote
            // 
            this.cbNoteTypeAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNoteTypeAddNote.DropDownWidth = 121;
            this.cbNoteTypeAddNote.Location = new System.Drawing.Point(446, 108);
            this.cbNoteTypeAddNote.Name = "cbNoteTypeAddNote";
            this.cbNoteTypeAddNote.Size = new System.Drawing.Size(164, 21);
            this.cbNoteTypeAddNote.TabIndex = 98;
            // 
            // cbCourseAddNote
            // 
            this.cbCourseAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCourseAddNote.DropDownWidth = 121;
            this.cbCourseAddNote.Location = new System.Drawing.Point(446, 66);
            this.cbCourseAddNote.Name = "cbCourseAddNote";
            this.cbCourseAddNote.Size = new System.Drawing.Size(221, 21);
            this.cbCourseAddNote.TabIndex = 97;
            // 
            // cbNameAddNote
            // 
            this.cbNameAddNote.DropDownWidth = 174;
            this.cbNameAddNote.Location = new System.Drawing.Point(80, 58);
            this.cbNameAddNote.Name = "cbNameAddNote";
            this.cbNameAddNote.Size = new System.Drawing.Size(174, 21);
            this.cbNameAddNote.TabIndex = 96;
            // 
            // numBtnAddNoteValue
            // 
            this.numBtnAddNoteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtnAddNoteValue.Location = new System.Drawing.Point(446, 149);
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
            this.numBtnAddNoteValue.TabIndex = 92;
            this.numBtnAddNoteValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel4.Location = new System.Drawing.Point(402, 23);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 26);
            this.kryptonLabel4.TabIndex = 91;
            this.kryptonLabel4.Values.Text = "Note";
            // 
            // lblNoteValue
            // 
            this.lblNoteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteValue.Location = new System.Drawing.Point(371, 151);
            this.lblNoteValue.Name = "lblNoteValue";
            this.lblNoteValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteValue.Size = new System.Drawing.Size(74, 20);
            this.lblNoteValue.TabIndex = 90;
            this.lblNoteValue.Values.Text = "Note Value:";
            // 
            // lblNoteType
            // 
            this.lblNoteType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteType.Location = new System.Drawing.Point(375, 107);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteType.Size = new System.Drawing.Size(70, 20);
            this.lblNoteType.TabIndex = 89;
            this.lblNoteType.Values.Text = "Note Type:";
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCourse.Location = new System.Drawing.Point(394, 68);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCourse.Size = new System.Drawing.Size(51, 20);
            this.lblCourse.TabIndex = 88;
            this.lblCourse.Values.Text = "Course:";
            // 
            // lblYearValueAddNote
            // 
            this.lblYearValueAddNote.AutoSize = false;
            this.lblYearValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblYearValueAddNote.Location = new System.Drawing.Point(77, 136);
            this.lblYearValueAddNote.Name = "lblYearValueAddNote";
            this.lblYearValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYearValueAddNote.Size = new System.Drawing.Size(14, 29);
            this.lblYearValueAddNote.TabIndex = 82;
            this.lblYearValueAddNote.Values.Text = "";
            // 
            // lblProfileValueAddNote
            // 
            this.lblProfileValueAddNote.AutoSize = false;
            this.lblProfileValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblProfileValueAddNote.Location = new System.Drawing.Point(76, 108);
            this.lblProfileValueAddNote.Name = "lblProfileValueAddNote";
            this.lblProfileValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfileValueAddNote.Size = new System.Drawing.Size(179, 24);
            this.lblProfileValueAddNote.TabIndex = 81;
            this.lblProfileValueAddNote.Values.Text = "";
            // 
            // lblCnpValueAddNote
            // 
            this.lblCnpValueAddNote.AutoSize = false;
            this.lblCnpValueAddNote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblCnpValueAddNote.Location = new System.Drawing.Point(76, 80);
            this.lblCnpValueAddNote.Name = "lblCnpValueAddNote";
            this.lblCnpValueAddNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnpValueAddNote.Size = new System.Drawing.Size(106, 20);
            this.lblCnpValueAddNote.TabIndex = 80;
            this.lblCnpValueAddNote.Values.Text = "";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.Location = new System.Drawing.Point(44, 146);
            this.lblYear.Name = "lblYear";
            this.lblYear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblYear.Size = new System.Drawing.Size(37, 20);
            this.lblYear.TabIndex = 78;
            this.lblYear.Values.Text = "Year:";
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfile.Location = new System.Drawing.Point(33, 116);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblProfile.Size = new System.Drawing.Size(48, 20);
            this.lblProfile.TabIndex = 77;
            this.lblProfile.Values.Text = "Profile:";
            // 
            // lblCnp
            // 
            this.lblCnp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnp.Location = new System.Drawing.Point(44, 87);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblCnp.Size = new System.Drawing.Size(37, 20);
            this.lblCnp.TabIndex = 76;
            this.lblCnp.Values.Text = "CNP:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Location = new System.Drawing.Point(35, 59);
            this.lblName.Name = "lblName";
            this.lblName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 75;
            this.lblName.Values.Text = "Name:";
            // 
            // borderStudentSection
            // 
            this.borderStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderStudentSection.AutoSize = false;
            this.borderStudentSection.Location = new System.Drawing.Point(36, 50);
            this.borderStudentSection.Name = "borderStudentSection";
            this.borderStudentSection.Size = new System.Drawing.Size(224, 1);
            this.borderStudentSection.Text = "kryptonBorderEdge1";
            // 
            // lblStudentSection
            // 
            this.lblStudentSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblStudentSection.Location = new System.Drawing.Point(48, 25);
            this.lblStudentSection.Name = "lblStudentSection";
            this.lblStudentSection.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblStudentSection.Size = new System.Drawing.Size(58, 26);
            this.lblStudentSection.TabIndex = 74;
            this.lblStudentSection.Values.Text = "Student";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(710, 387);
            this.kryptonPage1.Text = "Add Note Types";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "9DB6FBEE09034E5276A4BF5B2FB87417";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(704, 375);
            this.kryptonPage2.Text = "Student List";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "4F146D8BF7584C62E0B3DCA29E0A5201";
            // 
            // dataGridViewColumn1
            // 
            this.dataGridViewColumn1.HeaderText = "ID";
            this.dataGridViewColumn1.MinimumWidth = 6;
            this.dataGridViewColumn1.Name = "dataGridViewColumn1";
            this.dataGridViewColumn1.ReadOnly = true;
            this.dataGridViewColumn1.Width = 50;
            // 
            // dataGridViewColumn2
            // 
            this.dataGridViewColumn2.HeaderText = "USERNAME";
            this.dataGridViewColumn2.MinimumWidth = 6;
            this.dataGridViewColumn2.Name = "dataGridViewColumn2";
            this.dataGridViewColumn2.ReadOnly = true;
            this.dataGridViewColumn2.Width = 150;
            // 
            // dataGridViewColumn3
            // 
            this.dataGridViewColumn3.HeaderText = "FULL NAME";
            this.dataGridViewColumn3.MinimumWidth = 6;
            this.dataGridViewColumn3.Name = "dataGridViewColumn3";
            this.dataGridViewColumn3.ReadOnly = true;
            this.dataGridViewColumn3.Width = 200;
            // 
            // dataGridViewColumn4
            // 
            this.dataGridViewColumn4.HeaderText = "CNP";
            this.dataGridViewColumn4.MinimumWidth = 6;
            this.dataGridViewColumn4.Name = "dataGridViewColumn4";
            this.dataGridViewColumn4.ReadOnly = true;
            this.dataGridViewColumn4.Width = 200;
            // 
            // dataGridViewColumn5
            // 
            this.dataGridViewColumn5.HeaderText = "ROLE";
            this.dataGridViewColumn5.MinimumWidth = 6;
            this.dataGridViewColumn5.Name = "dataGridViewColumn5";
            this.dataGridViewColumn5.ReadOnly = true;
            this.dataGridViewColumn5.Width = 125;
            // 
            // dataGridViewColumn6
            // 
            this.dataGridViewColumn6.HeaderText = "EMAIL";
            this.dataGridViewColumn6.MinimumWidth = 6;
            this.dataGridViewColumn6.Name = "dataGridViewColumn6";
            this.dataGridViewColumn6.ReadOnly = true;
            this.dataGridViewColumn6.Width = 250;
            // 
            // dataGridViewColumn7
            // 
            this.dataGridViewColumn7.HeaderText = "PHONE";
            this.dataGridViewColumn7.MinimumWidth = 6;
            this.dataGridViewColumn7.Name = "dataGridViewColumn7";
            this.dataGridViewColumn7.ReadOnly = true;
            this.dataGridViewColumn7.Width = 200;
            // 
            // dataGridViewColumn8
            // 
            this.dataGridViewColumn8.HeaderText = "PROFILE";
            this.dataGridViewColumn8.MinimumWidth = 6;
            this.dataGridViewColumn8.Name = "dataGridViewColumn8";
            this.dataGridViewColumn8.ReadOnly = true;
            this.dataGridViewColumn8.Width = 150;
            // 
            // dataGridViewColumn9
            // 
            this.dataGridViewColumn9.HeaderText = "YEAR";
            this.dataGridViewColumn9.MinimumWidth = 6;
            this.dataGridViewColumn9.Name = "dataGridViewColumn9";
            this.dataGridViewColumn9.ReadOnly = true;
            this.dataGridViewColumn9.Width = 50;
            // 
            // dataGridViewColumn10
            // 
            this.dataGridViewColumn10.HeaderText = "DATE CREATED";
            this.dataGridViewColumn10.MinimumWidth = 6;
            this.dataGridViewColumn10.Name = "dataGridViewColumn10";
            this.dataGridViewColumn10.ReadOnly = true;
            this.dataGridViewColumn10.Width = 200;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "DEL.";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 40;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "ED.";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Width = 40;
      
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.splitcontainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TopMost = true;
            this.MaximumSizeChanged += new System.EventHandler(this.Dashboard_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.Resize += new System.EventHandler(this.Dashboard_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel1)).EndInit();
            this.splitcontainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer.Panel2)).EndInit();
            this.splitcontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).EndInit();
            this.splitcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide.Panel1)).EndInit();
            this.splitcontainerLeftSide.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide.Panel2)).EndInit();
            this.splitcontainerLeftSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerLeftSide)).EndInit();
            this.splitcontainerLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAdmin)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).EndInit();
            this.navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateUser)).EndInit();
            this.pageCreateUser.ResumeLayout(false);
            this.pageCreateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageUserList)).EndInit();
            this.pageUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPageUserList)).EndInit();
            this.splitContainerPageUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageCourseList)).EndInit();
            this.pageCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCourseList)).EndInit();
            this.splitContainerCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEditUser)).EndInit();
            this.pageEditUser.ResumeLayout(false);
            this.pageEditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateCourse)).EndInit();
            this.pageCreateCourse.ResumeLayout(false);
            this.pageCreateCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNoteList)).EndInit();
            this.pageNoteList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage.Panel1)).EndInit();
            this.splitContainerAddNotePage.Panel1.ResumeLayout(false);
            this.splitContainerAddNotePage.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddNotePage)).EndInit();
            this.splitContainerAddNotePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageAddNote)).EndInit();
            this.pageAddNote.ResumeLayout(false);
            this.pageAddNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoteTypeAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCourseAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNameAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitcontainer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelWelcome;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel labelPersonName;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette paletteRolePanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator navigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageCreateUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsernameCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu profilesContextMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand selectProfileCalculatoare;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand selectProfileContabilitate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPasswordCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPersonSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFullNameCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmailCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPhoneCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxUsernameCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxPasswordCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxFullNameCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderPersonSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxEmailCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxPhoneCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRoleSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderProfileYearSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderRoleSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnStudentCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnYearCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnAdminCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton droBtnProfilesCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileSectionCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreate;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageUserList;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerPageUserList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnpCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textboxCnpCreate;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEditUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnpEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxCnpEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderPersonSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderAccountSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAccountSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnYearEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsernameEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton droBtnProfilesEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPasswordEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPersonSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFullnameEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnAdminEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmailEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPhoneEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnStudentEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxUsernameEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderRoleSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxPasswordEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRoleSectionEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxFullNameEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxEmailEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxPhoneEdit;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageCourseList;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSectionSemesterCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTeacherNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxTeacherNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseInfoSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnYearCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton droBtnProfilesCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAbvrCourseCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radBtnColocviuCourseType;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radbtnExamenCourseType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxCourseNameCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourseTypeSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxAbvrCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnSemesterCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerCourseList;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblExaminationModeSectionCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnCreditCreateCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCreditSectionCreateUser;
        private System.Windows.Forms.CheckBox togBtnWrittenCreateCourse;
        private System.Windows.Forms.CheckBox togBtnOralCreateCourse;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageNoteList;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerAddNotePage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxSearchAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelSearchAddNote;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYearValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfileValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnpValueAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCnp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStudentSection;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBtnAddNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNoteTypeAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCourseAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNameAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddInAddNote;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNotes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProfiles;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitcontainerLeftSide;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge7;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewColumn dataGridViewColumn1;
        private DataGridViewColumn dataGridViewColumn2;
        private DataGridViewColumn dataGridViewColumn3;
        private DataGridViewColumn dataGridViewColumn4;
        private DataGridViewColumn dataGridViewColumn5;
        private DataGridViewColumn dataGridViewColumn6;
        private DataGridViewColumn dataGridViewColumn7;
        private DataGridViewColumn dataGridViewColumn8;
        private DataGridViewColumn dataGridViewColumn9;
        private DataGridViewColumn dataGridViewColumn10;
    }
}