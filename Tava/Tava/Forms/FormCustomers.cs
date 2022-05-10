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
    public partial class FormCustomers : Form
    {
        //variables for search bar
        public DataTable input;
        //   string filterField = "Nombre";
        public FormCustomers()
        {
            InitializeComponent();
            ShowDgv();
        }
        public void ShowDgv()
        {
            using (var db = new Models.TavaContext())
            {
                var list = db.Clients;
                Billing billings = new Billing();
                var list1 = db.Billings;
                foreach (var cli in list)
                {

                    var quantity = db.Billings.GroupBy(a => a.ClientId).Select(g => g.Count()).FirstOrDefault();


                    dataGridView1.Rows.Add(cli.Id, cli.Name + " " + cli.Lastname, cli.Phone, quantity);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (var db = new TavaContext())
                    {
                        var prod = db.Clients.Where(i => i.Name == textBox1.Text).ToArray();

                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        foreach (var p in prod)
                        {
                            var quantity = db.Billings.GroupBy(a => a.ClientId).Select(g => g.Count()).FirstOrDefault();
                            dataGridView1.Rows.Add(p.Id, p.Name + " " + p.Lastname, p.Phone, quantity);
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
            ShowDgv();
            BtnOK.Visible = false;
            textBox1.Clear();

        }
    }
}
