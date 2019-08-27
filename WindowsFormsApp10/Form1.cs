using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        float tarjeta = 0;
        int total = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                total = 250;
            }
            else
            {
                total = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                total = 150;
            }
            else
            {
                total = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                total = 600;
            }
            else
            {
                total = 0;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               // if (!string.IsNullOrEmpty(textBox2.Text))
                //{
                    tarjeta = (total) / 10;
               // }
            }
            else
            {
                tarjeta = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBox2.Text)) & (!string.IsNullOrEmpty(textBox1.Text)) & (!string.IsNullOrEmpty(textBox3.Text)))
            {
                textBox4.Text = (total + tarjeta).ToString();
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }
    }
}
