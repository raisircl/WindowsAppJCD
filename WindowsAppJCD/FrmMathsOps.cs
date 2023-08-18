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
    public partial class FrmMathsOps : Form
    {
        public FrmMathsOps()
        {
            InitializeComponent();
        }
        int n1, n2, r;
        private void btnSum_Click(object sender, EventArgs e)
        {
            //txtResult.Text = Convert.ToString(Convert.ToInt32(txtN1.Text)+ Convert.ToInt32(txtN2.Text)); 
            
            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);
            r = n1 + n2;
            txtResult.Text = r.ToString(); 

        }
    }
}
