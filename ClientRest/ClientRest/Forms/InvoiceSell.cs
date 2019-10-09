using ClientRest.Models.In;
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
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //dodać jednostkę miary
            Product a = (Product)ProductNameCB.SelectedItem;
            ProductSellOut temp = new ProductSellOut { ProductID = Guid.Parse(ProductNameCB.SelectedValue.ToString()), Name = ProductNameCB.Text,
                TaxStageID = a.TaxStageID,
                Amount = (int)AmountTB.Value, Unit = UnitsCB.Text, PricePerItemNetto = (double)PricePerItemNUD.Value, PricePerItemBrutto = (double)PricePerItemNUD.Value + ((double)PricePerItemNUD.Value) * 0.23 };
            products.Add(temp);
            var item = new ListViewItem(new[] { temp.Name.ToString(), temp.Amount.ToString(), temp.Unit, temp.PricePerItemNetto.ToString("C2"), ((double)(temp.Amount*temp.PricePerItemNetto)).ToString("C2")});
            foreach(ListViewItem x in listView1.Items)
            {
                if (x.SubItems[0].Text == temp.Name)
                {
                    MessageBox.Show("Produkt znajduje się już na liście!");
                    return;
                }
            }
            listView1.Items.Add(item);
            ProductNameCB.SelectedIndex = -1;
            ((CurrencyManager)BindingContext[products]).Refresh();
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
            double sum = 0;
            foreach(ProductSellOut item in products)
            {
                sum += item.PricePerItemNetto * item.Amount;
            }
            InvoiceSellOut invoiceSellOut = new InvoiceSellOut();
            invoiceSellOut.ClientId = Guid.Parse("4750b501-9121-4432-959b-defb16f17e64");
            invoiceSellOut.IsPaid = false;
            invoiceSellOut.PaymentDeadline = PAYDATE.Value;
            invoiceSellOut.ProductsSell = products;
            invoiceSellOut.PriceNetto = sum;
            rest.postRequest<InvoiceSellOut>(invoiceSellOut, controller.invoicesells);
        }
    }
}
