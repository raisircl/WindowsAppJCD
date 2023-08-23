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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(chkReading.Checked && chkPlaying.Checked)
            {

                MessageBox.Show("Excelent");
            }
            else if(chkReading.Checked)
            {
                MessageBox.Show("Very Good");
            }
            else if(chkPlaying.Checked) {
                MessageBox.Show("Good..");
            }
            else
            {
                MessageBox.Show("Please select a hobby");
            }
            
        }

        private void brnSubmit_Click(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
                MessageBox.Show("Hello Mr.");
            }
            else if(rbFemale.Checked)
            {
                MessageBox.Show("Hello Ms");
            }
            else
            {
                MessageBox.Show("Please select a gender");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox3.Text = textBox1.Text;
                textBox4.Text=textBox2.Text;
            }
            else
            {
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
