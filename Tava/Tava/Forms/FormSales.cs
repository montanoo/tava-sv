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
    public partial class FormSales : Form
    {
        public FormSales()
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
                    dataGridView1.Rows.Add(cli.Id, cli.Name +" "+ cli.Lastname, cli.Phone, 0);
                }
            }

            //using (var db = new TavaContext())
            //{
            //    var list = db.Products;
            //    foreach (var prod in list)
            //    {
            //        dataGridView1.Rows.Add(prod.Id, prod.Name, prod.Description);
            //    }
            //}

        }
       
    }
}
