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

        //default address
        string addressto = "TAVA";
        public FormSalesRegistration()
        {
            InitializeComponent();
            FillCombobox();
        }
        //constructor que recibe el nombre de usuario
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

                //llenar el tipo de venta y la direccion si es a domicilio
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
                        // si existe el cliente no llenaremos la tabla otra vez
                        if (!RepeatedClient())
                        {
                            var ClientData = new Client
                            {
                                Name = name,
                                Lastname = lastname,
                                Phone = phone
                            };
                            db.Clients.Add(ClientData);
                        }
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
                        //revisamos que no se repitan las direcciones
                        if(!RepeatedAddress())
                        {
                            var SalePoint = new Pointofsale
                            {
                                Type = saletype,
                                Address = addressto
                            };
                            db.Pointofsales.Add(SalePoint);
                        }
                        db.SaveChanges();

                        var idpoint = (from p in db.Pointofsales
                                       where p.Address == addressto
                                       select p).SingleOrDefault();

                        //llenamos los datos de venta en billing
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
                    MessageBox.Show("La venta ha sido registrada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se ha podido registrar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            numericUpDown1.Value = 0;
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }
        //llenamos el combobox con los productos registrados
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
        // revisa que solo se pueda seleccionar un checkbox a la vez
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
        //revisar si el cliente ya existe en la bd
        private bool RepeatedClient()
        {
            bool repetition = false;
            using (var db = new TavaContext())
            {
                if (db.Clients.Count() != 0)
                {
                    var idclient = (from c in db.Clients
                                    where c.Name == textBox1.Text
                                    select c).SingleOrDefault();

                    if (idclient != null)
                    {
                        repetition = true;
                    }
                }
            }
            return repetition;
        }
        //revisar si la direccion ya existe en la bd
        private bool RepeatedAddress()
        {
            bool repetition = false;
            using (var db = new TavaContext())
            {
                if (db.Pointofsales.Count() != 0)
                {
                    var idpoint = (from c in db.Pointofsales
                                    where c.Address == addressto
                                    select c).SingleOrDefault();

                    if (idpoint != null)
                    {
                        repetition = true;
                    }
                }
            }
            return repetition;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {


                using (var db = new TavaContext())
                {
                    Product productos = new Product();
                    string producto;
                    decimal cantidad = 0;
                    decimal total = 0;
                    if (comboBox1.Text != "Seleccionar producto" || comboBox1.Text != "")
                    {
                        producto = comboBox1.Text;
                        cantidad = numericUpDown1.Value;
                        var getprice = db.Products.Where(a => a.Name == producto).FirstOrDefault();

                        total = Convert.ToDecimal(getprice.Price) * cantidad;
                        totaltxt.Text = total.ToString();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
