namespace BTPTT.Forms.ProgramSemesterForms
{
    partial class frmProgramSemesterSubject
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
            this.dataGridViewTeacherSubjects = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsedit = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSemesters = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSubjects)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(545, 32);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewTeacherSubjects
            // 
            this.dataGridViewTeacherSubjects.AllowUserToAddRows = false;
            this.dataGridViewTeacherSubjects.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewTeacherSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherSubjects.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewTeacherSubjects.Location = new System.Drawing.Point(380, 132);
            this.dataGridViewTeacherSubjects.MultiSelect = false;
            this.dataGridViewTeacherSubjects.Name = "dataGridViewTeacherSubjects";
            this.dataGridViewTeacherSubjects.ReadOnly = true;
            this.dataGridViewTeacherSubjects.RowHeadersVisible = false;
            this.dataGridViewTeacherSubjects.RowHeadersWidth = 56;
            this.dataGridViewTeacherSubjects.RowTemplate.Height = 24;
            this.dataGridViewTeacherSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeacherSubjects.Size = new System.Drawing.Size(557, 391);
            this.dataGridViewTeacherSubjects.TabIndex = 23;
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
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 466);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Semester Subject Registration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Location = new System.Drawing.Point(12, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 65);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subject Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(7, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(287, 30);
            this.txtTitle.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbSubjects);
            this.groupBox5.Location = new System.Drawing.Point(12, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 71);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Subject";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(6, 27);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(288, 30);
            this.cmbSubjects.TabIndex = 11;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSemesters);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Semester";
            // 
            // cmbSemesters
            // 
            this.cmbSemesters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSemesters.FormattingEnabled = true;
            this.cmbSemesters.Location = new System.Drawing.Point(6, 21);
            this.cmbSemesters.Name = "cmbSemesters";
            this.cmbSemesters.Size = new System.Drawing.Size(288, 30);
            this.cmbSemesters.TabIndex = 10;
            this.cmbSemesters.SelectedIndexChanged += new System.EventHandler(this.cmbSemesters_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(101, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSearch);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(380, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(557, 69);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search";
            // 
            // frmProgramSemesterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(987, 580);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridViewTeacherSubjects);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgramSemesterSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Semester Subject";
            this.Load += new System.EventHandler(this.frmProgramSemesterSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSubjects)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.cmsOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewTeacherSubjects;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSemesters;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripTextBox cmsedit;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}