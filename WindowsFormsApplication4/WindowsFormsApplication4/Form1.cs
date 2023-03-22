using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void survey_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";

            //Netherland
            if (netherLand.Checked == true) {
                str = str + netherLand.Text;
                str += ", ";
            }

            //Australia
            if (australia.Checked == true)
            {
                str = str + australia.Text;
                str += ", ";
            }

            //Hongkong
            if (hongKong.Checked == true)
            {
                str = str + hongKong.Text;
                str += ", ";
            }

            //india
            if (india.Checked == true)
            {
                str = str + india.Text;
                str += ", ";
            }
            
            //others
             if (othersBox.Checked == true)
            {
                str = str + otherTxtBox.Text;
                str += " ";
            }

            if (str != null) {
                MessageBox.Show("You selected: \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersBox_CheckedChanged(object sender, EventArgs e)
        {

            if (othersBox.Checked)
            {
                othersLabel.Visible = true;
                otherTxtBox.Visible = true;
            }

            else
            {
                othersLabel.Visible = false;
                otherTxtBox.Visible = false;
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            othersLabel.Visible = false;
            otherTxtBox.Visible = false;
            otherTxtBox.Multiline = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            netherLand.Checked = false;
            australia.Checked = false;
            hongKong.Checked = false;
            india.Checked = false;
            othersBox.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
