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
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Tava.Forms
{
    public partial class FormProducts : Form
    {

        DialogResult dr;
        int posicion;
        public FormProducts()
        {
            InitializeComponent();
            FillTable();
        }
        private void FillTable()
        {
            using (var db = new TavaContext())
            {
                var list = db.Products;
                foreach (var prod in list)
                {
                    dataGridView1.Rows.Add(prod.Id, prod.Name, prod.Package, prod.Unitsperset, "$" + prod.Price, prod.Stock, prod.Description);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (var db = new TavaContext())
                    {
                        var prod = db.Products.Where(i => i.Name == textBox1.Text).ToArray();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        foreach(var p in prod)
                        {
                            dataGridView1.Rows.Add(p.Id, p.Name, p.Package, p.Unitsperset, p.Price, p.Stock, p.Description);
                        }
                        BtnOK.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha encontrado ningun producto con ese nombre");
                    textBox1.Clear();
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar...")
            {
                textBox1.Text = "";
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            FillTable();
            BtnOK.Visible = false;
            textBox1.Clear();

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void Existbutton_Click(object sender, EventArgs e)
        {

            dataGridView1[5, posicion].Value = existxt.Text;
            using (TavaContext db = new TavaContext())
            {
                var stock = db.Products.Where(a => a.Name == dataGridView1[1, posicion].Value.ToString()).FirstOrDefault();

                stock.Stock = Convert.ToInt32(existxt.Text);
                db.Entry(stock).State = EntityState.Modified;
                db.SaveChanges();


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.Value != null)
            {
                posicion = dataGridView1.CurrentRow.Index;
                existxt.Text = dataGridView1[5, posicion].Value.ToString();
                existxt.Focus();
            }
        }

       
    }
}
