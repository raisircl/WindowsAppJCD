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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }
        Form1 frm1;
        Form2 frm2;
        Form3 frm3;
        FrmAbout frmabt;

        private void menu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem mitm=(ToolStripMenuItem)sender;
            //MessageBox.Show($"Write code to open {mitm.Text}");
            int tag = Convert.ToInt32(mitm.Tag);
            switch (tag) {
                case 1:
                    if(frm1==null || frm1.IsDisposed)
                    {
                        frm1 = new Form1();
                        frm1.MdiParent = this;
                        frm1.Show();
                        frm1.Focus();
                    }
                   
                    else
                    {
                        frm1.Show();
                        frm1.Focus();
                    }
                    break;
                case 2:
                    if (frm2 == null || frm2.IsDisposed)
                    {
                        frm2 = new Form2();
                        frm2.MdiParent = this;
                        frm2.Show();
                        frm2.Focus();
                    }
                    else
                    {
                        frm2.Show();
                        frm2.Focus();
                    }
                    break;
            }
        }
    }
}
