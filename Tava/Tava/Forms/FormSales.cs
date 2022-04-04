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
                foreach (var client in list)
                {
                    dataGridView1.Rows.Add(client.Id, client.Name +" "+ client.Lastname, client.Phone, "not available");
                }
            }
            //Models.TavaContext db = new Models.TavaContext();
            //var client = (from client in db.Clients select client);
            //dataGridView1.DataSource = Tava.Models.Client.tolist;

            //using (var db = new Models.TavaContext())
            //{

            //    var qLoggedIn = from r in db.Clients
            //                    select new { Name = r.Name + ", " + r.Lastname, r.Phone };

            //    dataGridView1.DataSource = qLoggedIn.ToList();

            //}

        }
       
    }
}
