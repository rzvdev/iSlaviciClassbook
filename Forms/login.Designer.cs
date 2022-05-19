namespace classbook
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.checkbuttonRemember = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelConnectionStatusPicture = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.labelConnection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textboxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textboxUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblVersion);
            this.panelLogin.Controls.Add(this.checkbuttonRemember);
            this.panelLogin.Controls.Add(this.kryptonLabel1);
            this.panelLogin.Controls.Add(this.labelConnectionStatusPicture);
            this.panelLogin.Controls.Add(this.labelConnection);
            this.panelLogin.Controls.Add(this.textboxPassword);
            this.panelLogin.Controls.Add(this.textboxUsername);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.panelLogin.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.panelLogin.Size = new System.Drawing.Size(367, 192);
            this.panelLogin.TabIndex = 0;
            // 
            // checkbuttonRemember
            // 
            this.checkbuttonRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbuttonRemember.Location = new System.Drawing.Point(159, 110);
            this.checkbuttonRemember.Name = "checkbuttonRemember";
            this.checkbuttonRemember.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.checkbuttonRemember.Size = new System.Drawing.Size(17, 17);
            this.checkbuttonRemember.TabIndex = 7;
            this.checkbuttonRemember.Values.Text = "";
            this.checkbuttonRemember.Click += new System.EventHandler(this.CheckbuttonRemember_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(83, 110);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Remember";
            // 
            // labelConnectionStatusPicture
            // 
            this.labelConnectionStatusPicture.AutoSize = false;
            this.labelConnectionStatusPicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelConnectionStatusPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.labelConnectionStatusPicture.Image = global::iSlavici.Properties.Resources.offline_24px;
            this.labelConnectionStatusPicture.Location = new System.Drawing.Point(230, 12);
            this.labelConnectionStatusPicture.Name = "labelConnectionStatusPicture";
            this.labelConnectionStatusPicture.Size = new System.Drawing.Size(21, 20);
            // 
            // labelConnection
            // 
            this.labelConnection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.labelConnection.Location = new System.Drawing.Point(125, 12);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.labelConnection.Size = new System.Drawing.Size(113, 20);
            this.labelConnection.TabIndex = 5;
            this.labelConnection.Values.Text = "Connection Status:";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(159, 84);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '●';
            this.textboxPassword.Size = new System.Drawing.Size(123, 23);
            this.textboxPassword.TabIndex = 4;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(159, 58);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(123, 23);
            this.textboxUsername.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogin.Location = new System.Drawing.Point(138, 155);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.buttonLogin.Size = new System.Drawing.Size(90, 25);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Values.Text = "LOGIN";
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.labelPassword.Location = new System.Drawing.Point(88, 84);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.labelPassword.Size = new System.Drawing.Size(65, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Values.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.labelUsername.Location = new System.Drawing.Point(85, 58);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.labelUsername.Size = new System.Drawing.Size(68, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Values.Text = "Username:";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.lblVersion.Location = new System.Drawing.Point(1, 165);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblVersion.Size = new System.Drawing.Size(58, 26);
            this.lblVersion.TabIndex = 38;
            this.lblVersion.Values.Text = "v1.0.0.1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 192);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iSlavici Classbook";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelLogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textboxPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textboxUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelConnection;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel labelConnectionStatusPicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkbuttonRemember;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVersion;
    }
}

