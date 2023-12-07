namespace BTPTT.Forms.TimeSlotsForms
{
    partial class frmDayTimeSlots
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
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsedit = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbNoofTimeSlot = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(458, 32);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.AllowUserToAddRows = false;
            this.dataGridViewSlots.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlots.ContextMenuStrip = this.cmsOptions;
            this.dataGridViewSlots.Location = new System.Drawing.Point(367, 126);
            this.dataGridViewSlots.MultiSelect = false;
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.ReadOnly = true;
            this.dataGridViewSlots.RowHeadersVisible = false;
            this.dataGridViewSlots.RowHeadersWidth = 56;
            this.dataGridViewSlots.RowTemplate.Height = 24;
            this.dataGridViewSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlots.Size = new System.Drawing.Size(477, 425);
            this.dataGridViewSlots.TabIndex = 14;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.chkStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 514);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Slot Per Day";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbNoofTimeSlot);
            this.groupBox5.Location = new System.Drawing.Point(9, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 70);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Enter no of Time Slots";
            // 
            // cmbNoofTimeSlot
            // 
            this.cmbNoofTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoofTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNoofTimeSlot.FormattingEnabled = true;
            this.cmbNoofTimeSlot.Location = new System.Drawing.Point(11, 30);
            this.cmbNoofTimeSlot.Name = "cmbNoofTimeSlot";
            this.cmbNoofTimeSlot.Size = new System.Drawing.Size(278, 34);
            this.cmbNoofTimeSlot.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpEndTime);
            this.groupBox4.Location = new System.Drawing.Point(9, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 67);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(11, 31);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(278, 30);
            this.dtpEndTime.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpStartTime);
            this.groupBox3.Location = new System.Drawing.Point(8, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 67);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Time";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(12, 31);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(278, 30);
            this.dtpStartTime.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDays);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Day";
            // 
            // cmbDays
            // 
            this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(11, 25);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(278, 34);
            this.cmbDays.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(74, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(74, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(9, 394);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(140, 30);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Slot Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSearch);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(367, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(477, 78);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search";
            // 
            // frmDayTimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(902, 601);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridViewSlots);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmDayTimeSlots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Time Slots";
            this.Load += new System.EventHandler(this.frmDayTimeSlots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.cmsOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbNoofTimeSlot;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripTextBox cmsedit;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}