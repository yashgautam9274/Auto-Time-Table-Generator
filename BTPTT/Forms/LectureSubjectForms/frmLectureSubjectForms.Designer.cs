namespace BTPTT.Forms.LectureSubjectForms
{
    partial class frmLectureSubjectForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTeacherSubjects = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSubjects)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(468, 32);
            this.txtSearch.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, -32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search";
            // 
            // dataGridViewTeacherSubjects
            // 
            this.dataGridViewTeacherSubjects.AllowUserToAddRows = false;
            this.dataGridViewTeacherSubjects.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewTeacherSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherSubjects.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewTeacherSubjects.Location = new System.Drawing.Point(360, 142);
            this.dataGridViewTeacherSubjects.MultiSelect = false;
            this.dataGridViewTeacherSubjects.Name = "dataGridViewTeacherSubjects";
            this.dataGridViewTeacherSubjects.ReadOnly = true;
            this.dataGridViewTeacherSubjects.RowHeadersVisible = false;
            this.dataGridViewTeacherSubjects.RowHeadersWidth = 56;
            this.dataGridViewTeacherSubjects.RowTemplate.Height = 24;
            this.dataGridViewTeacherSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeacherSubjects.Size = new System.Drawing.Size(480, 343);
            this.dataGridViewTeacherSubjects.TabIndex = 18;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(180, 30);
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.activeToolStripMenuItem.Text = "Status Change";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.chkStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 416);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lectures Subject";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbSubjects);
            this.groupBox5.Location = new System.Drawing.Point(9, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 69);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Subject";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(6, 29);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(278, 34);
            this.cmbSubjects.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTeachers);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Professor";
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(6, 29);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(278, 34);
            this.cmbTeachers.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(9, 237);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(96, 30);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(360, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 69);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // frmLectureSubjectForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(906, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTeacherSubjects);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLectureSubjectForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Subject Form";
            this.Load += new System.EventHandler(this.frmLectureSubjectForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSubjects)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTeacherSubjects;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}