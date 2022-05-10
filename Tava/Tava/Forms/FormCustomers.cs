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

                    var quantity =  db.Billings.GroupBy(a => a.ClientId).Select(g => g.Count()).FirstOrDefault();
                    
                    
                    dataGridView1.Rows.Add(cli.Id, cli.Name + " " + cli.Lastname, cli.Phone, quantity);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //searchbar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //no funciona, arreglar
            //DataTable tabla = new DataTable();
            //input = tabla;
            //input.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, textBox1.Text);
        }

    }
}
