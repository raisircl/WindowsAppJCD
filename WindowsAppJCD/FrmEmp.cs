using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppJCD
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=sircldb;Persist Security Info=True;User ID=sa;Password=rai11**");
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsdept = new DataSet();
        bool blndept=false; 
        private void btnsave_Click(object sender, EventArgs e)
        {
            comm.CommandText = "insert into tblemp(ename,job,sal,hiredate,dno,addon,recordstatus) values(@ename,@job,@sal,@hd,@dno,@addon,@rs)";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@ename", txtename.Text);
            comm.Parameters.AddWithValue("@job", txtjob.Text);
            comm.Parameters.AddWithValue("@sal", txtsal.Text);
            comm.Parameters.AddWithValue("@hd", dtpHiredate.Value);
            comm.Parameters.AddWithValue("@dno", cmbdept.SelectedValue);
            comm.Parameters.AddWithValue("@addon", DateTime.Now);
            comm.Parameters.AddWithValue("@rs", 'A');
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loadgrid();
        }
        void loadgrid(int dno=0)
        {
            ds.Tables.Clear();
            if (dno != 0)
            {
                comm.CommandText = "select * from tblemp where dno=@dno";
                comm.Parameters.AddWithValue("@dno", dno);
            }
            else
            {
                comm.CommandText = "select * from tblemp";
            }
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "tblemp");
            dgvemp.DataSource = ds.Tables["tblemp"];
            comm.Parameters.Clear();
        }
        void loaddept()
        {
            dsdept.Tables.Clear();

            comm.CommandText = "select dno,dname,loc from tbldept";

            comm.CommandType = CommandType.Text;

            comm.Connection = conn;

            da.SelectCommand = comm;

            da.Fill(dsdept, "tbldept");

            cmbdept.DataSource = dsdept.Tables["tbldept"];
            cmbdept.DisplayMember = "dname";
            cmbdept.ValueMember = "dno";

            blndept = true;
        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {
            loadgrid();
            loaddept();
           
        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blndept == true)
            {
                loadgrid(Convert.ToInt32(cmbdept.SelectedValue.ToString()));
            }
        }
    }
}
