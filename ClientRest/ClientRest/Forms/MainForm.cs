using ClientRest.Models.In;
using System;
using System.Collections.Generic;
using System.IO;
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
        public int SelectedType { get; set; }
        public MainForm()
        {
            SelectedType = -1;
            //InvoiceSells = rest.getRequest<List<InvoiceSell>>(controller.invoicesells);
            //InvoiceBuys = rest.getRequest<List<InvoiceBuy>>(controller.productbuys);
            InitializeComponent();
        }

        private void ISButton_Click(object sender, EventArgs e)
        {
            InvoiceSellForm invoiceSell = new InvoiceSellForm(this);
            invoiceSell.TopLevel = false;
            invoiceSell.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(invoiceSell);
            invoiceSell.Show();
        }

        private void IBButton_Click(object sender, EventArgs e)
        {
            NewInvoiceBuyForm invoiceBuy = new NewInvoiceBuyForm(this);
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
            SelectedType = 0;
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
            if (SelectedType == 1)
            {

            }
            else if (SelectedType == 0)
            {
                InvoiceSell temp = (InvoiceSell)ListBox1.SelectedItem;
                InvoiceSellShowForm form = new InvoiceSellShowForm(temp.ID);
                form.TopLevel = false;
                form.AutoScroll = true;
                NPPanel.Controls.Clear();
                NPPanel.Controls.Add(form);
                form.Show();
            }
            else if (ListBox1.DataBindings.GetType() == typeof(List<Product>))
            {

            }
        }

        private void InvoiceBuysButton_Click(object sender, EventArgs e)
        {
            SelectedType = 1;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("settings"))
            {
                int x;
                using (FileStream stream = new FileStream("settings", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        x = reader.ReadInt32();
                    }
                }
                if (x == 0)
                {
                    if(File.Exists("token")) File.Delete("token");
                }
            }
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream("settings", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(0);
                }
            }
            if (File.Exists("token")) File.Delete("token");
            Application.Exit();
        }
    }
}
