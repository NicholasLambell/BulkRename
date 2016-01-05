namespace BulkRename {
    partial class FormFilters {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvFilters = new System.Windows.Forms.DataGridView();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chklstComFilters = new System.Windows.Forms.CheckedListBox();
            this.lblCommonFilter = new System.Windows.Forms.Label();
            this.lblCustFilters = new System.Windows.Forms.Label();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilters)).BeginInit();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvFilters
            // 
            this.gvFilters.AllowUserToResizeColumns = false;
            this.gvFilters.AllowUserToResizeRows = false;
            this.gvFilters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFilters.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvFilters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFilters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Input,
            this.Output});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFilters.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFilters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvFilters.Location = new System.Drawing.Point(3, 128);
            this.gvFilters.MultiSelect = false;
            this.gvFilters.Name = "gvFilters";
            this.gvFilters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvFilters.RowHeadersVisible = false;
            this.gvFilters.Size = new System.Drawing.Size(338, 271);
            this.gvFilters.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.HeaderText = "Input";
            this.Input.Name = "Input";
            // 
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.Name = "Output";
            // 
            // chklstComFilters
            // 
            this.chklstComFilters.CheckOnClick = true;
            this.chklstComFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstComFilters.FormattingEnabled = true;
            this.chklstComFilters.Items.AddRange(new object[] {
            "Replace period between words with space.",
            "Capitalize key words. eg. Movie Titles."});
            this.chklstComFilters.Location = new System.Drawing.Point(3, 16);
            this.chklstComFilters.Name = "chklstComFilters";
            this.chklstComFilters.Size = new System.Drawing.Size(338, 86);
            this.chklstComFilters.TabIndex = 1;
            // 
            // lblCommonFilter
            // 
            this.lblCommonFilter.AutoSize = true;
            this.lblCommonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonFilter.Location = new System.Drawing.Point(3, 0);
            this.lblCommonFilter.Name = "lblCommonFilter";
            this.lblCommonFilter.Size = new System.Drawing.Size(81, 13);
            this.lblCommonFilter.TabIndex = 2;
            this.lblCommonFilter.Text = "Common Filters:";
            // 
            // lblCustFilters
            // 
            this.lblCustFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustFilters.AutoSize = true;
            this.lblCustFilters.Location = new System.Drawing.Point(3, 112);
            this.lblCustFilters.Name = "lblCustFilters";
            this.lblCustFilters.Size = new System.Drawing.Size(338, 13);
            this.lblCustFilters.TabIndex = 3;
            this.lblCustFilters.Text = "Custom Filters:";
            // 
            // tblLayout
            // 
            this.tblLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.lblCommonFilter, 0, 0);
            this.tblLayout.Controls.Add(this.gvFilters, 0, 3);
            this.tblLayout.Controls.Add(this.chklstComFilters, 0, 1);
            this.tblLayout.Controls.Add(this.lblCustFilters, 0, 2);
            this.tblLayout.Location = new System.Drawing.Point(12, 12);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 4;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLayout.Size = new System.Drawing.Size(341, 402);
            this.tblLayout.TabIndex = 4;
            // 
            // FormFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 426);
            this.Controls.Add(this.tblLayout);
            this.MinimumSize = new System.Drawing.Size(381, 465);
            this.Name = "FormFilters";
            this.Text = "Filters";
            ((System.ComponentModel.ISupportInitialize)(this.gvFilters)).EndInit();
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.CheckedListBox chklstComFilters;
        private System.Windows.Forms.Label lblCommonFilter;
        private System.Windows.Forms.Label lblCustFilters;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
    }
}