using ClientRest.Models;
using ClientRest.Models.In;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class Sellers : Form
    {
        public List<Seller> list { get; set; }
        public List<InvoiceBuy> Invoices { get; set; } = new List<InvoiceBuy>();
        RestClass rest = new RestClass();

        public Sellers()
        {
            InitializeComponent();

            SellersCB.SelectedIndexChanged -= SellersCB_SelectedIndexChanged;
            

            list = rest.getRequest<List<Seller>>(controller.sellers);

            InvoicesCB.AutoCompleteMode = AutoCompleteMode.None;
            
            SellersCB.ValueMember = "id";
            SellersCB.DisplayMember = "name";
            SellersCB.DataSource = list;
            SellersCB.SelectedIndex = -1;

            
            InvoicesCB.ValueMember = "id";
            InvoicesCB.DisplayMember = "name";

            SellersCB.SelectedIndexChanged += SellersCB_SelectedIndexChanged;
            
        }

        private void SellersCB_DropDown(object sender, EventArgs e)
        {
            string a = SellersCB.Text;
            if (SellersCB.Text != "")
            {
                //if (!(a.Length < 3))
                //{
                List<Seller> temp = new List<Seller>();
                foreach(Seller item in list)
                {
                    if (item.Name.ToUpper().Contains(a.ToUpper()))
                    {
                        temp.Add(item);
                    }
                }
                SellersCB.DataSource = temp;
                SellersCB.SelectedIndex = -1;
                SellersCB.Text = a;
                //}

            }
            else
            {
                SellersCB.DataSource = list;
            }
        }

        private void SellersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SellersCB.SelectedIndex != -1)
            {
                InvoicesCB.SelectedIndexChanged -= InvoicesCB_SelectedIndexChanged;
                var Seller = (Seller)SellersCB.SelectedItem;
                Invoices = rest.getRequest<List<InvoiceBuy>>(controller.invoicebuys, "/bysellerid/" + Seller.ID.ToString());
                Invoices = Invoices.OrderByDescending(i => i.Date).ToList();
                InvoicesCB.DataSource = Invoices;
                InvoicesCB.SelectedIndex = -1;
                InvoicesCB.SelectedIndexChanged += InvoicesCB_SelectedIndexChanged;
            }
        }

        private void InvoicesCB_DropDown(object sender, EventArgs e)
        {
            string a = InvoicesCB.Text;
            if (InvoicesCB.Text != "")
            {
                if (InvoicesCB.Text.Length > 0)
                {
                List<InvoiceBuy> temp = new List<InvoiceBuy>();
                foreach(InvoiceBuy item in Invoices)
                {
                    if (item.Name.ToUpper().Contains(a.ToUpper()))
                    {
                        temp.Add(item);
                    }
                }
                InvoicesCB.DataSource = temp;
                InvoicesCB.SelectedIndex = -1;
                InvoicesCB.Text = a;
                }

            }
            else
            {
                InvoicesCB.DataSource = Invoices;
            }
        }

        private void InvoicesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InvoicesCB.SelectedIndex != -1)
            {
                var invoice = (InvoiceBuy)InvoicesCB.SelectedItem;
                InvoiceBuyShowForm form = new InvoiceBuyShowForm(invoice.ID);
                form.TopLevel = false;
                form.AutoScroll = true;
                Panel.Controls.Clear();
                Panel.Controls.Add(form);
                form.Show();
            }
        }
    }
}
