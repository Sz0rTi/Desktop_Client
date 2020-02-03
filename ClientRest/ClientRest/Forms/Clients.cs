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
    public partial class Clients : Form
    {
        public List<Client> list { get; set; }
        public List<InvoiceSell> Invoices { get; set; } = new List<InvoiceSell>();
        RestClass rest = new RestClass();

        public Clients()
        {
            InitializeComponent();

            ClientsCB.SelectedIndexChanged -= ClientsCB_SelectedIndexChanged;
            

            list = rest.getRequest<List<Client>>(controller.clients);

            InvoicesCB.AutoCompleteMode = AutoCompleteMode.None;
            
            ClientsCB.ValueMember = "id";
            ClientsCB.DisplayMember = "name";
            ClientsCB.DataSource = list;
            ClientsCB.SelectedIndex = -1;

            
            InvoicesCB.ValueMember = "id";
            InvoicesCB.DisplayMember = "name";

            ClientsCB.SelectedIndexChanged += ClientsCB_SelectedIndexChanged;
            
        }

        private void ClientsCB_DropDown(object sender, EventArgs e)
        {
            string a = ClientsCB.Text;
            if (ClientsCB.Text != "")
            {
                //if (!(a.Length < 3))
                //{
                List<Client> temp = new List<Client>();
                foreach (Client item in list)
                {
                    if (item.Name.ToUpper().Contains(a.ToUpper()))
                    {
                        temp.Add(item);
                    }
                }
                ClientsCB.DataSource = temp;
                ClientsCB.SelectedIndex = -1;
                ClientsCB.Text = a;
                //}

            }
            else
            {
                ClientsCB.DataSource = list;
            }
        }

        private void ClientsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClientsCB.SelectedIndex != -1)
            {
                InvoicesCB.SelectedIndexChanged -= InvoicesCB_SelectedIndexChanged;
                var client = (Client)ClientsCB.SelectedItem;
                Invoices = rest.getRequest<List<InvoiceSell>>(controller.invoicesells, "/byclientid/" + client.ID.ToString());
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
                List<InvoiceSell> temp = new List<InvoiceSell>();
                foreach(InvoiceSell item in Invoices)
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
                var invoice = (InvoiceSell)InvoicesCB.SelectedItem;
                InvoiceSellShowForm form = new InvoiceSellShowForm(invoice.ID);
                form.TopLevel = false;
                form.AutoScroll = true;
                Panel.Controls.Clear();
                Panel.Controls.Add(form);
                form.Show();
            }
        }
    }
}
