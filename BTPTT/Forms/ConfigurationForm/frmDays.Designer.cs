namespace BTPTT.Forms.ConfigurationForm
{
    partial class frmDays
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDayname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.dataGridViewDay = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsedit = new System.Windows.Forms.ToolStripTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDay)).BeginInit();
            this.cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.chkStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 359);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Enter Day";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDayname);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day Name";
            // 
            // txtDayname
            // 
            this.txtDayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayname.Location = new System.Drawing.Point(12, 31);
            this.txtDayname.Name = "txtDayname";
            this.txtDayname.Size = new System.Drawing.Size(226, 32);
            this.txtDayname.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(52, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(54, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 43);
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
            this.chkStatus.Location = new System.Drawing.Point(9, 153);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(141, 30);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Day Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDay
            // 
            this.dataGridViewDay.AllowUserToAddRows = false;
            this.dataGridViewDay.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDay.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewDay.Location = new System.Drawing.Point(317, 125);
            this.dataGridViewDay.MultiSelect = false;
            this.dataGridViewDay.Name = "dataGridViewDay";
            this.dataGridViewDay.ReadOnly = true;
            this.dataGridViewDay.RowHeadersVisible = false;
            this.dataGridViewDay.RowHeadersWidth = 56;
            this.dataGridViewDay.RowTemplate.Height = 24;
            this.dataGridViewDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDay.Size = new System.Drawing.Size(469, 284);
            this.dataGridViewDay.TabIndex = 12;
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(452, 32);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSearch);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(317, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 69);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // frmDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridViewDay);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Days";
            this.Load += new System.EventHandler(this.frmDays_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDay)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.cmsOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDayname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridView dataGridViewDay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripTextBox cmsedit;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}