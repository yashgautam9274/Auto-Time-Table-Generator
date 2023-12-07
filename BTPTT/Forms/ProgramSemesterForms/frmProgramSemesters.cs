using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTPTT.SourceCode;

namespace BTPTT.Forms.ProgramSemesterForms
{
    public partial class frmProgramSemesters : Form
    {
        public frmProgramSemesters()
        {
            InitializeComponent();
        }


        public void EnabledComponents()
        {
            dataGridViewLecturer.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewLecturer.Enabled = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            txtSearch.Enabled = true;
            ClearForm();
            FillGrid(string.Empty);
        }

        public void FillGrid(string searchvalue)
        {
            try
            {
                string query = string.Empty;
                DataTable roomlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "select ProgramSemesterID[ID], Title,Capacity, ProgramSemesterIsActive[Status], ProgramID, SemesterID from v_ProgramSemesterActiveList";
                }
                else
                {
                    query = "select ProgramSemesterID[ID], Title,Capacity, ProgramSemesterIsActive[Status], ProgramID, SemesterID from v_ProgramSemesterActiveList where Title like '%" + searchvalue.Trim() + "%'";
                }
                roomlist = DatabaseLayer.Retrive(query);
                dataGridViewLecturer.DataSource = roomlist;
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

        public void SaveClearForm()
        {
            txtLecturerName.Clear();
            cmbSelectSemester.SelectedValue = 0;
            FillGrid(string.Empty);
        }

        private void frmProgramSemesters_Load(object sender, EventArgs e)
        {
            ComboHelper.Semesters(cmbSelectSemester);
            ComboHelper.Programs(cmbSelectProgram);
            FillGrid(string.Empty);
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtLecturerName.Text.Length == 0)
            {
                ep.SetError(txtLecturerName, "Please Select Again, Title is Empty!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (cmbSelectProgram.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectProgram, "Please Select Program!");
                cmbSelectProgram.Focus();
                return;
            }

            if (cmbSelectSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectSemester, "Please Select Semester!");
                cmbSelectSemester.Focus();
                return;
            }

            if(txtCapacity.Text.Length == 0)
            {
                ep.SetError(txtCapacity, "Please Enter the Cacacity of Class!");
                txtCapacity.Focus();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from ProgramSemesterTable where ProgramID = '" + cmbSelectProgram.SelectedValue + "'  and SemesterID = '" + cmbSelectSemester.SelectedValue + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into ProgramSemesterTable(Title,ProgramID,SemesterID,IsActive,Capacity) values ('{0}','{1}', '{2}','{3}','{4}')",
                txtLecturerName.Text.Trim(), cmbSelectProgram.SelectedValue,cmbSelectSemester.SelectedValue,chkStatus.Checked, txtCapacity.Text.Trim());
            // Console.WriteLine("Insert Query: ", insertquery);
            bool result = DatabaseLayer.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Save Successfull!");
                SaveClearForm();
                // FillGrid(string.Empty);
            }
            else
            {
                MessageBox.Show("Please Provide the correct Program Details. Then try again!");
            }
        }

        public void ClearForm()
        {
            txtLecturerName.Clear();
            cmbSelectProgram.SelectedValue = 0;
            cmbSelectSemester.SelectedValue = 0;
            chkStatus.Checked = false;
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void cmsedit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLecturer != null)
            {
                if (dataGridViewLecturer.Rows.Count > 0)
                {
                    if (dataGridViewLecturer.SelectedRows.Count == 1)
                    {
                        txtLecturerName.Text = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[1].Value);
                        txtCapacity.Text = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[2].Value);
                        cmbSelectProgram.SelectedValue = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[4].Value);  // ProgramId
                        cmbSelectSemester.SelectedValue = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[5].Value); // SemesterID
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewLecturer.CurrentRow.Cells[3].Value);
                        EnabledComponents();
                    }
                    else
                    {
                        MessageBox.Show("Please select one Record!");
                    }
                }
                else
                {
                    MessageBox.Show("List is Empty!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtLecturerName.Text.Length == 0)
            {
                ep.SetError(txtLecturerName, "Please Select Again, Title is Empty!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (cmbSelectProgram.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectProgram, "Please Select Program!");
                cmbSelectProgram.Focus();
                return;
            }

            if (cmbSelectSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectSemester, "Please Select Semester!");
                cmbSelectSemester.Focus();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from ProgramSemesterTable where ProgramID = '" + cmbSelectProgram.SelectedValue + "'  and SemesterID = '" + cmbSelectSemester.SelectedValue + "' and ProgramSemesterID != '"+ Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value)+ "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string updatequery = string.Format("update ProgramSemesterTable  set Title = '{0}', ProgramID = '{1}', SemesterID = '{2}', IsActive = '{3}', Capacity = '{4}' WHERE ProgramSemesterID = '{5}'",
                txtLecturerName.Text.Trim(), cmbSelectProgram.SelectedValue, cmbSelectSemester.SelectedValue,chkStatus.Checked, txtCapacity.Text.Trim(), Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value));
             Console.WriteLine("Insert Query: ", updatequery);
            bool result = DatabaseLayer.Update(updatequery);
            if (result)
            {
                MessageBox.Show("Update Successfull!");
                DisableComponents();
                // FillGrid(string.Empty);
            }
            else
            {
                MessageBox.Show("Please Provide the correct Program Details. Then try again!");
            }
        }

        private void cmbSelectProgram_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!cmbSelectProgram.Text.Contains("Select"))
            {
                txtLecturerName.Text = cmbSelectProgram.Text;
                if (cmbSelectSemester.SelectedIndex > 0)
                {
                    txtLecturerName.Text = cmbSelectProgram.Text + " " + cmbSelectSemester.Text;
                }
            }
        }

        private void cmbSelectSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!cmbSelectSemester.Text.Contains("Select"))
            {
                if (cmbSelectProgram.SelectedIndex > 0)
                {
                    txtLecturerName.Text = cmbSelectProgram.Text + " " + cmbSelectSemester.Text;

                }
            }
        }
    }
}
