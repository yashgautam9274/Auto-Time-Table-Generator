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
    public partial class frmlectures : Form
    {
        public frmlectures()
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
                    query = "Select LectureID [ID], FullName[Lecturer],  ContactNo, IsActive[Status] from LectureTable";
                }
                else
                {
                    query = "Select LectureID [ID], FullName[Lecturer], ContactNo, IsActive[Status] from LectureTable where (FullName + ' ' + ContactNo) like '%" + searchvalue.Trim() + "%'";
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

        private void frmlectures_Load(object sender, EventArgs e)
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
            if (txtLecturerName.Text.Length == 0 || txtLecturerName.Text.Length > 10)
            {
                ep.SetError(txtLecturerName, "Enter the Full Name!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (txtContactNo.Text.Length != 11)
            {
                ep.SetError(txtContactNo, "Enter the ContactNo!");
                txtContactNo.Focus();
                txtContactNo.SelectAll();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from LectureTable where FullName = '" + txtLecturerName.Text.Trim() + "'  and ContactNo = '"+txtContactNo.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into LectureTable(FullName,ContactNo,IsActive) values ('{0}','{1}', '{2}')",
                txtLecturerName.Text.Trim(), txtContactNo.Text.Trim(), chkStatus.Checked);
           // Console.WriteLine("Insert Query: ", insertquery);
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
            txtLecturerName.Clear();
            txtContactNo.Clear();
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
                        txtContactNo.Text = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[2].Value);
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
            if (txtLecturerName.Text.Length == 0 || txtLecturerName.Text.Length > 10)
            {
                ep.SetError(txtLecturerName, "Enter the Full Name!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (txtContactNo.Text.Length != 11)
            {
                ep.SetError(txtContactNo, "Enter the ContactNo!");
                txtContactNo.Focus();
                txtContactNo.SelectAll();
                return;
            }

            DataTable checktitle = DatabaseLayer.Retrive("select * from LectureTable where FullName = '" + txtLecturerName.Text.Trim() + "' and ContactNo != '"+txtContactNo.Text.Trim()+"' and LectureID != '" + Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE LectureTable SET FullName = '{0}', ContactNo = '{1}', IsActive = '{2}' WHERE LectureID = '{3}'",
                                 txtLecturerName.Text.Trim(), txtContactNo.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value));

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
