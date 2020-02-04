using ClientRest.Models.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class ProductsList : Form
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();
        public List<TaxStage> TaxStages { get; set; } = new List<TaxStage>();
        public ProductsList()
        {
            InitializeComponent();
            RestClass rest = new RestClass();
            Categories = rest.getRequest<List<Category>>(controller.categories);
            ProductsCB.AutoCompleteMode = AutoCompleteMode.None;
            if (Categories.Count != 0)
            {
                CategoryCB.DataSource = Categories;
                CategoryCB.ValueMember = "id";
                CategoryCB.DisplayMember = "name";
                //CategoryCB.SelectedIndex = -1;
                //CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);

                ProductsCB.ValueMember = "id";
                ProductsCB.DisplayMember = "name";

            }
            else
            {
                CategoryCB.Hide();
                CategoryLabel.Hide();
                InfoLabel.Text = "Brak produktów!";
            }
        }


        /*pobieranie produktów, filtrowanie ich pod względem wybranej kategorii i wrzucanie ich na listę.
         * */
        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            //rest.endPoint = rest.address + controller.products.ToString();
            //rest.httpMethod = httpVerb.GET;
            ProductsCB.SelectedIndexChanged -= ProductsCB_SelectedIndexChanged;
            Category cat = (Category)CategoryCB.SelectedItem;
            Products = rest.getRequest<List<Product>>(controller.products, "/bycategoryid/" + cat.ID.ToString());
            Units = rest.getRequest<List<Unit>>(controller.units);
            TaxStages = rest.getRequest<List<TaxStage>>(controller.taxstages);
            CategoryLabel.Focus();
            ProductsCB.SelectedIndexChanged += ProductsCB_SelectedIndexChanged;
        }

        private void ProductsCB_DropDown(object sender, EventArgs e)
        {
            string a = ProductsCB.Text;
            if (ProductsCB.Text != "")
            {
                if (ProductsCB.Text.Length > 0)
                {
                    List<Product> temp = new List<Product>();
                    foreach(Product item in Products)
                    {
                        if (item.Name.ToUpper().Contains(a.ToUpper()))
                        {
                            temp.Add(item);
                        }
                    }
                    ProductsCB.DataSource = temp;
                    ProductsCB.SelectedIndex = -1;
                    ProductsCB.Text = a;
                }

            }
            else
            {
                ProductsCB.DataSource = Products;
            }
        }

        private void ProductsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProductsCB.SelectedIndex != -1)
            {
                var product = (Product)ProductsCB.SelectedItem;
                NameLabel.Text = product.Name;
                AmountLabel.Text = product.Amount.ToString();
                UnitLabel.Text = Units.Where(u => u.ID == product.UnitID).First().Name;
                PriceLabel.Text = product.PriceNetto.ToString("C2");
                TaxStageLabel.Text = TaxStages.Where(t => t.ID == product.TaxStageID).First().Stage.ToString();
            }
        }
    }
}
