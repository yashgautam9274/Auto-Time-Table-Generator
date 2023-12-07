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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridView1.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridView1.Enabled = true;
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
                DataTable sessionlist = null;
                if (string.IsNullOrEmpty(searchvalue.Trim()))
                {
                    query = "Select SessionID [ID], Title, IsActive[Status] from SessionTable";
                }
                else
                {
                    query = "Select SessionID [ID], Title, IsActive[Status] from SessionTable where Title like '%" + searchvalue.Trim() + "%'";

                    //sessionlist = DatabaseLayer.Retrive(query);
                }
                sessionlist = DatabaseLayer.Retrive(query);
                dataGridView1.DataSource = sessionlist;
               // if (dataGridView1.Rows.Count > 0)
                //{
                 //   dataGridView1.Columns[0].Width = 80;
                 //   dataGridView1.Columns[1].Width = 150;
                 //   dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               // }
               if(sessionlist != null)
                {

                }
              //  else
                //{
                  //  MessageBox.Show("No data is Retrived from database");
               // }

            }
            catch
            {
                MessageBox.Show("Some unexpected error occur pls try again");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisableComponents();
        }

        public void ClearForm()
        {
            txtSessionTitle.Clear();
            chkStatus.Checked = false;
        }
        // clear button
        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtSessionTitle.Text.Length < 9)
            {
                ep.SetError(txtSessionTitle, "Enter the correct session Title!");
                txtSessionTitle.Focus();
                txtSessionTitle.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from SessionTable where Title = '" + txtSessionTitle.Text.Trim() + "'");
            if(checktitle != null &&  checktitle.Rows.Count > 0)
            {
                ep.SetError(txtSessionTitle, "Already Exist");
                txtSessionTitle.Focus();
                txtSessionTitle.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into SessionTable(title,IsActive) values ('{0}','{1}')",
                txtSessionTitle.Text.Trim(),chkStatus.Checked);
            bool result = DatabaseLayer.Insert(insertquery);
            if(result)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("Please Provide the correct Session Details");
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            //DatabaseLayer.ConOpen();
            FillGrid(string.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void cmsedit_Click(object sender, EventArgs e)
        {
            if(dataGridView1 != null)
            {
                if(dataGridView1.Rows.Count > 0)
                {
                    if(dataGridView1.SelectedRows.Count == 1)
                    {
                        txtSessionTitle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                        chkStatus.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value);
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
            if (txtSessionTitle.Text.Length < 9)
            {
                ep.SetError(txtSessionTitle, "Enter the correct session Title!");
                txtSessionTitle.Focus();
                txtSessionTitle.SelectAll();
                return;
            }
            DataTable checktitle = DatabaseLayer.Retrive("select * from SessionTable where Title = '" + txtSessionTitle.Text.Trim() + "' and SessionID != '"+ Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value)+"'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtSessionTitle, "Already Exist");
                txtSessionTitle.Focus();
                txtSessionTitle.SelectAll();
                return;
            }

            string updatequery = string.Format("UPDATE SessionTable SET Title = '{0}', IsActive = '{1}' WHERE SessionID = '{2}'",
                                 txtSessionTitle.Text.Trim(), chkStatus.Checked, Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));

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
