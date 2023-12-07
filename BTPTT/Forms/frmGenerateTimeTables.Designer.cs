namespace BTPTT.Forms
{
    partial class frmGenerateTimeTables
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateTimeTable = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Location = new System.Drawing.Point(100, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "ddMMMMyyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(17, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(329, 44);
            this.dtpStartDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Location = new System.Drawing.Point(100, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "ddMMMMyyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(17, 21);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(329, 44);
            this.dtpEndDate.TabIndex = 0;
            // 
            // btnGenerateTimeTable
            // 
            this.btnGenerateTimeTable.BackColor = System.Drawing.Color.Brown;
            this.btnGenerateTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTimeTable.Location = new System.Drawing.Point(100, 288);
            this.btnGenerateTimeTable.Name = "btnGenerateTimeTable";
            this.btnGenerateTimeTable.Size = new System.Drawing.Size(381, 58);
            this.btnGenerateTimeTable.TabIndex = 2;
            this.btnGenerateTimeTable.Text = "Generate Time Table";
            this.btnGenerateTimeTable.UseVisualStyleBackColor = false;
            this.btnGenerateTimeTable.Click += new System.EventHandler(this.btnGenerateTimeTable_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmGenerateTimeTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.btnGenerateTimeTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerateTimeTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate TimeTable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGenerateTimeTable;
        private System.Windows.Forms.ErrorProvider ep;
    }
}