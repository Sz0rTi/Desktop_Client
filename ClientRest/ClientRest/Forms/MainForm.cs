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
        public MainForm()
        {
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
            InvoiceSell invoiceSell = new InvoiceSell();
            invoiceSell.TopLevel = false;
            invoiceSell.AutoScroll = true;
            NPPanel.Controls.Clear();
            NPPanel.Controls.Add(invoiceSell);
            invoiceSell.Show();
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
    }
}
