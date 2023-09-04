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
    public partial class FrmDS : Form
    {
        public FrmDS()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); // ds is collection of tables in xml form
        DataTable dt = new DataTable("tbldept");
        DataColumn dc1 = new DataColumn("DNo");
        DataColumn dc2 = new DataColumn("DName");
        DataColumn dc3 = new DataColumn("Loc");

        int cri = -1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["tbldept"].NewRow();
            dr["DNo"]=txtDNo.Text;
            dr["DName"] = txtDName.Text;
            dr["Loc"] = txtLoc.Text;
            ds.Tables["tbldept"].Rows.Add(dr);
            reset();
        }

        private void FrmDS_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            ds.Tables.Add(dt);
            dgvdept.DataSource = ds.Tables["tbldept"];    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cri > -1)
            {
                ds.Tables["tbldept"].Rows[cri]["DNo"] = txtDNo.Text;
                ds.Tables["tbldept"].Rows[cri]["DName"] = txtDName.Text;
                ds.Tables["tbldept"].Rows[cri]["Loc"] = txtLoc.Text;
                MessageBox.Show("Record Updated");
                cri = -1;
                reset();
            }
        }

        private void dgvdept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {

                txtDNo.Text = dgvdept.Rows[e.RowIndex].Cells["DNo"].Value.ToString();
                txtDName.Text = dgvdept.Rows[e.RowIndex].Cells["DName"].Value.ToString();
                txtLoc.Text = dgvdept.Rows[e.RowIndex].Cells["Loc"].Value.ToString();
                cri = e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cri > -1)
            {
                ds.Tables["tbldept"].Rows[cri].Delete();
                cri = -1;
                reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            txtDNo.Text = "";
            txtDName.Text = "";
            txtLoc.Text = "";
            txtDNo.Focus();
        }
    }
}
