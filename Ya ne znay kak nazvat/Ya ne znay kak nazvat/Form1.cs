using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ya_ne_znay_kak_nazvat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User" && textBox2.Text=="1111")
            {
            Form form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if (textBox1.Text == "Admin" && textBox2.Text == "1111")
            {
                Form form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}
