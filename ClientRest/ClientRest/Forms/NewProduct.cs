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
using Newtonsoft.Json;
using ClientRest.Models.In;
using ClientRest.Models.Out;

namespace ClientRest.Forms
{
    public partial class NewProduct : Form
    {
        RestClass rest = new RestClass();
        int CategoryId = -1;
        int TaxStageId = -1;
        int UnitId = -1;
        public NewProduct()
        {
            InitializeComponent();
            
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach(Product item in rest.getRequest<List<Product>>(controller.products))
            {
                source.Add(item.Name);
            }
            NameTB.AutoCompleteCustomSource = source;
            

            CategoryCB.DataSource = rest.getRequest<List<Category>>(controller.categories);
            CategoryCB.ValueMember = "id";
            CategoryCB.DisplayMember = "name";

            TaxStageCB.DataSource = rest.getRequest<List<TaxStage>>(controller.taxstages);
            TaxStageCB.ValueMember = "id";
            TaxStageCB.DisplayMember = "stage";

            UnitCB.DataSource = rest.getRequest<List<Unit>>(controller.units);
            UnitCB.ValueMember = "id";
            UnitCB.DisplayMember = "name";

            CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
            TaxStageCB_SelectedIndexChanged(this, EventArgs.Empty);
            UnitCB_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryId = rest.intFromValue(CategoryCB.SelectedValue.ToString());
        } 

        private void TaxStageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaxStageId = rest.intFromValue(TaxStageCB.SelectedValue.ToString());
        }

        private void UnitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitId = rest.intFromValue(UnitCB.SelectedValue.ToString());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(/*CategoryId != Guid.Empty && UnitId != Guid.Empty && NameTB.Text != "" && PriceNUD.Value != 0 && DescriptionTB.Text != ""*/true)
            {
                ProductOut product = new ProductOut();
                List<Category> categories = rest.getRequest<List<Category>>(controller.categories);
                product.Name = NameTB.Text;
                product.Description = DescriptionTB.Text;
                product.CategoryID = Guid.Parse(CategoryCB.SelectedValue.ToString());
                product.TaxStageID = Guid.Parse(TaxStageCB.SelectedValue.ToString());
                product.UnitID = Guid.Parse(UnitCB.SelectedValue.ToString());
                product.PriceNetto = (double) PriceNUD.Value;
                product.Amount = (int)AmountNUD.Value;
                Product responseProduct = rest.postRequest<Product,ProductOut>(product,controller.products);
                //rest.post(product);
                
                /*Product a = rest.postRequest<Product>(product, controller.products);
                if (product == a)
                {
                    IsOk.Text = "OK";
                }
                else
                {
                    IsOk.Text = "COŚ NIE PYKŁO"; ;
                }*/
            }
            else
            {
                IsOk.Text = "COŚ NIE PYKŁO";
            }
        }

        
    }
}
