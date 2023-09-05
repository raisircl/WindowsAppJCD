using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsAppJCD
{
    public partial class FrmDept : Form
    {
        public FrmDept()
        {
            InitializeComponent();
        }
       
        SqlConnection conn = new SqlConnection();

        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        
        DataSet ds = new DataSet(); 

        private void FrmDept_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=sircldb;Persist Security Info=True;User ID=sa;Password=rai11**";
            
            //conn.Open();
            //if(conn.State==ConnectionState.Open)
            //{
            //    MessageBox.Show("connected....");
            //}
            //conn.Close();
            
            loadgrid();

        }
        void loadgrid()
        {
            comm.CommandText = "select dno,dname,loc from tbldept";
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "tbldept");
            dgvdept.DataSource = ds.Tables["tbldept"];


        }
    }
}
