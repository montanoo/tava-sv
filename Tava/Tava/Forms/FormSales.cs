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
    public partial class FormSales : Form
    {
        DialogResult dr;
        public FormSales()
        {
            InitializeComponent();
            Sales();
        }
        private void Sales()
        {
            using (var db = new TavaContext())
            {
                var list = db.Billings;
                Client clients = new Client();
                foreach (var bill in list)
                {
                    Client getclid = db.Clients.Where(a => a.Id == bill.ClientId).FirstOrDefault();
                    var names = getclid.Name +" "+ getclid.Lastname;
                    Product getproductid = db.Products.Where(a => a.Id == bill.ProductId).FirstOrDefault();
                    Pointofsale gettypeid = db.Pointofsales.Where(a => a.Id == bill.PointofsaleId).FirstOrDefault();
                    dataGridView1.Rows.Add(bill.Id, bill.Date, names,getproductid.Name,gettypeid.Type,bill.Quantity, "$"+bill.Totalprice);
                }
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
                        var name = db.Products.Where(c => c.Name == textBox1.Text).FirstOrDefault();
                        var prod = db.Billings.Where(i => i.ProductId == name.Id).ToArray();

                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        foreach (var p in prod)
                        {
                            Client getclid = db.Clients.Where(a => a.Id == p.ClientId).FirstOrDefault();
                            var names = getclid.Name + " " + getclid.Lastname;

                            Product getproductid = db.Products.Where(a => a.Id == p.ProductId).FirstOrDefault();
                            Pointofsale gettypeid = db.Pointofsales.Where(a => a.Id == p.PointofsaleId).FirstOrDefault();
                            dataGridView1.Rows.Add(p.Id, p.Date, names, getproductid.Name ,gettypeid.Type, p.Quantity,"$" +p.Totalprice);
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
            Sales();
            BtnOK.Visible = false;
            textBox1.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar por producto...")
            {
                textBox1.Text = "";
            }
        }
    }

}

