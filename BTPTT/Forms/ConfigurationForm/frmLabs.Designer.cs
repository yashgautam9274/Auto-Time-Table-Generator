namespace BTPTT.Forms.ConfigurationForm
{
    partial class frmLabs
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewLab = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsedit = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLabNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(446, 32);
            this.txtSearch.TabIndex = 19;
            // 
            // dataGridViewLab
            // 
            this.dataGridViewLab.AllowUserToAddRows = false;
            this.dataGridViewLab.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLab.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewLab.Location = new System.Drawing.Point(323, 121);
            this.dataGridViewLab.MultiSelect = false;
            this.dataGridViewLab.Name = "dataGridViewLab";
            this.dataGridViewLab.ReadOnly = true;
            this.dataGridViewLab.RowHeadersVisible = false;
            this.dataGridViewLab.RowHeadersWidth = 56;
            this.dataGridViewLab.RowTemplate.Height = 24;
            this.dataGridViewLab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLab.Size = new System.Drawing.Size(458, 299);
            this.dataGridViewLab.TabIndex = 18;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsedit});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(161, 35);
            // 
            // cmsedit
            // 
            this.cmsedit.Font = new System.Drawing.Font("Segoe UI", 8.861538F);
            this.cmsedit.Name = "cmsedit";
            this.cmsedit.Size = new System.Drawing.Size(100, 29);
            this.cmsedit.Text = "Edit";
            this.cmsedit.Click += new System.EventHandler(this.cmsedit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.chkStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 376);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Enter Lab Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCapacity);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 76);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lab Capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(12, 31);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(232, 32);
            this.txtCapacity.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLabNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lab No";
            // 
            // txtLabNo
            // 
            this.txtLabNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabNo.Location = new System.Drawing.Point(6, 31);
            this.txtLabNo.Name = "txtLabNo";
            this.txtLabNo.Size = new System.Drawing.Size(238, 32);
            this.txtLabNo.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(65, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(65, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(166, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Location = new System.Drawing.Point(12, 247);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(138, 30);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Lab Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSearch);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(323, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 69);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // frmLabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(825, 509);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridViewLab);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLabs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabs";
            this.Load += new System.EventHandler(this.frmLabs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.cmsOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewLab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripTextBox cmsedit;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLabNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}