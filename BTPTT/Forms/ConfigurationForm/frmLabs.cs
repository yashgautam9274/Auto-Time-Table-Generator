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
    public partial class frmLabs : Form
    {
        public frmLabs()
        {
            InitializeComponent();
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void EnabledComponents()
        {
            dataGridViewLab.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewLab.Enabled = true;
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
                DataTable lablist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "Select LabID [ID], LabNo [Lab],  Capacity, IsActive[Status] from LabTable";
                }
                else
                {
                    query = "Select LabID [ID], LabNo [Lab], Capacity, IsActive[Status] from LabTable where LabNo like '%" + searchvalue.Trim() + "%'";
                }
                lablist = DatabaseLayer.Retrive(query);
                dataGridViewLab.DataSource = lablist;
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

        private void frmLabs_Load(object sender, EventArgs e)
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
            if (txtLabNo.Text.Length == 0 || txtLabNo.Text.Length > 10)
            {
                ep.SetError(txtLabNo, "Enter the correct LabNo/Name!");
                txtLabNo.Focus();
                txtLabNo.SelectAll();
                return;
            }

            if (txtCapacity.Text.Length == 0)
            {
                ep.SetError(txtCapacity, "Enter the Lab Capacity!");
                txtCapacity.Focus();
                txtCapacity.SelectAll();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from LabTable where LabNo = '" + txtLabNo.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLabNo, "Already Exist");
                txtLabNo.Focus();
                txtLabNo.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into LabTable(LabNo,Capacity,IsActive) values ('{0}','{1}', '{2}')",
                txtLabNo.Text.Trim(), txtCapacity.Text.Trim(), chkStatus.Checked);
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
            txtLabNo.Clear();
            txtCapacity.Clear();
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
            if (dataGridViewLab != null)
            {
                if (dataGridViewLab.Rows.Count > 0)
                {
                    if (dataGridViewLab.SelectedRows.Count == 1)
                    {
                        txtLabNo.Text = Convert.ToString(dataGridViewLab.CurrentRow.Cells[1].Value);
                        txtCapacity.Text = Convert.ToString(dataGridViewLab.CurrentRow.Cells[2].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewLab.CurrentRow.Cells[3].Value);
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
            if (txtLabNo.Text.Length == 0 || txtLabNo.Text.Length > 10)
            {
                ep.SetError(txtLabNo, "Enter the correct LabNo/Name!");
                txtLabNo.Focus();
                txtLabNo.SelectAll();
                return;
            }

            if (txtCapacity.Text.Length == 0)
            {
                ep.SetError(txtCapacity, "Enter the Lab Capacity!");
                txtCapacity.Focus();
                txtCapacity.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from LabTable where LabNo = '" + txtLabNo.Text.Trim() + "' and LabID != '" + Convert.ToString(dataGridViewLab.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLabNo, "Already Exist");
                txtLabNo.Focus();
                txtLabNo.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE LabTable SET LabNo = '{0}', Capacity = '{1}', IsActive = '{2}' WHERE LabID = '{3}'",
                                 txtLabNo.Text.Trim(), txtCapacity.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridViewLab.CurrentRow.Cells[0].Value));

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
