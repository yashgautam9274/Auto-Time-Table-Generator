using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTPTT.Forms.ConfigurationForm
{
    public partial class frmSemesters : Form
    {
        public frmSemesters()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridViewSemester.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewSemester.Enabled = true;
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
                DataTable semesterlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "Select SemesterID [ID], SemesterName, IsActive[Status] from SemesterTable";
                }
                else
                {
                    query = "Select SemesterID [ID], SemesterName, IsActive[Status] from SemesterTable where SemesterName like '%" + searchvalue.Trim() + "%'";
                }
                semesterlist = DatabaseLayer.Retrive(query);
                dataGridViewSemester.DataSource = semesterlist;
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

        private void frmSemesters_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSemestername.Text.Length == 0)
            {
                ep.SetError(txtSemestername, "Enter the correct Semester Name!");
                txtSemestername.Focus();
                txtSemestername.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from SemesterTable where SemesterName = '" + txtSemestername.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtSemestername, "Already Exist");
                txtSemestername.Focus();
                txtSemestername.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into SemesterTable(SemesterName,IsActive) values ('{0}','{1}')",
                txtSemestername.Text.Trim(), chkStatus.Checked);
            bool result = DatabaseLayer.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Save Successfull!");
                DisableComponents();
                // FillGrid(string.Empty);
            }
            else
            {
                MessageBox.Show("Please Provide the correct Session Details. Then try again!");
            }
        }

        public void ClearForm()
        {
            txtSemestername.Clear();
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

        private void cmsOptions_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cmsedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit the semester");
            if (dataGridViewSemester != null)
            {
                if (dataGridViewSemester.Rows.Count > 0)
                {
                    if (dataGridViewSemester.SelectedRows.Count == 1)
                    {
                        txtSemestername.Text = Convert.ToString(dataGridViewSemester.CurrentRow.Cells[1].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewSemester.CurrentRow.Cells[2].Value);
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
            if (txtSemestername.Text.Length == 0)
            {
                ep.SetError(txtSemestername, "Enter the correct Semester Name!");
                txtSemestername.Focus();
                txtSemestername.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from SemesterTable where SemesterName = '" + txtSemestername.Text.Trim() + "' and SemesterID != '" + Convert.ToString(dataGridViewSemester.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtSemestername, "Already Exist");
                txtSemestername.Focus();
                txtSemestername.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE SemesterTable SET SemesterName = '{0}', IsActive = '{1}' WHERE SemesterID = '{2}'",
                                 txtSemestername.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridViewSemester.CurrentRow.Cells[0].Value));

            bool result = DatabaseLayer.Update(updatequery);
            if (result)
            {
                MessageBox.Show("Update Successfull!");
                DisableComponents();
            }
            else
            {
                MessageBox.Show("Stuck!");
            }
        }

        private void dataGridViewSemester_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
