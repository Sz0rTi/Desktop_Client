using ClientRest.Models.In;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class ProductsList : Form
    {
        public List<Category> Categories { get; set; }
        public ProductsList()
        {
            InitializeComponent();
            RestClass rest = new RestClass();
            Categories = rest.getRequest<List<Category>>(controller.categories);
            if (Categories.Count != 0)
            {
                CategoryCB.DataSource = Categories;
                CategoryCB.ValueMember = "id";
                CategoryCB.DisplayMember = "name";
                CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                CategoryCB.Hide();
                ProductsListBox.Hide();
                CategoryLabel.Hide();
                InfoLabel.Text = "Brak produktów!";
            }
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
