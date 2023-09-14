using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppJCD
{
    public partial class FrmDeptReport : Form
    {
        public FrmDeptReport()
        {
            InitializeComponent();
        }
       
        private void FrmDeptReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sp_fetchdept' table. You can move, or remove it, as needed.
            this.sp_fetchdeptTableAdapter.Fill(this.dataSet1.sp_fetchdept);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
