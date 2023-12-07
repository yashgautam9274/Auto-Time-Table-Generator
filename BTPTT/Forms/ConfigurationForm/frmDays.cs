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
    public partial class frmDays : Form
    {
        public frmDays()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridViewDay.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewDay.Enabled = true;
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
                DataTable daylist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "Select DayID [ID], Name, IsActive[Status] from DayTable";
                }
                else
                {
                    query = "Select DayID [ID], Name, IsActive[Status] from DayTable where Name like '%" + searchvalue.Trim() + "%'";
                }
                daylist = DatabaseLayer.Retrive(query);
                dataGridViewDay.DataSource = daylist;
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

        private void frmDays_Load(object sender, EventArgs e)
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
            if (txtDayname.Text.Length == 0)
            {
                ep.SetError(txtDayname, "Enter the correct Day Name!");
                txtDayname.Focus();
                txtDayname.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from DayTable where Name = '" + txtDayname.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtDayname, "Already Exist");
                txtDayname.Focus();
                txtDayname.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into DayTable(Name,IsActive) values ('{0}','{1}')",
                txtDayname.Text.Trim(), chkStatus.Checked);
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
            txtDayname.Clear();
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
            if (dataGridViewDay != null)
            {
                if (dataGridViewDay.Rows.Count > 0)
                {
                    if (dataGridViewDay.SelectedRows.Count == 1)
                    {
                        txtDayname.Text = Convert.ToString(dataGridViewDay.CurrentRow.Cells[1].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewDay.CurrentRow.Cells[2].Value);
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
            if (txtDayname.Text.Length == 0)
            {
                ep.SetError(txtDayname, "Enter the correct Day Name!");
                txtDayname.Focus();
                txtDayname.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from DayTable where Name = '" + txtDayname.Text.Trim() + "' and ProgramID != '" + Convert.ToString(dataGridViewDay.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtDayname, "Already Exist");
                txtDayname.Focus();
                txtDayname.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE DayTable SET Name = '{0}', IsActive = '{1}' WHERE DayID = '{2}'",
                                 txtDayname.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridViewDay.CurrentRow.Cells[0].Value));

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
