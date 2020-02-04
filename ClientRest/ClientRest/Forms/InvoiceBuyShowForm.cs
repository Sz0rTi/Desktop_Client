using ClientRest;
using ClientRest.Models;
using ClientRest.Models.In;
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
    public partial class InvoiceBuyShowForm : Form
    {
        InvoiceBuy invoice = new InvoiceBuy();
        List<ProductBuyOut> products = new List<ProductBuyOut>();
        List<Product> list = new List<Product>();
        public List<Unit> Units { get; set; }
        public List<TaxStage> TaxStages { get; set; }
        public Seller Seller { get; set; }
        public PaymentMethodIn PaymentMethod { get; set; }
        Company company = new Company();
        RestClass rest = new RestClass();
        double sumNetto = 0;
        double sumBrutto = 0;
        public InvoiceBuyShowForm(Guid id)
        {
            InitializeComponent();
            this.invoice = rest.getRequest<InvoiceBuy>(controller.invoicebuys, "/" + id.ToString());
            this.Units = rest.getRequest<List<Unit>>(controller.units);
            TaxStages = rest.getRequest<List<TaxStage>>(controller.taxstages);
            Seller = rest.getRequest<Seller>(controller.sellers, "/" + invoice.SellerID.ToString());
            PaymentMethod = rest.getRequest<PaymentMethodIn>(controller.payment, "/" + invoice.PaymentMethodID.ToString());
            if (invoice.IsPaid) PaidButton.Hide();
            foreach (ProductBuy item in invoice.ProductsBuy)
            {
                Product temp = rest.getRequest<Product>(controller.products, "/" + item.ProductID.ToString());
                listView1.Items.Add(new ListViewItem(new[] {
                    temp.Name.ToString(),
                    item.Amount.ToString(),
                    Units.First(u => u.ID == temp.UnitID).Name,
                    item.PricePerItemNetto.ToString("C2"),
                    item.PricePerItemBrutto.ToString("C2"),
                    TaxStages.Where(t=>t.ID==item.TaxStageID).First().Stage.ToString()+"%",
                    (item.PricePerItemNetto*item.Amount).ToString("C2"),
                    (item.PricePerItemBrutto*item.Amount).ToString("C2"),
                    ((double)(item.Amount * item.PricePerItemNetto)).ToString("C2")
                }));
            }
            listView1.Refresh();
            PMLabel.Text = PaymentMethod.Name;
            PDLabel.Text = invoice.PaymentDeadline.ToShortDateString() + ".r";
            if (invoice.IsPaid) IsPaidLabel.Text = "Tak";
            else IsPaidLabel.Text = "Nie";
            CNameLabel.Text = Seller.Name;
            CStreetLabel.Text = Seller.Street;
            CCodeLabel.Text = Seller.PostCode + " " + Seller.City;
            CNipLabel.Text = Seller.NIP;
            CodeLabel.Text = invoice.Code;
            DateLabel2.Text = invoice.Date.ToShortDateString() + ".r";

            SummaryNetto.Text = invoice.PriceNetto.ToString("C2");
            SummaryBrutto.Text = invoice.PriceBrutto.ToString("C2");
        }



        private void InvoiceBuy_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

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

        private void PaidButton_Click(object sender, EventArgs e)
        {
            invoice = rest.getRequest<InvoiceBuy>(controller.invoicebuys, "/payinvoice/" + invoice.ID.ToString());
            IsPaidLabel.Text = "Tak";
        }
    }
}
