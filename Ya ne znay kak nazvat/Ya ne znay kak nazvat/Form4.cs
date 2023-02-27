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
    public partial class Form4 : Form
    {
        AndreyEntities1 db;
        public Form4()
        {
            db =new AndreyEntities1(); 
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.id =int.Parse( textBox4.Text);
            product.name=textBox1.Text;
            product.discription=textBox2.Text;
            product.count_in_stock =int.Parse(textBox3.Text);
            product.time_of_sale = dateTimePicker2.Value.TimeOfDay;
            product.date_of_sale = dateTimePicker1.Value;
            db.product.Add(product);
            db.SaveChanges();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
