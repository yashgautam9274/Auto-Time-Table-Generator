namespace BTPTT.Forms
{
    partial class HomeForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSubjectsToLectureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSemesterSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSemesterToProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSubjectToSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayTimeSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rintAllTimeTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllTeacherTimeTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllDaysWiseTimeTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripButton5,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 61);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::BTPTT.Properties.Resources.programicon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 57);
            this.toolStripButton1.Text = "Program";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::BTPTT.Properties.Resources.sessionicon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(67, 57);
            this.toolStripButton2.Text = "Session";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::BTPTT.Properties.Resources.subjecticon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(72, 57);
            this.toolStripButton3.Text = "Subjects";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLecturerToolStripMenuItem,
            this.assignSubjectsToLectureToolStripMenuItem});
            this.toolStripButton4.Image = global::BTPTT.Properties.Resources.teachericon;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(85, 57);
            this.toolStripButton4.Text = "Lectures";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newLecturerToolStripMenuItem
            // 
            this.newLecturerToolStripMenuItem.Name = "newLecturerToolStripMenuItem";
            this.newLecturerToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.newLecturerToolStripMenuItem.Text = "New Lecturer";
            this.newLecturerToolStripMenuItem.Click += new System.EventHandler(this.newLecturerToolStripMenuItem_Click);
            // 
            // assignSubjectsToLectureToolStripMenuItem
            // 
            this.assignSubjectsToLectureToolStripMenuItem.Name = "assignSubjectsToLectureToolStripMenuItem";
            this.assignSubjectsToLectureToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.assignSubjectsToLectureToolStripMenuItem.Text = "Assign Subjects to Lecture";
            this.assignSubjectsToLectureToolStripMenuItem.Click += new System.EventHandler(this.assignSubjectsToLectureToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.addLabToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::BTPTT.Properties.Resources.roomsicon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(122, 57);
            this.toolStripDropDownButton1.Text = "Room\'s/Lab\'s";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.addRoomToolStripMenuItem.Text = "Add Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // addLabToolStripMenuItem
            // 
            this.addLabToolStripMenuItem.Name = "addLabToolStripMenuItem";
            this.addLabToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.addLabToolStripMenuItem.Text = "Add Lab";
            this.addLabToolStripMenuItem.Click += new System.EventHandler(this.addLabToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSemesterToolStripMenuItem,
            this.addSemesterSectionsToolStripMenuItem,
            this.assignSemesterToProgramToolStripMenuItem,
            this.assignSubjectToSemesterToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::BTPTT.Properties.Resources.semestericon;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(92, 57);
            this.toolStripDropDownButton2.Text = "Semester";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addSemesterToolStripMenuItem
            // 
            this.addSemesterToolStripMenuItem.Name = "addSemesterToolStripMenuItem";
            this.addSemesterToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.addSemesterToolStripMenuItem.Text = "New Semester";
            this.addSemesterToolStripMenuItem.Click += new System.EventHandler(this.addSemesterToolStripMenuItem_Click);
            // 
            // addSemesterSectionsToolStripMenuItem
            // 
            this.addSemesterSectionsToolStripMenuItem.Name = "addSemesterSectionsToolStripMenuItem";
            this.addSemesterSectionsToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.addSemesterSectionsToolStripMenuItem.Text = "Add Semester Sections";
            this.addSemesterSectionsToolStripMenuItem.Click += new System.EventHandler(this.addSemesterSectionsToolStripMenuItem_Click);
            // 
            // assignSemesterToProgramToolStripMenuItem
            // 
            this.assignSemesterToProgramToolStripMenuItem.Name = "assignSemesterToProgramToolStripMenuItem";
            this.assignSemesterToProgramToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.assignSemesterToProgramToolStripMenuItem.Text = "Assign Semester to Program";
            this.assignSemesterToProgramToolStripMenuItem.Click += new System.EventHandler(this.assignSemesterToProgramToolStripMenuItem_Click);
            // 
            // assignSubjectToSemesterToolStripMenuItem
            // 
            this.assignSubjectToSemesterToolStripMenuItem.Name = "assignSubjectToSemesterToolStripMenuItem";
            this.assignSubjectToSemesterToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.assignSubjectToSemesterToolStripMenuItem.Text = "Assign Subject to Semester";
            this.assignSubjectToSemesterToolStripMenuItem.Click += new System.EventHandler(this.assignSubjectToSemesterToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDaysToolStripMenuItem,
            this.dayTimeSlotToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::BTPTT.Properties.Resources.daysicon;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(61, 57);
            this.toolStripDropDownButton3.Text = "Days";
            this.toolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addDaysToolStripMenuItem
            // 
            this.addDaysToolStripMenuItem.Name = "addDaysToolStripMenuItem";
            this.addDaysToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.addDaysToolStripMenuItem.Text = "Add Day\'s";
            this.addDaysToolStripMenuItem.Click += new System.EventHandler(this.addDaysToolStripMenuItem_Click);
            // 
            // dayTimeSlotToolStripMenuItem
            // 
            this.dayTimeSlotToolStripMenuItem.Name = "dayTimeSlotToolStripMenuItem";
            this.dayTimeSlotToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.dayTimeSlotToolStripMenuItem.Text = "Day Time Slot";
            this.dayTimeSlotToolStripMenuItem.Click += new System.EventHandler(this.dayTimeSlotToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::BTPTT.Properties.Resources.timetableicon;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(87, 57);
            this.toolStripButton5.Text = "Time Table";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rintAllTimeTablesToolStripMenuItem,
            this.printAllTeacherTimeTablesToolStripMenuItem,
            this.printAllDaysWiseTimeTablesToolStripMenuItem});
            this.toolStripDropDownButton4.Image = global::BTPTT.Properties.Resources.printsicon;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(71, 57);
            this.toolStripDropDownButton4.Text = "Print\'s";
            this.toolStripDropDownButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rintAllTimeTablesToolStripMenuItem
            // 
            this.rintAllTimeTablesToolStripMenuItem.Name = "rintAllTimeTablesToolStripMenuItem";
            this.rintAllTimeTablesToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.rintAllTimeTablesToolStripMenuItem.Text = "Print All Time Tables";
            this.rintAllTimeTablesToolStripMenuItem.Click += new System.EventHandler(this.rintAllTimeTablesToolStripMenuItem_Click);
            // 
            // printAllTeacherTimeTablesToolStripMenuItem
            // 
            this.printAllTeacherTimeTablesToolStripMenuItem.Name = "printAllTeacherTimeTablesToolStripMenuItem";
            this.printAllTeacherTimeTablesToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.printAllTeacherTimeTablesToolStripMenuItem.Text = "Print All Teacher Time Tables";
            this.printAllTeacherTimeTablesToolStripMenuItem.Click += new System.EventHandler(this.printAllTeacherTimeTablesToolStripMenuItem_Click);
            // 
            // printAllDaysWiseTimeTablesToolStripMenuItem
            // 
            this.printAllDaysWiseTimeTablesToolStripMenuItem.Name = "printAllDaysWiseTimeTablesToolStripMenuItem";
            this.printAllDaysWiseTimeTablesToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.printAllDaysWiseTimeTablesToolStripMenuItem.Text = "Print All Days Wise Time Tables";
            this.printAllDaysWiseTimeTablesToolStripMenuItem.Click += new System.EventHandler(this.printAllDaysWiseTimeTablesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 28);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 21);
            this.toolStripStatusLabel1.Text = "Ready --";
            // 
            // tsslblDateTime
            // 
            this.tsslblDateTime.Name = "tsslblDateTime";
            this.tsslblDateTime.Size = new System.Drawing.Size(858, 21);
            this.tsslblDateTime.Spring = true;
            this.tsslblDateTime.Text = "toolStripStatusLabel2";
            this.tsslblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::BTPTT.Properties.Resources.timetablebackgournd;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 61);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(942, 569);
            this.panelHeader.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yash Gautam\r\n2001CS78";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "TimeTable\r\nGenerator";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 658);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDateTime;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem newLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSubjectsToLectureToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem addSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSemesterSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSemesterToProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSubjectToSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem addDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayTimeSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem rintAllTimeTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllTeacherTimeTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllDaysWiseTimeTablesToolStripMenuItem;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}