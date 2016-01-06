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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvFilters = new System.Windows.Forms.DataGridView();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chklstComFilters = new System.Windows.Forms.CheckedListBox();
            this.lblCommonFilter = new System.Windows.Forms.Label();
            this.lblCustFilters = new System.Windows.Forms.Label();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilters)).BeginInit();
            this.tblLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFilters.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFilters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvFilters.Location = new System.Drawing.Point(3, 121);
            this.gvFilters.MultiSelect = false;
            this.gvFilters.Name = "gvFilters";
            this.gvFilters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvFilters.RowHeadersVisible = false;
            this.gvFilters.Size = new System.Drawing.Size(338, 249);
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
            "Capitalize every word in file name.",
            "Capitalize key words. eg. Movie Titles."});
            this.chklstComFilters.Location = new System.Drawing.Point(3, 16);
            this.chklstComFilters.Name = "chklstComFilters";
            this.chklstComFilters.Size = new System.Drawing.Size(338, 79);
            this.chklstComFilters.TabIndex = 1;
            // 
            // lblCommonFilter
            // 
            this.lblCommonFilter.AutoSize = true;
            this.lblCommonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonFilter.Location = new System.Drawing.Point(0, 0);
            this.lblCommonFilter.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
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
            this.lblCustFilters.Location = new System.Drawing.Point(0, 105);
            this.lblCustFilters.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCustFilters.Name = "lblCustFilters";
            this.lblCustFilters.Size = new System.Drawing.Size(341, 13);
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
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.Controls.Add(this.lblCommonFilter, 0, 0);
            this.tblLayout.Controls.Add(this.gvFilters, 0, 3);
            this.tblLayout.Controls.Add(this.chklstComFilters, 0, 1);
            this.tblLayout.Controls.Add(this.lblCustFilters, 0, 2);
            this.tblLayout.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tblLayout.Location = new System.Drawing.Point(12, 12);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 5;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayout.Size = new System.Drawing.Size(344, 402);
            this.tblLayout.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(182, 373);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(84, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 426);
            this.ControlBox = false;
            this.Controls.Add(this.tblLayout);
            this.MinimumSize = new System.Drawing.Size(384, 465);
            this.Name = "FormFilters";
            this.ShowIcon = false;
            this.Text = "Filters";
            ((System.ComponentModel.ISupportInitialize)(this.gvFilters)).EndInit();
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}