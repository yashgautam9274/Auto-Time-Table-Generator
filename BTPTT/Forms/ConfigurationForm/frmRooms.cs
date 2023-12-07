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
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void EnabledComponents()
        {
            dataGridViewRoom.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewRoom.Enabled = true;
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
                    query = "Select RoomID [ID], RoomNo [Room],  Capacity, IsActive[Status] from RoomTable";
                }
                else
                {
                    query = "Select RoomID [ID], RoomNo [Room], Capacity, IsActive[Status] from RoomTable where RoomNo like '%" + searchvalue.Trim() + "%'";
                }
                roomlist = DatabaseLayer.Retrive(query);
                dataGridViewRoom.DataSource = roomlist;
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

        private void frmRooms_Load(object sender, EventArgs e)
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
            if (txtRoomNo.Text.Length == 0 || txtRoomNo.Text.Length >10)
            {
                ep.SetError(txtRoomNo, "Enter the correct RoomNo/Name!");
                txtRoomNo.Focus();
                txtRoomNo.SelectAll();
                return;
            }

            if (txtCapacity.Text.Length == 0)
            {
                ep.SetError(txtCapacity, "Enter the Room Capacity!");
                txtCapacity.Focus();
                txtCapacity.SelectAll();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from RoomTable where RoomNo = '" + txtRoomNo.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtRoomNo, "Already Exist");
                txtRoomNo.Focus();
                txtRoomNo.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into RoomTable(RoomNo,Capacity,IsActive) values ('{0}','{1}', '{2}')",
                txtRoomNo.Text.Trim(),txtCapacity.Text.Trim(),chkStatus.Checked);
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
            txtRoomNo.Clear();
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
            if (dataGridViewRoom != null)
            {
                if (dataGridViewRoom.Rows.Count > 0)
                {
                    if (dataGridViewRoom.SelectedRows.Count == 1)
                    {
                        txtRoomNo.Text = Convert.ToString(dataGridViewRoom.CurrentRow.Cells[1].Value);
                        txtCapacity.Text = Convert.ToString(dataGridViewRoom.CurrentRow.Cells[2].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewRoom.CurrentRow.Cells[3].Value);
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
            if (txtRoomNo.Text.Length == 0 || txtRoomNo.Text.Length > 10)
            {
                ep.SetError(txtRoomNo, "Enter the correct RoomNo/Name!");
                txtRoomNo.Focus();
                txtRoomNo.SelectAll();
                return;
            }

            if (txtCapacity.Text.Length == 0)
            {
                ep.SetError(txtCapacity, "Enter the Room Capacity!");
                txtCapacity.Focus();
                txtCapacity.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from RoomTable where RoomNo = '" + txtRoomNo.Text.Trim() + "' and RoomID != '" + Convert.ToString(dataGridViewRoom.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtRoomNo, "Already Exist");
                txtRoomNo.Focus();
                txtRoomNo.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE RoomTable SET RoomNo = '{0}', Capacity = '{1}', IsActive = '{2}' WHERE RoomID = '{3}'",
                                 txtRoomNo.Text.Trim(), txtCapacity.Text.Trim(),chkStatus.Checked, Convert.ToString(dataGridViewRoom.CurrentRow.Cells[0].Value));

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
