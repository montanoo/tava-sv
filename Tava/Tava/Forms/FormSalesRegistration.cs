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



namespace Tava.Forms
{
    public partial class FormSalesRegistration : Form
    {
        private string user;
        public FormSalesRegistration()
        {
            InitializeComponent();
            FillCombobox();
        }
        public FormSalesRegistration(string username)
        {
            InitializeComponent();
            FillCombobox();
            user = username;
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

        //When registration button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null && numericUpDown1.Value != 0 && (checkBox1.Checked || checkBox2.Checked))
            {
                string name = textBox1.Text;
                string lastname = textBox2.Text;
                int phone = int.Parse(textBox3.Text);
                DateTime date = dateTimePicker1.Value;
                string addressto = "TAVA";

                //llenar el tipo de venta
                string saletype = "";
                if (checkBox1.Checked)
                {
                    saletype = "Local";
                }
                if (checkBox2.Checked)
                {
                    saletype = "Domicilio";
                    addressto = textBox6.Text;
                }

                try
                {
                    using (var db = new TavaContext())
                    {
                        //llenar la tabla de clientes
                        var ClientData = new Client
                        {
                            Name = name,
                            Lastname = lastname,
                            Phone = phone
                        };
                        db.Clients.Add(ClientData);
                        db.SaveChanges();

                        //obtener los datos del cliente, el producto y el usuario a registrar
                        var idclient = (from c in db.Clients
                                        where c.Name == textBox1.Text
                                        select c).SingleOrDefault();
                        var idprod = (from d in db.Products
                                      where d.Name == comboBox1.Text
                                      select d).SingleOrDefault();
                        var iduser = (from t in db.Users
                                      where t.Username == user
                                      select t).SingleOrDefault();

                        //llenamos la tabla de direcciones
                        var SalePoint = new Pointofsale
                        {
                            Type = saletype,
                            Address = addressto
                        };
                        db.Pointofsales.Add(SalePoint);
                        db.SaveChanges();

                        var idpoint = (from p in db.Pointofsales
                                       where p.Address == addressto
                                       select p).SingleOrDefault();
                        //llenamos los datos de venta
                        var SalesData = new Billing
                        {
                            AdminId = iduser.Id,
                            ClientId = idclient.Id,
                            Date = date,
                            ProductId = idprod.Id,
                            Quantity = int.Parse(numericUpDown1.Value.ToString()),
                            Totalprice = idprod.Price * int.Parse(numericUpDown1.Value.ToString()),
                            PointofsaleId = idpoint.Id
                        };

                        db.Billings.Add(SalesData);
                        db.SaveChanges();
                    }
                    MessageBox.Show("El cliente ha sido agregado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un problema al ingresar la venta, intentalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            comboBox1.SelectionStart = 0;
            numericUpDown1.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FillCombobox()
        {
            using (var db = new TavaContext())
            {
                foreach (Product obj in db.Products)
                {
                    comboBox1.Items.Add(obj.Name);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.Enabled = true;
                checkBox1.Checked = false;
            }
        }
    }
}
