using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RadRed.Checked = true;
            RadRed.ForeColor = Color.Red;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbllaptrinh_TextChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Text = txtlaptrinh.Text;
            lbllaptrinh.Text = txtlaptrinh.Text;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    txtlaptrinh.ForeColor = Color.Red;
                    lbllaptrinh.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    txtlaptrinh.ForeColor = Color.Green;
                    lbllaptrinh.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    txtlaptrinh.ForeColor = Color.Blue;
                    lbllaptrinh.ForeColor = Color.Blue;
                    break;
                case "radBack":
                    txtlaptrinh.ForeColor = Color.Black;
                    lbllaptrinh.ForeColor = Color.Black;
                    break;
            }
            
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;
            switch (r.Name)
            {
                case "radRed":
                    txtlaptrinh.ForeColor = Color.Red;
                    lbllaptrinh.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    txtlaptrinh.ForeColor = Color.Green;
                    lbllaptrinh.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    txtlaptrinh.ForeColor = Color.Blue;
                    lbllaptrinh.ForeColor = Color.Blue;
                    break;
            }
        }
    }
}
