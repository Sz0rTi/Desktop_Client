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

namespace ClientRest.Forms
{
    public partial class NewProduct : Form
    {
        RestClass rest = new RestClass();
        int CategoryId = 0;
        int TaxStageId = 0;
        int UnitId = 0;
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
            CategoryCB.ValueMember = "categoryid";
            CategoryCB.DisplayMember = "name";

            TaxStageCB.DataSource = rest.getRequest<List<TaxStage>>(controller.taxstages);
            TaxStageCB.ValueMember = "taxstageid";
            TaxStageCB.DisplayMember = "stage";

            UnitCB.DataSource = rest.getRequest<List<Unit>>(controller.units);
            UnitCB.ValueMember = "unitid";
            UnitCB.DisplayMember = "name";

            //CategoryCB_SelectedIndexChanged(this, EventArgs.Empty);
            //TaxStageCB_SelectedIndexChanged(this, EventArgs.Empty);
            //UnitCB_SelectedIndexChanged(this, EventArgs.Empty);
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
            if(CategoryId != -1 && UnitId != -1 && NameTB.Text != "" && PriceNUD.Value != 0 && DescriptionTB.Text != "")
            {
                Product product = new Product();
                product.ID = 0;
                product.Name = NameTB.Text;
                product.Description = DescriptionTB.Text;
                product.CategoryID = CategoryId;
                product.TaxStageID = TaxStageId;
                product.UnitID = UnitId;
                product.PriceNetto = (double) PriceNUD.Value;
                //rest.post(JsonConvert.SerializeObject(product));
                rest.post(product);
                
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
