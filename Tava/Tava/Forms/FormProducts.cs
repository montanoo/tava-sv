using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tava.Models;

namespace Tava.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            using (var db = new TavaContext())
            {
                var list = db.Products;
                foreach (var prod in list)
                {
                    dataGridView1.Rows.Add(prod.Id, prod.Name, prod.Description);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar...")
            {
                textBox1.Text = "";
            }
        }
    }
}
