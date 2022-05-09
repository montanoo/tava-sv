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
        DialogResult dr;
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
                    dataGridView1.Rows.Add(prod.Id, prod.Name, prod.Description);
                }
            }
        }

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "Buscar...")
        //    {
        //        textBox1.Text = "";
        //    }
        //}

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = dataGridView1.SelectedCells[1].Value.ToString();
                string id = dataGridView1.SelectedCells[0].Value.ToString();
                dr = MessageBox.Show($"Estas seguro que quieres borrar el registro del producto '{nombre}'", "Advertencia", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TavaContext())
                    {
                        Product prod = db.Products.Where(i => i.Name == nombre).First();
                        db.Products.Remove(prod);
                        db.SaveChanges();
                        foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                        {
                            dataGridView1.Rows.RemoveAt(item.Index);
                        }

                    }
                    MessageBox.Show("Registro eliminado con exito");
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un registro a eliminar");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (var db = new TavaContext())
                    {
                        Product prod = db.Products.Where(i => i.Description == textBox1.Text).First();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        dataGridView1.Rows.Add(prod.Id, prod.Name, prod.Description);
                        BtnOK.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha encontrado ningun producto con dicha descripcion");
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
    }
}
