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

namespace BTPTT.Forms.ConfigurationForm
{
    public partial class frmCourses : Form
    {
        public frmCourses()
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

        public void SaveClearForm()
        {
            txtLecturerName.Clear();
            cmbSelectType.SelectedValue = 0;
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
                    query = "select CourseID[ID], Title[Subject], CrHrs, RoomTypeID, TypeName[Type], IsActive from v_AllSubjects";
                }
                else
                {
                    query = "select CourseID[ID], Title[Subject], CrHrs, RoomTypeID, TypeName[Type], IsActive from v_AllSubjects where (Title + ' ' + TypeName) like '%" + searchvalue.Trim() + "%'";
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

        private void frmCourses_Load(object sender, EventArgs e)
        {
            cmbCrHrs.SelectedIndex = 0;
            ComboHelper.RoomTypes(cmbSelectType);
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
                ep.SetError(txtLecturerName, "Please Enter Subject Title!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (cmbSelectType.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectType, "Please Select Program!");
                cmbSelectType.Focus();
                return;
            }


            DataTable checktitle = DatabaseLayer.Retrive("select * from CourseTable where Title = '" + txtLecturerName.Text.Trim() + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string insertquery = string.Format("Insert into CourseTable(Title,CrHrs,RoomTypeID,IsActive) values ('{0}','{1}', '{2}','{3}')",
                txtLecturerName.Text.Trim(), cmbCrHrs.Text, cmbSelectType.SelectedValue, chkStatus.Checked);
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
            cmbSelectType.SelectedValue = 0;
            cmbCrHrs.SelectedValue = 0;
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
                        cmbSelectType.SelectedValue = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[3].Value);  // ProgramId
                        cmbCrHrs.Text = Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[2].Value); // SemesterID
                        chkStatus.Checked = Convert.ToBoolean(dataGridViewLecturer.CurrentRow.Cells[5].Value);
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
                ep.SetError(txtLecturerName, "Please Enter Subject Title!");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            if (cmbSelectType.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectType, "Please Select Program!");
                cmbSelectType.Focus();
                return;
            }


            DataTable checktitle = DatabaseLayer.Retrive("select * from CourseTable where Title = '" + txtLecturerName.Text.Trim() + "' and CourseID != '"+ Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value) + "'");
            if (checktitle != null && checktitle.Rows.Count > 0)
            {
                ep.SetError(txtLecturerName, "Already Exist");
                txtLecturerName.Focus();
                txtLecturerName.SelectAll();
                return;
            }

            string updatequery = string.Format("update CourseTable  set Title = '{0}', CrHrs = '{1}', RoomTypeID = '{2}', IsActive = '{3}' WHERE CourseID = '{4}'",
                txtLecturerName.Text.Trim(), cmbCrHrs.Text, cmbSelectType.SelectedValue, chkStatus.Checked, Convert.ToString(dataGridViewLecturer.CurrentRow.Cells[0].Value));
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
    }
}
