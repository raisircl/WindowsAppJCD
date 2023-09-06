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
        int cri;

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
            ds.Tables.Clear();

            comm.CommandText = "select dno,dname,loc from tbldept";
            
            comm.CommandType=CommandType.Text;  

            comm.Connection = conn;

            da.SelectCommand = comm;

            da.Fill(ds, "tbldept");

            dgvdept.DataSource = ds.Tables["tbldept"];


            reset();
        }
        void reset()
        {
            txtDNo.Text = "";
            txtDName.Text = "";
            txtLoc.Text = "";
            txtDName.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            comm.CommandText = "insert into tbldept(dname,loc) values(@dname,@loc)";
            comm.CommandType=CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dname",txtDName.Text);
            comm.Parameters.AddWithValue("@loc", txtLoc.Text);
            conn.Open();
            int x= comm.ExecuteNonQuery(); // IUD  it returns no of rows affected by query
            conn.Close();
            comm.Parameters.Clear();

            if(x>=1)
            {
                MessageBox.Show("Recored Inserted");
            }
            else
            {
                MessageBox.Show("No Record Inserted");
            }
            loadgrid();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cri > -1)
            {
                comm.CommandText = "update tbldept set dname=@dname,loc=@loc where dno=@dno";
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@dno", txtDNo.Text);
                comm.Parameters.AddWithValue("@dname", txtDName.Text);
                comm.Parameters.AddWithValue("@loc", txtLoc.Text);
                conn.Open();
                int x = comm.ExecuteNonQuery(); // IUD  it returns no of rows affected by query
                conn.Close();
                comm.Parameters.Clear();

                if (x >= 1)
                {
                    MessageBox.Show("Recored Updated");
                }
                else
                {
                    MessageBox.Show("No Record Updated");
                }
                loadgrid();

            }
        }

        private void dgvdept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                txtDNo.Text = dgvdept.Rows[e.RowIndex].Cells["DNo"].Value.ToString();
                txtDName.Text = dgvdept.Rows[e.RowIndex].Cells["DName"].Value.ToString();
                txtLoc.Text = dgvdept.Rows[e.RowIndex].Cells["Loc"].Value.ToString();
                cri = e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cri > -1)
            {
                comm.CommandText = "delete from tbldept where dno=@dno";
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@dno", txtDNo.Text);
              
                conn.Open();
                int x = comm.ExecuteNonQuery(); // IUD  it returns no of rows affected by query
                conn.Close();
                comm.Parameters.Clear();

                if (x >= 1)
                {
                    MessageBox.Show("Recored Deleted");
                }
                else
                {
                    MessageBox.Show("No Record Deleted");
                }
                loadgrid();
            }
        }
    }
}
/*
 tblemp

empno
ename
emailid
phoneno
job
salary
hiredate
dob
country
state
district
cityvill
addressline1
addressline2
pincode
mgrno - 
dno  - FK
addon
updateon
status - 1 Active, 2 Inactive, 3 delete 


 
 */