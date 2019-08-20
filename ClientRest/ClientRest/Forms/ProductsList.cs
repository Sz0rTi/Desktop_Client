using ClientRest.Models;
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
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
            RestClass rest = new RestClass();
            CategoryCB.DataSource = rest.getRequest<List<Category>>(controller.categories);
            CategoryCB.ValueMember = "categoryid";
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
            products = rest.JsonDeserialize<List<Product>>(rest.makeRequest());
            Guid fid = new Guid(CategoryCB.SelectedValue.ToString());
            ProductsListBox.DataSource = products.FindAll(m => m.CategoryID == fid);
            ProductsListBox.ValueMember = "productid";
            ProductsListBox.DisplayMember = "name";
        }
    }
}
