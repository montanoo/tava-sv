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
                    var names = getclid.Name +" "+ getclid.Name;
                    Product getproductid = db.Products.Where(a => a.Id == bill.ProductId).FirstOrDefault();
                    Pointofsale gettypeid = db.Pointofsales.Where(a => a.Id == bill.PointofsaleId).FirstOrDefault();
                    dataGridView1.Rows.Add(bill.Id, bill.Date, names,getproductid.Name,gettypeid.Type,bill.Quantity, bill.Totalprice);
                }
            }
        }
    }

}

