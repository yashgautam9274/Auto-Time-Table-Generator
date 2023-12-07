using BTPTT.Forms.ConfigurationForm;
using BTPTT.Forms.ProgramSemesterForms;
using BTPTT.Forms.TimeSlotsForms;
using BTPTT.Forms.LectureSubjectForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTPTT.Forms
{
    public partial class HomeForm : Form
    {
        frmCourses CoursesForm;
        frmDays DaysForm;
        frmLabs LabsForm;
        frmlectures LecturesForm;
        frmprogram ProgramForm;
        frmRooms RoomForm;
        frmSemesters SemestersForm;
        frmSession SessionForm;
        frmLectureSubjectForms LecturesSubjectForm;
        frmProgramSemesters ProgramSemestersForm;
        frmProgramSemesterSubject ProgramSemesterSubjectForm;
        frmDayTimeSlots DayTimeSlotsForm;
        frmSemesterSections SemesterSectionsForm;
        frmGenerateTimeTables AutoGenerateTimeTableForm;
        public HomeForm()
        {
            InitializeComponent();
            tsslblDateTime.Text = DateTime.Now.ToString("dd MMM yyyy");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ProgramForm == null)
            {
                ProgramForm = new frmprogram();
            }
            ProgramForm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (SessionForm == null)
            {
                SessionForm = new frmSession();
            }
            SessionForm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (CoursesForm == null)
            {
                CoursesForm = new frmCourses();
            }
            CoursesForm.ShowDialog();
        }

        private void newLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LecturesForm == null)
            {
                LecturesForm = new frmlectures();
            }
            LecturesForm.ShowDialog();
        }

        private void assignSubjectsToLectureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LecturesSubjectForm == null)
            {
                LecturesSubjectForm = new frmLectureSubjectForms();
            }
            LecturesSubjectForm.ShowDialog();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RoomForm == null)
            {
                RoomForm = new frmRooms();
            }
            RoomForm.ShowDialog();
        }

        private void addLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LabsForm == null)
            {
                LabsForm = new frmLabs();
            }
            LabsForm.ShowDialog();
        }

        private void addSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SemestersForm == null)
            {
                SemestersForm = new frmSemesters();
            }
            SemestersForm.ShowDialog();
        }

        private void addSemesterSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SemesterSectionsForm == null)
            {
                SemesterSectionsForm = new frmSemesterSections();
            }
            SemesterSectionsForm.ShowDialog();
        }

        private void assignSemesterToProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProgramSemestersForm == null)
            {
                ProgramSemestersForm = new frmProgramSemesters();
            }
            ProgramSemestersForm.ShowDialog();
        }

        private void assignSubjectToSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProgramSemesterSubjectForm == null)
            {
                ProgramSemesterSubjectForm = new frmProgramSemesterSubject();
            }
            ProgramSemesterSubjectForm.ShowDialog();
        }

        private void addDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaysForm == null)
            {
                DaysForm = new frmDays();
            }
            DaysForm.ShowDialog();
        }

        private void dayTimeSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DayTimeSlotsForm == null)
            {
                DayTimeSlotsForm = new frmDayTimeSlots();
            }
            DayTimeSlotsForm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (AutoGenerateTimeTableForm == null)
            {
                AutoGenerateTimeTableForm = new frmGenerateTimeTables();
            }
            AutoGenerateTimeTableForm.ShowDialog();
        }

        private void rintAllTimeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printAllTeacherTimeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printAllDaysWiseTimeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
