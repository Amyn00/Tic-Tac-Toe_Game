using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "" && textBox2.Text != "") || (textBox1.Text != "" && checkBox1.Checked))
            {
                if (textBox1.Text == textBox2.Text) 
                {
                    textBox1.Text += "1";
                    textBox2.Text += "2";
                }
                Close();
            }
            else
            {
                    MessageBox.Show("Enter the name of the players");
                    return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox2.Enabled = false; } else textBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown1.Value = 0;
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Value = 10;
                numericUpDown1.Enabled = true;
            }
        }
    }
}
