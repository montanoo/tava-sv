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
    public partial class FormAddresses : Form
    {
        public FormAddresses()
        {
            InitializeComponent();
            FillAddress();
        }

        private void FillAddress()
        {
            using var context = new TavaContext();
            var address = context.Billings;
            foreach (var values in address)
            {
                var clientId = values.ClientId;
                var clientName = context.Clients.Where(a => a.Id == clientId).FirstOrDefault();

                var pointOfSaleId = values.PointofsaleId;
                var pointOfSale = context.Pointofsales.Where(b => b.Id == pointOfSaleId).FirstOrDefault();
                dataGridView1.Rows.Add(values.Id, clientName.Name + " " + clientName.Lastname, pointOfSale.Address);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (var context = new TavaContext())
                    {
                        var nameArray = context.Clients.Where(x => x.Name == textBox1.Text).ToArray();


                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();

                        var address = context.Billings;
                        foreach (var names in nameArray)
                        {
                            foreach(var values in address)
                            {
                                var clientId = values.ClientId;
                                var clientName = context.Clients.Where(a => a.Id == clientId).FirstOrDefault();

                                var pointOfSaleId = values.PointofsaleId;
                                var pointOfSale = context.Pointofsales.Where(b => b.Id == pointOfSaleId).FirstOrDefault();


                                dataGridView1.Rows.Add(values.Id, clientName.Name + " " + clientName.Lastname, pointOfSale.Address);
                            }
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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            FillAddress();
            BtnOK.Visible = false;
            textBox1.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar por nombre...")
            {
                textBox1.Text = "";
            }
        }
    }
}
