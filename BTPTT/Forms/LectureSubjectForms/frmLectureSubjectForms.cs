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

namespace BTPTT.Forms.LectureSubjectForms
{
    public partial class frmLectureSubjectForms : Form
    {
        public frmLectureSubjectForms()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridViewTeacherSubjects.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewTeacherSubjects.Enabled = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            txtSearch.Enabled = true;
            ClearForm();
            FillGrid(string.Empty);
        }

        public void ClearForm()
        {
             cmbSubjects.SelectedIndex = 0;
             cmbTeachers.SelectedIndex = 0;
             chkStatus.Checked = true;
        }

        public void FillGrid(string searchvalue)
        {
            try
            {
                string query = string.Empty;
                DataTable semesterlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "select LectureSubjectID[ID], SubjectTitle[Subject Title], LectureID, FullName[Lecturer], CourseID, " +
                            "Title[Course], IsActive[Status] from v_AllSubjectTeachers";
                }
                else
                {
                    query = "select LectureSubjectID[ID], SubjectTitle[Subject Title], LectureID, FullName[Lecturer], CourseID, " +
                            "Title[Course], IsActive[Status] from v_AllSubjectTeachers" +
                            "WHERE (SubjectTitle + ' ' + FullName + ' ' + Title) like '%"+searchvalue.Trim()+"%'";
                }
                semesterlist = DatabaseLayer.Retrive(query);
                dataGridViewTeacherSubjects.DataSource = semesterlist;
                /* if (dataGridViewSemester.Rows.Count > 0)
                 {
                   dataGridViewSemester.Columns[0].Width = 80;
                   dataGridViewSemester.Columns[1].Width = 150;
                   dataGridViewSemester.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                 } */
            }
            catch
            {
                MessageBox.Show("Some unexpected error occur pls try again");
                throw;
            }
        }

        private void frmLectureSubjectForms_Load(object sender, EventArgs e)
        {
            ComboHelper.AllTeachres(cmbTeachers);
            ComboHelper.AllSubjects(cmbSubjects);
            FillGrid(string.Empty);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if(cmbTeachers.SelectedIndex == 0)
                {
                    ep.SetError(cmbTeachers, "Please select Teacher!");
                    cmbTeachers.Focus();
                    return;
                }
                if(cmbSubjects.SelectedIndex == 0)
                {
                    ep.SetError(cmbSubjects, "Please select Subject!");
                    cmbSubjects.Focus(); 
                    return;
                }

                DataTable dt = DatabaseLayer.Retrive("select * from LectureSubjectTable where LectureID = '" + cmbTeachers.SelectedValue + "' and CourseID = '" + cmbSubjects.SelectedValue + "'");
                if(dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        ep.SetError(cmbSubjects, "Already Registred!");
                        cmbSubjects.Focus();
                        return;
                    }
                }

                string insertquery = string.Format("insert into LectureSubjectTable(SubjectTitle, LectureID, CourseID, IsActive) values('{0}','{1}','{2}','{3}')",
                     cmbSubjects.Text + "(" + cmbTeachers.Text + ")", cmbTeachers.SelectedValue, cmbSubjects.SelectedValue, chkStatus.Checked);

                MessageBox.Show("QUery: ", insertquery);
                bool result = DatabaseLayer.Insert(insertquery);
                if (result)
                {
                    MessageBox.Show("Subject Assign Successfully!");
                    DisableComponents();
                    return;
                }
                else
                {
                    MessageBox.Show("Some Unexpected issue is occured!");
                }

            }
            catch
            {
                MessageBox.Show("Please check Sql Server Agent Connectivity!");
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewTeacherSubjects != null)
                {
                    if(dataGridViewTeacherSubjects.Rows.Count > 0)
                    {
                        if(dataGridViewTeacherSubjects.SelectedRows.Count == 1)
                        {
                            string id = Convert.ToString(dataGridViewTeacherSubjects.CurrentRow.Cells[0].Value);
                            bool status = Convert.ToBoolean(dataGridViewTeacherSubjects.CurrentRow.Cells[6].Value) == true ? true : false;
                            string updatequery = "Update LectureSubjectTable set IsActive = '"+status+"'  where LectureSubjectID = '"+id+"'";

                            MessageBox.Show("QUery: ", updatequery);
                            bool result = DatabaseLayer.Insert(updatequery);
                            if (result)
                            {
                                MessageBox.Show("Status changes Successfully!");
                                DisableComponents();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Some Unexpected issue is occured!");
                            }
                        }
                    }
                }
                
            }
            catch 
            {

            }
        }
    }
}
