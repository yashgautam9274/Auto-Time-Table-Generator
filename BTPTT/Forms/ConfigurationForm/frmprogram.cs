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
    public partial class frmprogram : Form
    {
        public frmprogram()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridViewProgram.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewProgram.Enabled = true;
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
                DataTable programlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "Select ProgramID [ID], Name, IsActive[Status] from ProgramTable";
                }
                else
                {
                    query = "Select ProgramID [ID], Name, IsActive[Status] from ProgramTable where Name like '%" + searchvalue.Trim() + "%'";
                }
                programlist = DatabaseLayer.Retrive(query);
                dataGridViewProgram.DataSource = programlist;
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

        private void frmprogram_Load(object sender, EventArgs e)
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
            if (txtProgramname.Text.Length == 0)
            {
                ep.SetError(txtProgramname, "Enter the correct Semester Name!");
                txtProgramname.Focus();
                txtProgramname.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from ProgramTable where Name = '" + txtProgramname.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtProgramname, "Already Exist");
                txtProgramname.Focus();
                txtProgramname.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into ProgramTable(Name,IsActive) values ('{0}','{1}')",
                txtProgramname.Text.Trim(), chkStatus.Checked);
            bool result = DatabaseLayer.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Save Successfull!");
                DisableComponents();
                // FillGrid(string.Empty);
            }
            else
            {
                MessageBox.Show("Please Provide the correct Program Details. Then try again!");
            }
        }

        public void ClearForm()
        {
            txtProgramname.Clear();
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
            if (dataGridViewProgram != null)
            {
                if (dataGridViewProgram.Rows.Count > 0)
                {
                    if (dataGridViewProgram.SelectedRows.Count == 1)
                    {
                        txtProgramname.Text = Convert.ToString(dataGridViewProgram.CurrentRow.Cells[1].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewProgram.CurrentRow.Cells[2].Value);
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
            if (txtProgramname.Text.Length == 0)
            {
                ep.SetError(txtProgramname, "Enter the correct Program Name!");
                txtProgramname.Focus();
                txtProgramname.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from ProgramTable where Name = '" + txtProgramname.Text.Trim() + "' and ProgramID != '" + Convert.ToString(dataGridViewProgram.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtProgramname, "Already Exist");
                txtProgramname.Focus();
                txtProgramname.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE ProgramTable SET Name = '{0}', IsActive = '{1}' WHERE ProgramID = '{2}'",
                                 txtProgramname.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridViewProgram.CurrentRow.Cells[0].Value));

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
    }
}
