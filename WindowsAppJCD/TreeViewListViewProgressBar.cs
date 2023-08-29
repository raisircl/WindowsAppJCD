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
    public partial class TreeViewListViewProgressBar : Form
    {
        public TreeViewListViewProgressBar()
        {
            InitializeComponent();
        }
       
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (lb1.Items.Count > 0)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = lb1.Items.Count;
                progressBar1.Value = 0;
              
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lb1.Items.Count>0)
            {
                lb2.Items.Add(lb1.Items[0]);
                lb1.Items.RemoveAt(0);
                progressBar1.Value++;
                float p = progressBar1.Value * 100 / progressBar1.Maximum;
                lblprogress.Text = p.ToString()+"%";
            }
            else
            {
                timer1.Stop();
            }
        }

        private void TreeViewListViewProgressBar_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 2000;i++)
            {
                lb1.Items.Add("Item " + i);
            }
            timer1.Stop();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Index >= 0)
            {
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem litm=new ListViewItem(textBox2.Text);
            litm.SubItems.Add(textBox3.Text);
            litm.SubItems.Add(textBox4.Text);
            litm.ImageIndex = 0;
            listView1.Items.Add(litm);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
    }
}
