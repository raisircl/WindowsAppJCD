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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text=dateTimePicker1.Value.ToString("dd/MM/yyyy");
            label1.Text = dateTimePicker1.Text;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAbout about = new FrmAbout();
            //about.Show();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.ShowDialog(); 

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
