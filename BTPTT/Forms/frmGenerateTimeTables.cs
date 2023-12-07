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

namespace BTPTT.Forms
{
    public partial class frmGenerateTimeTables : Form
    {
        public frmGenerateTimeTables()
        {
            InitializeComponent();
        }

        private void btnGenerateTimeTable_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                string message = GenerateTimeTable.AutoGenerateTimeTable(dtpStartDate.Value, dtpEndDate.Value);
                MessageBox.Show(message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
