using ClientRest;
using ClientRest.Models.In;
using ClientRest.Models;
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
    public partial class NewInvoiceBuyForm : Form
    {
        List<ProductBuyOut> products = new List<ProductBuyOut>();
        List<Product> list = new List<Product>();
        Company company = new Company();
        RestClass rest = new RestClass();
        double sumNetto = 0;
        double sumBrutto = 0;
        public NewInvoiceBuyForm()
        {
            InitializeComponent();

            SellerNameCB.SelectedIndex = -1;
            SellerNameCB.ValueMember = "id";
            SellerNameCB.DisplayMember = "name";
            List<Seller> tempSellers = rest.getRequest<List<Seller>>(controller.sellers);
            tempSellers.Sort((p, q) => p.Name.CompareTo(q.Name));
            SellerNameCB.DataSource = tempSellers;
            SellerNameCB.SelectedIndex = -1;

            List<Category> tempCategories = rest.getRequest<List<Category>>(controller.categories);
            tempCategories.Sort((p, q) => p.Name.CompareTo(q.Name));
            CategoryCB.ValueMember = "id";
            CategoryCB.DisplayMember = "name";
            CategoryCB.DataSource = tempCategories;

            ProductNameCB.SelectedIndex = -1;


            List<Unit> tempUnits = rest.getRequest<List<Unit>>(controller.units);
            tempUnits.Sort((p, q) => p.Name.CompareTo(q.Name));
            UnitsCB.ValueMember = "id";
            UnitsCB.DisplayMember = "name";
            UnitsCB.DataSource = tempUnits;

            SummaryNetto.Text = sumNetto.ToString() + "zł";
            SummaryBrutto.Text = sumBrutto.ToString() + "zł";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //dodać jednostkę miary
            if (PricePerItemNUD.Value == 0)
            {
                MessageBox.Show("Cena nie może wynosić 0zł!");
                return;
            }
            else if (AmountTB.Value == 0)
            {
                MessageBox.Show("Ilość nie może wynosić 0!");
                return;
            }
            else
            {
                Product a = (Product)ProductNameCB.SelectedItem;
                ProductBuyOut temp = new ProductBuyOut();

                if (list.Where(p=>p.Name == ProductNameCB.Text).FirstOrDefault() == null)
                {
                    if(UnitsCB.SelectedItem != null)
                    {
                        ProductOut newProduct = new ProductOut
                        {
                            Name = ProductNameCB.Text,
                            Amount = (int)AmountTB.Value,
                            CategoryID = (Guid)CategoryCB.SelectedValue,
                            UnitID = (Guid)UnitsCB.SelectedValue,
                            PriceNetto = (double)PricePerItemNUD.Value,
                            Description = "",
                            TaxStageID = new Guid("ba78d24d-fef4-4b96-716f-08d7317c8e05")
                        };
                        Product tempProduct = rest.postRequest<Product, ProductOut>(newProduct, controller.products);
                        temp.ProductID = tempProduct.ID;
                        temp.Name = ProductNameCB.Text;
                        temp.TaxStageID = tempProduct.TaxStageID;
                        temp.Amount = (int)AmountTB.Value;
                        temp.Unit = UnitsCB.Text;
                        temp.PricePerItemNetto = (double)PricePerItemNUD.Value;
                        temp.PricePerItemBrutto = ((double)PricePerItemNUD.Value) * (rest.getRequest<TaxStage>(controller.taxstages, "/" + tempProduct.TaxStageID.ToString()).Stage + 100.0) / 100.0;  
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano jednostki miary!");
                    }
                }
                else
                {
                    temp.ProductID = Guid.Parse(ProductNameCB.SelectedValue.ToString());
                        temp.Name = ProductNameCB.Text;
                        temp.TaxStageID = a.TaxStageID;
                        temp.Amount = (int)AmountTB.Value;
                        temp.Unit = UnitsCB.Text;
                        temp.PricePerItemNetto = (double)PricePerItemNUD.Value;
                        temp.PricePerItemBrutto = ((double)PricePerItemNUD.Value) * (rest.getRequest<TaxStage>(controller.taxstages, "/" + a.TaxStageID.ToString()).Stage + 100.0) / 100.0;

                }
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
            if (CategoryCB.SelectedIndex != -1)
            {
                Category cat = (Category)CategoryCB.SelectedItem;
                list = rest.getRequest<List<Product>>(controller.products, "/bycategoryid/" + cat.ID.ToString());
                list.Sort((p, q) => p.Name.CompareTo(q.Name));
                ProductNameCB.ValueMember = "id";
                ProductNameCB.DisplayMember = "name";
                ProductNameCB.DataSource = list;
                ProductNameCB.SelectedIndex = -1;
                ProductAmountLabel2.Text = "";
                CategoryCBLabel.Focus();
            }
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
                ProductAmountLabel2.Text = product.Amount.ToString();
            }
            CategoryCBLabel.Focus();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ProductNameCB.SelectedValue = products[listView1.SelectedIndices[0]].ProductID;
                PricePerItemNUD.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[3].Text, System.Globalization.NumberStyles.Currency);
                AmountTB.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (SellerNameCB.Text != "" && SellerCityPostCodeTB.Text != "" && SellerNIPTB.Text != "" && SellerStreetNumberTB.Text != "" && listView1.Items.Count != 0)
            {
                double x = 0;
                foreach (ProductBuyOut item in products)
                {
                    x += item.PricePerItemNetto * item.Amount;
                }
                InvoiceBuyOut invoiceBuyOut = new InvoiceBuyOut();
                if (rest.getRequest<bool>(controller.sellers, "/check/" + SellerNIPTB.Text))
                {
                    Seller temp = (Seller)SellerNameCB.SelectedItem;
                    invoiceBuyOut.SellerID = temp.ID;
                }
                else
                {
                    SellerOut Sellerout = new SellerOut { Name = company.Name, City = company.City, NIP = company.NIP, Number = company.Number, PostCode = company.PostCode, Street = company.Street };
                    Seller temp = rest.postRequest<Seller,SellerOut>(Sellerout, controller.sellers);
                    invoiceBuyOut.SellerID = temp.ID;
                }
                invoiceBuyOut.IsPaid = false;
                invoiceBuyOut.PaymentDeadline = PAYDATE.Value;
                invoiceBuyOut.ProductsBuy = products;
                invoiceBuyOut.PriceNetto = x;
                InvoiceBuy responseInvoiceBuy = rest.postRequest<InvoiceBuy,InvoiceBuyOut>(invoiceBuyOut, controller.invoicebuys);
                Reset();

            }
            else
            {
                MessageBox.Show("Niewypełnione pola!");
            }
        }

        private void Reset()
        {
            ProductNameCB.SelectedIndex = -1;
            CategoryCB.SelectedIndex = -1;

            SellerCityPostCodeTB.Text = string.Empty;
            SellerNIPTB.Text = string.Empty;
            SellerStreetNumberTB.Text = string.Empty;
            SellerCityPostCodeTB.Text = string.Empty;
            SellerNameCB.SelectedIndex = -1;
            SellerNameCB.Text = string.Empty;

            products = new List<ProductBuyOut>();
            list = new List<Product>();

            ProductAmountLabel2.Text = string.Empty;
            AmountTB.Value = 0;
            PricePerItemNUD.Value = 0;

            SummaryBrutto.Text = "0.00zł";
            SummaryNetto.Text = "0.00zł";

            sumNetto = 0;
            sumBrutto = 0;



            listView1.Items.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                Product a = (Product)ProductNameCB.SelectedItem;
                int i = listView1.SelectedIndices[0];
                int amount = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                string priceNetto = listView1.SelectedItems[0].SubItems[3].Text;
                TaxStage taxStage = rest.getRequest<TaxStage>(controller.taxstages, "/" + a.TaxStageID.ToString());
                double ppn = double.Parse(priceNetto.Substring(0, priceNetto.Length - 3));
                double ppb = ppn * ((taxStage.Stage + 100.0) / 100.0);
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
                double xb = (products[i].PricePerItemBrutto * products[i].Amount) - (ppb * amount);
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
            Clipboard.SetText(temp.Substring(0, temp.Length - 2));
        }

        private void SummaryNetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string temp = SummaryNetto.Text;
            Clipboard.SetText(temp.Substring(0, temp.Length - 2));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int i = listView1.SelectedIndices[0];
                double sumN = 0;
                double sumB = 0;
                Product a = (Product)ProductNameCB.SelectedItem;
                TaxStage taxStage = rest.getRequest<TaxStage>(controller.taxstages, "/" + a.TaxStageID.ToString());
                sumN = (double)PricePerItemNUD.Value;
                sumB = ((double)PricePerItemNUD.Value) * (taxStage.Stage + 100.0) / 100.0;
                sumN *= (int)AmountTB.Value;
                sumB *= (int)AmountTB.Value;
                products.RemoveAt(i);
                listView1.Items.RemoveAt(i);
                sumNetto -= sumN;
                sumBrutto -= sumB;
                SummaryNetto.Text = sumNetto.ToString("N2") + "zł";
                SummaryBrutto.Text = sumBrutto.ToString("N2") + "zł";
                ((CurrencyManager)BindingContext[products]).Refresh();
            }
        }

        private void NIPButton_Click(object sender, EventArgs e)
        {
            string temp = SellerNIPTB.Text;
            bool a = false;
            if (temp != string.Empty)
            {
                temp = SellerNIPTB.Text.Replace("-", "");
                foreach (char c in temp)
                {
                    if (c < '0' || c > '9')
                        a = true;
                }
                if (a != true)
                {
                    company = rest.getRequest<Company>(controller.gus, "/" + temp);
                    if (company.Name == null)
                    {
                        SellerNameCB.Text = "Zły NIP!";
                    }
                    else
                    {
                        SellerNameCB.Text = company.Name;
                        if (company.Number[company.Number.Length - 1].Equals('/'))
                        {
                            SellerStreetNumberTB.Text = company.Street + " " + company.Number.Substring(0, company.Number.Length - 1);
                        }
                        else
                        {
                            SellerStreetNumberTB.Text = company.Street + " " + company.Number;
                        }
                        SellerCityPostCodeTB.Text = company.PostCode + " " + company.City;
                        SellerNIPTB.Text = company.NIP;
                    }
                }
            }
        }

        private void SellerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SellerNameCB.SelectedIndex != -1)
            {
                Seller Seller = (Seller)SellerNameCB.SelectedItem;
                SellerCityPostCodeTB.Text = Seller.PostCode;
                SellerNIPTB.Text = Seller.NIP;
                if (Seller.Number[Seller.Number.Length - 1].Equals('/'))
                {
                    SellerStreetNumberTB.Text = Seller.Street + " " + Seller.Number.Substring(0, Seller.Number.Length - 1);
                }
                else
                {
                    SellerStreetNumberTB.Text = Seller.Street + " " + Seller.Number;
                }
            }
            else
            {
                SellerCityPostCodeTB.Text = "";
                SellerNIPTB.Text = "";
                SellerStreetNumberTB.Text = "";
            }
        }

        private void ProductNameCB_DropDown(object sender, EventArgs e)
        {
            string a = ProductNameCB.Text;
            if (ProductNameCB.Text != "")
            {
                if (!(a.Length < 3))
                {
                    List<Product> temp = new List<Product>();
                    foreach (Product item in list)
                    {
                        if (item.Name.ToUpper().Contains(a.ToUpper()))
                        {
                            temp.Add(item);
                        }
                    }
                    ProductNameCB.DataSource = temp;
                    ProductNameCB.SelectedIndex = -1;
                    ProductNameCB.Text = a;
                }

            }
            else
            {
                ProductNameCB.DataSource = list;
            }
        }
    }
}
