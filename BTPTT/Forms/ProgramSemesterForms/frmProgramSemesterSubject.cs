using BTPTT.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTPTT.Forms.ProgramSemesterForms
{
    public partial class frmProgramSemesterSubject : Form
    {
        public frmProgramSemesterSubject()
        {
            InitializeComponent();
        }

        private void frmProgramSemesterSubject_Load(object sender, EventArgs e)
        {
            ComboHelper.AllProgramSemester(cmbSemesters);
            ComboHelper.AllTeacherSubjects(cmbSubjects);
            FillGrid(string.Empty);
        }

        public void FillGrid(string searchvalue)
        {
            try
            {
                string query = string.Empty;
                DataTable semesterlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim())) 
                {
                    query = "Select [ProgramSemesterSubjectID] [ID], [Program], ProgramSemesterID, " +
                            "Title [Semester], LectureSubjectID, SSTitle [Subject], Capacity, IsSubjectActive [Status] From " +
                            " v_AllSemestersSubjects WHERE [ProgramSemesterIsActive] = 1   and [ProgramIsActive] = 1" +
                            "and [SemesterIsActive] = 1 and [IsSubjectActive] = 1" +
                            "Order by ProgramSemesterID";
                    
                }
                else
                {
                   /* query = "Select [ProgramSemesterSubjectID] [ID], [Program], ProgramSemesterID, " +
                            "Title [Semester], LectureSubjectID, SSTitle [Subject], Capacity, IsSubjectActive [Status] From " +
                            " v_AllSemestersSubjects WHERE [ProgramSemesterIsActive] = 1 and [ProgramIsActive] = 1" +
                            " and [SemesterIsActive] = 1 and [SubjectIsActive] = 1 " +
                            "AND (Program + ' ' + Title + ' ' + SSTitle) like '%" + searchvalue + "%' Order by ProgramSemesterID";
                   */

                    query = "SELECT [ProgramSemesterSubjectID] [ID], [Program], ProgramSemesterID, " +
                            "Title [Semester], LectureSubjectID, SSTitle [Subject], Capacity, IsSubjectActive [Status] FROM " +
                            "v_AllSemestersSubjects WHERE [ProgramSemesterIsActive] = 1 AND [ProgramIsActive] = 1" +
                            " AND [SemesterIsActive] = 1 AND [IsSubjectActive] = 1 " +
                             "AND (Program + ' ' + Title + ' ' + SSTitle) LIKE '%" + searchvalue.Trim() + "%' ORDER BY ProgramSemesterID";

                }
                Console.WriteLine("Query: " + query);
                semesterlist = DatabaseLayer.Retrive(query);
                dataGridViewTeacherSubjects.DataSource = semesterlist;

            }
            catch
            {
                MessageBox.Show("Some unexpected issue occur plz try again!");
            }
        }

        private void cmbSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTitle.Text = cmbSubjects.SelectedIndex == 0 ? string.Empty : cmbSubjects.Text;
        }

        private void FormClear()
        {
            txtTitle.Clear();
            cmbSubjects.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtTitle.Text.Length == 0)
            {
                ep.SetError(txtTitle, "Please Enter Semester Subject Title!");
                txtTitle.Focus();
                txtTitle.SelectAll();
                return;
            }
            if(cmbSemesters.SelectedIndex == 0)
            {
                ep.SetError(cmbSemesters, "Pleae Select Semester!");
                cmbSemesters.Focus();
                return;
            }
            if(cmbSubjects.SelectedIndex == 0)
            {
                ep.SetError(cmbSubjects, "Please Select Subject!");
                cmbSubjects.Focus();
                return;
            }

            string checkquery = "select * from ProgramSemesterSubjectTable where" +
                                "ProgramSemesterID = '" + cmbSemesters.SelectedValue + "' and " +
                                "LectureSubjectID = '" + cmbSubjects.SelectedValue + "'";

            DataTable dt = DatabaseLayer.Retrive(checkquery);

            if(dt != null)
            {

            }

            if (dt != null && dt.Rows.Count > 0)
            {
                ep.SetError(cmbSubjects, "Already Exist");
                cmbSubjects.Focus();
                return;
            }

            string insertquery = string.Format("insert into ProgramSemesterSubjectTable" +
                                 "(SSTitle,ProgramSemesterID,LectureSubjectID)  values ('{0}','{1}','{2}') ",
                                 txtTitle.Text.Trim(), cmbSemesters.SelectedValue, cmbSubjects.SelectedValue);

            bool result = DatabaseLayer.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Subject Assigned Successfully!");
                FillGrid(string.Empty);
                FormClear();
            }
            else
            {
                MessageBox.Show("Please provide the correct details!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void cmsedit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeacherSubjects != null)
            {
                if(dataGridViewTeacherSubjects.Rows.Count > 0)
                {
                    if(dataGridViewTeacherSubjects.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to change status?", "Confirmation",
                            MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            bool existstatus = Convert.ToBoolean(dataGridViewTeacherSubjects.CurrentRow.Cells[8].Value);
                            int semestersubjectid = Convert.ToInt32(dataGridViewTeacherSubjects.CurrentRow.Cells[0].Value);
                            bool status = false;
                            if(existstatus)
                            {
                                status = false;
                            }
                            else
                            {
                                status = true;
                            }
                            string updatequery = string.Format("update ProgramSemesterSubjectTable set" +
                                                 " IsSubjectActive = '{0}' where ProgramSemesterSubjectID = '{1}'", status, semestersubjectid);
                            bool result = DatabaseLayer.Update(updatequery);
                            if (result)
                            {
                                MessageBox.Show("Change Successfully!");
                                FillGrid(string.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Please try again!");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please try again!");
                    }
                }
            }
        }
    }
}
