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

        private void FormProductsRegistration_Load(object sender, EventArgs e)
        {

        }


        private void PrecioTxt_Click(object sender, EventArgs e)
        {
            if (PrecioTxt.Text == "0.00")
            {
                PrecioTxt.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NombreTxt.Text == "" || UnidadesTxt.Value == 0 || PrecioTxt.Text == "" || PrecioTxt.Text == "0.00" || DescripcionTxt.Text == "" || EmpaqueTxt.Text == "Caja, bolsa, otros" || EmpaqueTxt.Text == "")
            {
                MessageBox.Show("Ingresa todos los valores requeridos para poder registrar un producto.");

            }
            else
            {
                try {
                    using (var db = new TavaContext())
                    {
                        var product = new Product()
                        {
                            Name = NombreTxt.Text,
                            Description = DescripcionTxt.Text,
                            Unitsperset = Convert.ToInt32(Math.Round(UnidadesTxt.Value, 0)),
                            Price = Convert.ToDouble(PrecioTxt.Text),
                            Package = EmpaqueTxt.Text
                        };

                        db.Products.Add(product);
                        db.SaveChanges();
                        MessageBox.Show("El producto ha sido añadido con éxito.");
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Datos invalidos, intente de nuevo.");
                    
                }
                Limpiar();
            }
        
        }

        public void Limpiar()
        {
            NombreTxt.Clear();
            DescripcionTxt.Clear();
            UnidadesTxt.Value = 1;
            PrecioTxt.Text = "0.00";
            EmpaqueTxt.Text = "Caja, bolsa, otros";
        }

        private void EmpaqueTxt_Click(object sender, EventArgs e)
        {
            if (EmpaqueTxt.Text == "Caja, bolsa, otros")
            {
                EmpaqueTxt.Text = "";
            }
        }
    }
}
