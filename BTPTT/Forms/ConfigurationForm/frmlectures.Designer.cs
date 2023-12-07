namespace BTPTT.Forms.ConfigurationForm
{
    partial class frmlectures
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
            this.dataGridViewLecturer = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsedit = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).BeginInit();
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewLecturer
            // 
            this.dataGridViewLecturer.AllowUserToAddRows = false;
            this.dataGridViewLecturer.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturer.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewLecturer.Location = new System.Drawing.Point(326, 112);
            this.dataGridViewLecturer.MultiSelect = false;
            this.dataGridViewLecturer.Name = "dataGridViewLecturer";
            this.dataGridViewLecturer.ReadOnly = true;
            this.dataGridViewLecturer.RowHeadersVisible = false;
            this.dataGridViewLecturer.RowHeadersWidth = 56;
            this.dataGridViewLecturer.RowTemplate.Height = 24;
            this.dataGridViewLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLecturer.Size = new System.Drawing.Size(458, 300);
            this.dataGridViewLecturer.TabIndex = 18;
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
            this.groupBox2.Location = new System.Drawing.Point(21, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 375);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Enter Lecturer Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtContactNo);
            this.groupBox3.Location = new System.Drawing.Point(10, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(12, 28);
            this.txtContactNo.Mask = "0000-000000";
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(245, 32);
            this.txtContactNo.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLecturerName);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer FullName";
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturerName.Location = new System.Drawing.Point(12, 31);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(245, 32);
            this.txtLecturerName.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(80, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(80, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 43);
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
            this.chkStatus.Location = new System.Drawing.Point(10, 229);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(181, 30);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Lecturer Status";
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
            this.groupBox5.Location = new System.Drawing.Point(326, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 69);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // frmlectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(812, 479);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridViewLecturer);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlectures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectures";
            this.Load += new System.EventHandler(this.frmlectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewLecturer;
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
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtContactNo;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}