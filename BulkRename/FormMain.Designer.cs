namespace BulkRename {
    partial class FormMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstFiles = new System.Windows.Forms.ListView();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDesel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.CheckBoxes = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 27);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(366, 394);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(390, 24);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuSelect
            // 
            this.mnuSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelAll,
            this.mnuDesel,
            this.mnuInvSel});
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(67, 20);
            this.mnuSelect.Text = "Selection";
            // 
            // mnuSelAll
            // 
            this.mnuSelAll.Name = "mnuSelAll";
            this.mnuSelAll.Size = new System.Drawing.Size(155, 22);
            this.mnuSelAll.Text = "Select All";
            this.mnuSelAll.Click += new System.EventHandler(this.mnuSelAll_Click);
            // 
            // mnuDesel
            // 
            this.mnuDesel.Name = "mnuDesel";
            this.mnuDesel.Size = new System.Drawing.Size(155, 22);
            this.mnuDesel.Text = "Deselect All";
            this.mnuDesel.Click += new System.EventHandler(this.mnuDesel_Click);
            // 
            // mnuInvSel
            // 
            this.mnuInvSel.Name = "mnuInvSel";
            this.mnuInvSel.Size = new System.Drawing.Size(155, 22);
            this.mnuInvSel.Text = "Invert Selection";
            this.mnuInvSel.Click += new System.EventHandler(this.mnuInvSel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 433);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "FormMain";
            this.Text = "Bulk Rename Utility";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuSelAll;
        private System.Windows.Forms.ToolStripMenuItem mnuDesel;
        private System.Windows.Forms.ToolStripMenuItem mnuInvSel;
    }
}

