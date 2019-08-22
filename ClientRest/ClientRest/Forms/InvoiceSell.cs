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
            CategoryCB.DataSource = rest.getRequest<List<Category>>(controller.categories);
            CategoryCB.ValueMember = "id";
            CategoryCB.DisplayMember = "name";
            CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
            ProductNameCB.ValueMember = "id";
            ProductNameCB.DisplayMember = "name";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductSellOut temp = new ProductSellOut { ProductID = Guid.Parse(ProductNameCB.SelectedValue.ToString()), Name = ProductNameCB.SelectedText, Amount = (int)AmountTB.Value, PricePerItemNetto = (double)PricePerItemNUD.Value, PricePerItemBrutto = (double)PricePerItemNUD.Value + ((double)PricePerItemNUD.Value) * 0.23 };
            products.Add(temp);
            ProductsList.dataso
            ((CurrencyManager)BindingContext[products]).Refresh();
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)CategoryCB.SelectedItem;
            List<Product> list = rest.getRequest<List<Product>>(controller.products, "/bycategoryid/" + cat.ID.ToString());
            ProductNameCB.DataSource = list;
        }
    }
}
