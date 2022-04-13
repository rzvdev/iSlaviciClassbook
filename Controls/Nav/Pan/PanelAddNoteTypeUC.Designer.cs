namespace iSlavici.Controls.Nav.Pan
{
    partial class PanelAddNoteTypeUC
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
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNoteType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtboxNoteType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonBorderEdge2.AutoSize = false;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(186, 98);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(260, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel8.Location = new System.Drawing.Point(198, 73);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 26);
            this.kryptonLabel8.TabIndex = 162;
            this.kryptonLabel8.Values.Text = "Note";
            // 
            // lblNoteType
            // 
            this.lblNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteType.Location = new System.Drawing.Point(192, 106);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lblNoteType.Size = new System.Drawing.Size(70, 20);
            this.lblNoteType.TabIndex = 158;
            this.lblNoteType.Values.Text = "Note Type:";
            // 
            // txtboxNoteType
            // 
            this.txtboxNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxNoteType.Location = new System.Drawing.Point(268, 108);
            this.txtboxNoteType.Name = "txtboxNoteType";
            this.txtboxNoteType.Size = new System.Drawing.Size(178, 23);
            this.txtboxNoteType.TabIndex = 163;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(268, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClickEvent);
            // 
            // PanelAddNoteTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxNoteType);
            this.Controls.Add(this.kryptonBorderEdge2);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.lblNoteType);
            this.Name = "PanelAddNoteTypeUC";
            this.Size = new System.Drawing.Size(609, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoteType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtboxNoteType;
        private System.Windows.Forms.Button btnAdd;
    }
}
