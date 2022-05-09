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
    public partial class FormProductsRegistration : Form
    {
        
        public FormProductsRegistration()
        {
            InitializeComponent();
            
        }

        private void EmpaqueTxt_Click(object sender, EventArgs e)
        {
            if (EmpaqueTxt.Text == "Caja, bolsa,otros")
            {
                EmpaqueTxt.Text = "";
            }
        }

        private void PrecioTxt_Click(object sender, EventArgs e)
        {
            if (PrecioTxt.Text == "0.00")
            {
                PrecioTxt.Text = "";
            }
        }

        private void RegistrarProdbtn_Click(object sender, EventArgs e)
        {
            if (Nombretxt.Text == "" || UnidadesTxt.Value == 0 || PrecioTxt.Text == "" || PrecioTxt.Text == "0.00" || DescripcionTxt.Text == "" || EmpaqueTxt.Text == "Caja, bolsa,otros" || EmpaqueTxt.Text == "")
            {
                MessageBox.Show("Ingresa todos los valores requeridos para poder registrar un producto.");

            }
            else
            {
                    using(var db = new TavaContext())
                    {
                        var product = new Product()
                        {
                        Name= Nombretxt.Text,
                        Description = DescripcionTxt.Text,
                        Unitsperset = Convert.ToInt32(Math.Round(UnidadesTxt.Value,0)),
                        Price = Convert.ToDouble(PrecioTxt.Text),
                        Package = EmpaqueTxt.Text
                    };
                    try
                    {
                        db.Products.Add(product);
                        db.SaveChanges();

                        MessageBox.Show("El producto ha sido añadido con éxito.");
                        Limpiar();
                    }
                    catch
                    {
                        MessageBox.Show("Ya existe un producto con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }   
        }

        public void Limpiar()
        {
            Nombretxt.Clear();
            DescripcionTxt.Clear();
            UnidadesTxt.Value = 0;
            PrecioTxt.Text = "0.00";
            EmpaqueTxt.Text = "Caja, bolsa,otros";
        }

    }
}
