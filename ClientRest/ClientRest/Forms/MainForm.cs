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
    public partial class MainForm : Form
    {
        //public List<InvoiceSell> InvoiceSells { get; set; }
        //public List<InvoiceBuy> InvoiceBuys { get; set; }
        RestClass rest = new RestClass();
        public delegate void Delegacik();
        public Delegacik OnFormChange;
        public MainForm()
        {
            
            //InvoiceSells = rest.getRequest<List<InvoiceSell>>(controller.invoicesells);
            //InvoiceBuys = rest.getRequest<List<InvoiceBuy>>(controller.productbuys);
            InitializeComponent();
        }

        private void NPButton_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.TopLevel = false;
            newProduct.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(newProduct);
            newProduct.Show();
        }

        private void ISButton_Click(object sender, EventArgs e)
        {
            InvoiceSellForm invoiceSell = new InvoiceSellForm();
            invoiceSell.TopLevel = false;
            invoiceSell.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(invoiceSell);
            invoiceSell.Show();
        }

        private void IBButton_Click(object sender, EventArgs e)
        {
            NewInvoiceBuyForm invoiceBuy = new NewInvoiceBuyForm();
            invoiceBuy.TopLevel = false;
            invoiceBuy.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(invoiceBuy);
            invoiceBuy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsList productsList = new ProductsList();
            productsList.TopLevel = false;
            productsList.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(productsList);
            productsList.Show();
        }

        public void InvoiceSellsButton_Click(object sender, EventArgs e)
        {
            ListBox1.SelectedIndexChanged -= new EventHandler(ListBox1_SelectedIndexChanged);
            List<InvoiceSell> invoiceSells = new List<InvoiceSell>();
            invoiceSells = rest.getRequest<List<InvoiceSell>>(controller.invoicesells);
            ListBox1.DataSource = invoiceSells;
            ListBox1.DisplayMember = "name";
            ListBox1.ValueMember = "id";
            
            //ListBox1.Refresh();
            //ListBox1.SelectedIndex = -1;
            ListBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox1.DataBindings.GetType() == typeof(List<InvoiceBuy>))
            {

            }
            else if(ListBox1.DataBindings.GetType() == typeof(List<InvoiceSell>))
            {

            }
            else if(ListBox1.DataBindings.GetType() == typeof(List<Product>))
            {

            }
        }

        private void InvoiceBuysButton_Click(object sender, EventArgs e)
        {
            ListBox1.SelectedIndexChanged -= new EventHandler(ListBox1_SelectedIndexChanged);
            List<InvoiceBuy> invoiceBuys = new List<InvoiceBuy>();
            invoiceBuys = rest.getRequest<List<InvoiceBuy>>(controller.invoicebuys);
            ListBox1.DataSource = invoiceBuys;
            ListBox1.DisplayMember = "name";
            ListBox1.ValueMember = "id";

            //ListBox1.Refresh();
            //ListBox1.SelectedIndex = -1;
            ListBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
        }

        
    }
}
