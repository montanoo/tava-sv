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
            int phone = int.Parse(textBox3.Text);

            try
            {
                using (var db = new Tava.Models.TavaContext())
                {
                    var ClientData = new Models.Client();
                    ClientData.Name = name;
                    ClientData.Lastname = lastname;
                    ClientData.Phone = phone;

                    db.Clients.Add(ClientData);
                    db.SaveChanges();
                }
                MessageBox.Show("El cliente ha sido agregado! El registro de venta estará disponible en la próxima entrega", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema al ingresar la venta, intentalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectionStart = 0;
            numericUpDown1.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
    }
}
