using BTPTT.Models;
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

namespace BTPTT.Forms.TimeSlotsForms
{
    public partial class frmDayTimeSlots : Form
    {
        public frmDayTimeSlots()
        {
            InitializeComponent();
        }

        public void EnabledComponents()
        {
            dataGridViewSlots.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            txtSearch.Enabled = false;
        }

        public void DisableComponents()
        {
            dataGridViewSlots.Enabled = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            txtSearch.Enabled = true;
            ClearForm();
            FillGrid(string.Empty);
        }

        public void ClearForm()
        {
            cmbDays.SelectedIndex = 0;
            cmbNoofTimeSlot.SelectedIndex = 0;
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
                    query = "select DayTimeSlotID, DayID, Name[Day], SlotTitle[Slot Title], StartTime [Start Time], EndTime [End Time], IsActive[Status] from v_AllTimeSlots WHERE IsActive = 1";
                }
                else
                {
                    query = "select DayTimeSlotID, DayID, Name[Day], SlotTitle[Slot Title], StartTime [Start Time], EndTime [End Time], IsActive[Status] from v_AllTimeSlots" +
                            "WHERE IsActive = 1 AND (Name + ' ' + SlotTime) Like '%"+searchvalue.Trim()+"%'";
                }
                semesterlist = DatabaseLayer.Retrive(query);
                dataGridViewSlots.DataSource = semesterlist;
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

        private void frmDayTimeSlots_Load(object sender, EventArgs e)
        {
            dtpStartTime.Value = new DateTime(2023, 12, 12, 9, 0, 0);
            dtpEndTime.Value = new DateTime(2023, 12, 12, 7, 0, 0);
            FillGrid(string.Empty);
            ComboHelper.AllDays(cmbDays);
            ComboHelper.TimeSlotsNumbers(cmbNoofTimeSlot);
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
                if (cmbDays.SelectedIndex == 0)
                {
                    ep.SetError(cmbDays, "Please select the day");
                    cmbDays.Focus();
                    return;
                }

                if (cmbNoofTimeSlot.SelectedIndex == 0)
                {
                    ep.SetError(cmbNoofTimeSlot, "Please select time slots per day");
                    cmbNoofTimeSlot.Focus();
                    return;
                }

                //string Updatequery = "update DayTimeSlotTable set IsActive = 0 where DayID = '" + cmbDays.SelectedValue + "'";
                //bool updateresult = DatabaseLayer.Update(Updatequery);
                //if (updateresult)
                //{
                    List<TimeSlotsMV> timeslots = new List<TimeSlotsMV>();
                    TimeSpan time = dtpEndTime.Value - dtpStartTime.Value;
                    int totalminutes = (int)time.TotalMinutes;
                    int numberoftimeslot = Convert.ToInt32(cmbNoofTimeSlot.SelectedValue);
                    // Console.Write("number of slots:", numberoftimeslot);
                    //MessageBox.Show("number of slots: ", numberoftimeslot.ToString());
                    int slot = totalminutes / numberoftimeslot;

                    int i = 0;

                    do
                    {
                        var timeslot = new TimeSlotsMV();
                        var FromTime = (dtpStartTime.Value).AddMinutes(slot * i);
                        i++;
                        var ToTime = (dtpStartTime.Value).AddMinutes((slot != 0) ? (slot * i) : 0);

                        string title = FromTime.ToString("hh:mm tt") + "-" + ToTime.ToString("hh:mm tt");
                        timeslot.FromTime = FromTime;
                        timeslot.ToTime = ToTime;
                        timeslot.SlotTime = title;
                        timeslots.Add(timeslot);
                    }
                    while (i < numberoftimeslot);
                    bool insertstatus = true;
                    foreach (TimeSlotsMV slottime in timeslots)
                    {
                        string insertquery = string.Format("INSERT INTO DayTimeSlotTable (DayID, SlotTitle, StartTime, EndTime, IsActive) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                          cmbDays.SelectedValue, slottime.SlotTime, slottime.FromTime, slottime.ToTime, chkStatus.Checked);
                        bool result = DatabaseLayer.Insert(insertquery);
                        if (result)
                        {
                            insertstatus = false;
                        }
                    }
                    if (insertstatus)
                    {
                        MessageBox.Show("Slots created Successfully!");
                        FillGrid(string.Empty);
                        DisableComponents();
                    }
                    else
                    {
                        MessageBox.Show("Please provide the correct details!");
                    }
               // }
                //else
                //{
                  //  MessageBox.Show("Please provide the correct details!");
               // }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                //MessageBox.Show("Check Sql server Agent connectivity!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }
    }
}
