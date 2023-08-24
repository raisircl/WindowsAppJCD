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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbCourses.Items.Contains(txtCourseName.Text.Trim()))
            {
                MessageBox.Show("Course Allready Exist");
            }
            else
            { 
            lbCourses.Items.Add(txtCourseName.Text.Trim());
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbCourses.SelectedIndex >=0)
            {
                txtCourseName.Text = lbCourses.SelectedItem.ToString();
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbCourses.SelectedIndex >= 0)
            {

               
                
                if(lbCourses.Items.Contains(txtCourseName.Text.Trim()))
                {
                    MessageBox.Show("Can not update allready exist");
                }
                else
                {
                    lbCourses.Items[lbCourses.SelectedIndex]=txtCourseName.Text.Trim();
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    lbCourses.SelectedIndex = -1;
                    txtCourseName.Text = "";
                    txtCourseName.Focus();
                }
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            foreach(var item in lbCourses.Items)
            {
                label2.Text += item.ToString() +"\n"; 

            }
        }
    }
}
