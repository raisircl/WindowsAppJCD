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
    public partial class FrmDropDowns : Form
    {
        public FrmDropDowns()
        {
            InitializeComponent();
        }
        List<Country> countryList = new List<Country>();
        List<State> stateList = new List<State>();
        bool blncountry=false;
        private void FrmDropDowns_Load(object sender, EventArgs e)
        {
            countryList.Add(new Country() { Id = 1, Name = "India", Code = "IN" });
            countryList.Add(new Country() { Id = 2, Name = "Sri Lanka", Code = "Sri" });
            countryList.Add(new Country() { Id = 3, Name = "Nepal", Code = "NP" });
            countryList.Add(new Country() { Id = 4, Name = "Bhutan", Code = "BHU" });
            countryList.Add(new Country() { Id = 5, Name = "Cananda", Code = "CAN" });
            countryList.Add(new Country() { Id = 6, Name = "London", Code = "LO" });

            stateList.Add(new State() { Id = 1, Name = "Haryana", Code = "HRY", CId=1 });
            stateList.Add(new State() { Id = 2, Name = "Punjab", Code = "PB", CId=1 });
            stateList.Add(new State() { Id = 3, Name = "Koshi", Code = "KO", CId=3 });
            stateList.Add(new State() { Id = 4, Name = "Madhesh", Code = "MAD",CId=3 });
            stateList.Add(new State() { Id = 5, Name = "Bagmati", Code = "BAG" , CId = 3 });
            stateList.Add(new State() { Id = 6, Name = "Toronto", Code = "TO", CId=5 });

            loadCountries();
            blncountry = true;
            loadStates(1);

        }
        void loadCountries()
        {
            cmbCountries.DataSource = countryList;  
            cmbCountries.DisplayMember = "Name";
            cmbCountries.ValueMember = "Id";
        }
        void loadStates(int cid)
        {
            
            var cstates=stateList.FindAll(s => s.CId == cid);
            if (cstates.Count > 0)
            {
                cmbStates.DataSource = cstates;
                cmbStates.DisplayMember = "Name";
                cmbStates.ValueMember = "Id";
            }
            else
            {
                cmbStates.Text = "";
                MessageBox.Show("No States Found");
            }
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(blncountry==true)
            {
                int x = Convert.ToInt32(cmbCountries.SelectedValue);
                loadStates(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
              label1.Text += item.ToString()+"\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label1.Text=monthCalendar1.SelectionStart.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Develop in JCD Batch");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Hello");
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000,"Demo","Demo Text",ToolTipIcon.Info);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=nudRed.Value.ToString();
            int r, g, b;
            r = Convert.ToInt32(nudRed.Value);
            g = Convert.ToInt32(nudGreen.Value);
            b = Convert.ToInt32(nudBlue.Value);

            this.BackColor = Color.FromArgb(r, g, b);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\RAI\Downloads\kpl.jpg");
        }
    }
}
