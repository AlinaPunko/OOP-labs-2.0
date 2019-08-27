using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class Form1 : Form
    {
        private float constant = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text)));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.constant = Convert.ToInt32(textBox3.Text);
                textBox4.Text = textBox3.Text;
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.constant = 0;
            this.textBox4.Text = Convert.ToString(this.constant);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Convert.ToString(this.constant);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
