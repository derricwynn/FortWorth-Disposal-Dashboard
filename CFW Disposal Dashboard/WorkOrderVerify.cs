using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFW_Disposal_Dashboard
{
    public partial class WorkOrderVerify : Form
    {
        public WorkOrderVerify()
        {
            InitializeComponent();
        }
       
        private void WorkOrderVerify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet3.WorkOrder' table. You can move, or remove it, as needed.
            this.workOrderTableAdapter.Fill(this.disposalDashboardDatabaseDataSet3.WorkOrder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
