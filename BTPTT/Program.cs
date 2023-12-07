using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTPTT.Forms;
using BTPTT.Forms.ConfigurationForm;
using BTPTT.Forms.LectureSubjectForms;
using BTPTT.Forms.ProgramSemesterForms;
using BTPTT.Forms.TimeSlotsForms;

namespace BTPTT
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread] 
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new  frmProgramSemesters());
			//Application.Run(new frmCourses());
			//Application.Run(new frmDayTimeSlots());
			//Application.Run(new frmLectureSubjectForms());
			//Application.Run(new frmProgramSemesterSubject());
			//Application.Run(new frmSemesterSections());
			//Application.Run(new frmLabs());
			//Application.Run(new frmProgramSemesters());
			//Application.Run(new frmGenerateTimeTables());
			//Application.Run(new frmlectures());
			//Application.Run(new frmRooms());
			//Application.Run(new frmDays());
			//Application.Run(new frmprogram());
			//Application.Run(new frmSemesters());
			//.Run(new frmSession());
			//Application.Run(new frmLectureSubjectForms());
			//Application.Run(new frmSemesterSections());
			//Application.Run(new frmDays());
			//Application.Run(new frmLabs());
			Application.Run(new HomeForm());
		}
	}
}
