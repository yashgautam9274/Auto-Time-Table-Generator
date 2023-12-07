using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTPTT.SourceCode
{
    public class ComboHelper
    {
        public static void Semesters(ComboBox cmb)
        {
            DataTable dtSemesters = new DataTable();
            dtSemesters.Columns.Add("SemesterID");
            dtSemesters.Columns.Add("SemesterName");
            dtSemesters.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select SemesterID, SemesterName from SemesterTable  where IsActive = 1");
                if(dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        foreach (DataRow semester in dt.Rows)
                        {
                            dtSemesters.Rows.Add(semester["SemesterID"], semester["SemesterName"]);
                        }
                    }
                }
                cmb.DataSource = dtSemesters;
                cmb.ValueMember = "SemesterID";
                cmb.DisplayMember = "SemesterName";
            }
            catch 
            {
                cmb.DataSource = dtSemesters;
            }
        }


        public static void Programs(ComboBox cmb)
        {
            DataTable dtProgram = new DataTable();
            dtProgram.Columns.Add("ProgramID");
            dtProgram.Columns.Add("Name");
            dtProgram.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select ProgramID, Name from ProgramTable  where IsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow program in dt.Rows)
                        {
                            dtProgram.Rows.Add(program["ProgramID"], program["Name"]);
                        }
                    }
                }
                cmb.DataSource = dtProgram;
                cmb.ValueMember = "ProgramID";
                cmb.DisplayMember = "Name";
            }
            catch
            {
                cmb.DataSource = dtProgram;
            }
        }


        public static void RoomTypes(ComboBox cmb)
        {
            DataTable dtTypes = new DataTable();
            dtTypes.Columns.Add("RoomtypeID");
            dtTypes.Columns.Add("TypeName");
            dtTypes.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select RoomtypeID, TypeName from RoomTypeTable");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow type in dt.Rows)
                        {
                            dtTypes.Rows.Add(type["RoomtypeID"], type["TypeName"]);
                        }
                    }
                }
                cmb.DataSource = dtTypes;
                cmb.ValueMember = "RoomtypeID";
                cmb.DisplayMember = "TypeName";
            }
            catch
            {
                cmb.DataSource = dtTypes;
            }
        }

        public static void AllDays(ComboBox cmb)
        {
            DataTable dtDays = new DataTable();
            dtDays.Columns.Add("DayID");
            dtDays.Columns.Add("Name");
            dtDays.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select DayID, Name from DayTable where IsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow day in dt.Rows)
                        {
                            dtDays.Rows.Add(day["DayID"], day["Name"]);
                        }
                    }
                }
                cmb.DataSource = dtDays;
                cmb.ValueMember = "DayID";
                cmb.DisplayMember = "Name";
            }
            catch
            {
                cmb.DataSource = dtDays;
            }
        }


        public static void TimeSlotsNumbers(ComboBox cmb)
        {
            DataTable dtSlots = new DataTable();
            dtSlots.Columns.Add("ID");
            dtSlots.Columns.Add("Number");
            dtSlots.Rows.Add("0", "0");
            dtSlots.Rows.Add("1", "1");
            dtSlots.Rows.Add("2", "2");
            dtSlots.Rows.Add("3", "3");
            dtSlots.Rows.Add("4", "4");
            dtSlots.Rows.Add("5", "5");

            cmb.DataSource = dtSlots;
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "Number";
        }


        public static void AllTeachres(ComboBox cmb)
        {
            DataTable dtDays = new DataTable();
            dtDays.Columns.Add("LectureID");
            dtDays.Columns.Add("FullName");
            dtDays.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select LectureID, FullName from LectureTable where IsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow day in dt.Rows)
                        {
                            dtDays.Rows.Add(day["LectureID"], day["FullName"]);
                        }
                    }
                }
                cmb.DataSource = dtDays;
                cmb.ValueMember = "LectureID";
                cmb.DisplayMember = "FullName";
            }
            catch
            {
                cmb.DataSource = dtDays;
            }
        }


        public static void AllSubjects(ComboBox cmb)
        {
            DataTable dtDays = new DataTable();
            dtDays.Columns.Add("CourseID");
            dtDays.Columns.Add("Title");
            dtDays.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select CourseID, Title from CourseTable where IsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow day in dt.Rows)
                        {
                            dtDays.Rows.Add(day["CourseID"], day["Title"]);
                        }
                    }
                }
                cmb.DataSource = dtDays;
                cmb.ValueMember = "CourseID";
                cmb.DisplayMember = "Title";
            }
            catch
            {
                cmb.DataSource = dtDays;
            }
        }



        public static void AllProgramSemester(ComboBox cmb)
        {
            DataTable dtDays = new DataTable();
            dtDays.Columns.Add("ProgramSemesterID");
            dtDays.Columns.Add("Title");
            dtDays.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select ProgramSemesterID, Title from v_ProgramSemesterActiveList where ProgramSemesterIsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow day in dt.Rows)
                        {
                            dtDays.Rows.Add(day["ProgramSemesterID"], day["Title"]);
                        }
                    }
                }
                cmb.DataSource = dtDays;
                cmb.ValueMember = "ProgramSemesterID";
                cmb.DisplayMember = "Title";
            }
            catch
            {
                cmb.DataSource = dtDays;
            }
        }



        public static void AllTeacherSubjects (ComboBox cmb)
        {
            DataTable dtDays = new DataTable();
            dtDays.Columns.Add("LectureSubjectID");
            dtDays.Columns.Add("SubjectTitle");
            dtDays.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseLayer.Retrive("select LectureSubjectID, SubjectTitle from v_AllSubjectTeachers where IsActive = 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow day in dt.Rows)
                        {
                            dtDays.Rows.Add(day["LectureSubjectID"], day["SubjectTitle"]);
                        }
                    }
                }
                cmb.DataSource = dtDays;
                cmb.ValueMember = "LectureSubjectID";
                cmb.DisplayMember = "SubjectTitle";
            }
            catch
            {
                cmb.DataSource = dtDays;
            }
        }




    }
}
