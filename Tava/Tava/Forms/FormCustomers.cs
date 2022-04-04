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
    public partial class FormCustomers : Form
    {
        //variables for search bar
        public DataTable input;
        string filterField = "Nombre";
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
                foreach (var cli in list)
                {
                    dataGridView1.Rows.Add(cli.Id, cli.Name + " " + cli.Lastname, cli.Phone, "no disponible");
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
