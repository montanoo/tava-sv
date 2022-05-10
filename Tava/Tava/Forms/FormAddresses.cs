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
                dataGridView1.Rows.Add(values.Id, clientName.Name, pointOfSale.Address);
            }
        }

    }
}
