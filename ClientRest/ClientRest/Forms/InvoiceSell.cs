﻿using ClientRest.Models.In;
using ClientRest.Models.In.In;
using ClientRest.Models.Out;
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
    public partial class InvoiceSell : Form
    {
        List<ProductSellOut> products = new List<ProductSellOut>();
        RestClass rest = new RestClass();
        double sumNetto = 0;
        double sumBrutto = 0;
        public InvoiceSell()
        {
            InitializeComponent();
            CategoryCB.ValueMember = "id";
            CategoryCB.DisplayMember = "name";
            CategoryCB.DataSource = rest.getRequest<List<Category>>(controller.categories);

            //CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
            //ProductNameCB_SelectedIndexChanged(this, EventArgs.Empty);

            UnitsCB.ValueMember = "id";
            UnitsCB.DisplayMember = "name";
            UnitsCB.DataSource = rest.getRequest<List<Unit>>(controller.units);

            SummaryNetto.Text = sumNetto.ToString() + "zł";
            SummaryBrutto.Text = sumBrutto.ToString() + "zł";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //dodać jednostkę miary
            if(PricePerItemNUD.Value == 0)
            {
                MessageBox.Show("Cena nie może wynosić 0zł!");
                return;
            }
            else if(AmountTB.Value == 0)
            {
                MessageBox.Show("Ilość nie może wynosić 0!");
                return;
            }
            else
            {
                Product a = (Product)ProductNameCB.SelectedItem;
                ProductSellOut temp = new ProductSellOut
                {
                    ProductID = Guid.Parse(ProductNameCB.SelectedValue.ToString()),
                    Name = ProductNameCB.Text,
                    TaxStageID = a.TaxStageID,
                    Amount = (int)AmountTB.Value,
                    Unit = UnitsCB.Text,
                    PricePerItemNetto = (double)PricePerItemNUD.Value,
                    PricePerItemBrutto = ((double)PricePerItemNUD.Value) * (rest.getRequest<TaxStage>(controller.taxstages, "/" + a.TaxStageID.ToString()).Stage + 100.0) / 100.0
                };
                products.Add(temp);
                var item = new ListViewItem(new[] { temp.Name.ToString(), temp.Amount.ToString(), temp.Unit, temp.PricePerItemNetto.ToString("C2"), ((double)(temp.Amount * temp.PricePerItemNetto)).ToString("C2") });
                foreach (ListViewItem x in listView1.Items)
                {
                    if (x.SubItems[0].Text == temp.Name)
                    {
                        MessageBox.Show("Produkt znajduje się już na liście!");
                        return;
                    }
                }
                sumNetto += (temp.PricePerItemNetto * temp.Amount);
                sumBrutto += (temp.PricePerItemBrutto * temp.Amount);
                listView1.Items.Add(item);
                ProductNameCB.SelectedIndex = -1;
                SummaryNetto.Text = sumNetto.ToString("N2") + "zł";
                SummaryBrutto.Text = sumBrutto.ToString("N2") + "zł";
                ((CurrencyManager)BindingContext[products]).Refresh();
            } 
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)CategoryCB.SelectedItem;
            List<Product> list = rest.getRequest<List<Product>>(controller.products, "/bycategoryid/" + cat.ID.ToString());
            ProductNameCB.ValueMember = "id";
            ProductNameCB.DisplayMember = "name";
            ProductNameCB.DataSource = list;
            CategoryCBLabel.Focus();
        }

        private void InvoiceSell_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            
        }

        private void ProductNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* JEŚLI JEST - ostatnia cena dla danego klianta, dla danego produktu.
               Uśredniona cena zakupu. 
            */
            Product product = (Product)ProductNameCB.SelectedItem;
            if (ProductNameCB.SelectedIndex == -1) UnitsCB.SelectedIndex = -1;
            else
            {
                UnitsCB.SelectedValue = rest.getRequest<Unit>(controller.units, "/byproductid/" + product.ID.ToString()).ID;
            }
            CategoryCBLabel.Focus();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                ProductNameCB.SelectedValue = products[listView1.SelectedIndices[0]].ProductID;
                PricePerItemNUD.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[3].Text,System.Globalization.NumberStyles.Currency);
                AmountTB.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            double x = 0;
            foreach(ProductSellOut item in products)
            {
                x += item.PricePerItemNetto * item.Amount;
            }
            InvoiceSellOut invoiceSellOut = new InvoiceSellOut();
            invoiceSellOut.ClientId = Guid.Parse("4750b501-9121-4432-959b-defb16f17e64");
            invoiceSellOut.IsPaid = false;
            invoiceSellOut.PaymentDeadline = PAYDATE.Value;
            invoiceSellOut.ProductsSell = products;
            invoiceSellOut.PriceNetto = x;
            rest.postRequest<InvoiceSellOut>(invoiceSellOut, controller.invoicesells);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                Product a = (Product)ProductNameCB.SelectedItem;
                int i = listView1.SelectedIndices[0];
                int amount = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                string priceNetto = listView1.SelectedItems[0].SubItems[3].Text;
                TaxStage taxStage = rest.getRequest<TaxStage>(controller.taxstages, "/" + a.TaxStageID.ToString());
                double ppn = double.Parse(priceNetto.Substring(0,priceNetto.Length - 4));
                products[i].ProductID = Guid.Parse(ProductNameCB.SelectedValue.ToString());
                products[i].Name = ProductNameCB.Text;
                products[i].TaxStageID = a.TaxStageID;
                products[i].Amount = (int)AmountTB.Value;
                products[i].Unit = UnitsCB.Text;
                products[i].PricePerItemNetto = (double)PricePerItemNUD.Value;
                products[i].PricePerItemBrutto = ((double)PricePerItemNUD.Value) * (taxStage.Stage + 100.0) / 100.0;
                var item = new ListViewItem(new[] { products[i].Name.ToString(), products[i].Amount.ToString(),
                    products[i].Unit, products[i].PricePerItemNetto.ToString("C2"),
                    (products[i].Amount * products[i].PricePerItemNetto).ToString("C2") });
                double x = (products[i].PricePerItemNetto * products[i].Amount) - (ppn * amount);
                double xb = (products[i].PricePerItemBrutto * products[i].Amount) - (ppn*(taxStage.Stage+100.0)/100.0) * amount;
                sumNetto += x;
                sumBrutto += xb;
                listView1.Items[i] = item;
                SummaryNetto.Text = sumNetto.ToString("N2") + "zł";
                SummaryBrutto.Text = sumBrutto.ToString("N2") + "zł";
                ((CurrencyManager)BindingContext[products]).Refresh();
                
            }
        }

        private void SummaryBrutto_DoubleClick(object sender, EventArgs e)
        {
            string temp = SummaryBrutto.Text;
            Clipboard.SetText(temp.Substring(0,temp.Length-2));
        }

        private void SummaryNetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string temp = SummaryNetto.Text;
            Clipboard.SetText(temp.Substring(0, temp.Length - 2));
        }
    }
}
