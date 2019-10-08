using ClientRest.Models.In;
using ClientRest.Models.In.In;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
            RestClass rest = new RestClass();
            CategoryCB.DataSource = rest.getRequest<List<Category>>(controller.categories);
            CategoryCB.ValueMember = "id";
            CategoryCB.DisplayMember = "name";
            CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
        }


        /*pobieranie produktów, filtrowanie ich pod względem wybranej kategorii i wrzucanie ich na listę.
         * */
        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            List<Product> products = new List<Product>();
            rest.endPoint = rest.address + controller.products.ToString();
            rest.httpMethod = httpVerb.GET;
            Category cat = (Category)CategoryCB.SelectedItem;
            products = rest.getRequest<List<Product>>(controller.products, "/bycategoryid/" + cat.ID.ToString());
            ProductsListBox.DataSource = products;
            ProductsListBox.ValueMember = "id";
            ProductsListBox.DisplayMember = "name";
            CategoryLabel.Focus();
        }
    }
}
