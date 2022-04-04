using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tava.Forms
{
    public partial class FormSalesRegistration : Form
    {
        public FormSalesRegistration()
        {
            InitializeComponent();
        }

        //Clear instruction text from textbox
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        //When registration button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string phone = textBox3.Text;

            using (var db = new Tava.Models.TavaContext())
            {

            }
        }
    }
}
