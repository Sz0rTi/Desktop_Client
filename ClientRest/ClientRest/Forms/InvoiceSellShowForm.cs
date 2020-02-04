using ClientRest.Models;
using ClientRest.Models.In;
using ClientRest.Models.Out;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class InvoiceSellShowForm : Form
    {
        InvoiceSell invoice = new InvoiceSell();
        List<ProductSellOut> products = new List<ProductSellOut>();
        List<Product> list = new List<Product>();
        public List<Unit> Units { get; set; }
        public List<TaxStage> TaxStages { get; set; }
        public Client Client { get; set; }
        public PaymentMethodIn PaymentMethod { get; set; }
        Company company = new Company();
        RestClass rest = new RestClass();
        double sumNetto = 0;
        double sumBrutto = 0;
        public InvoiceSellShowForm(Guid id)
        {
            InitializeComponent();
            this.invoice = rest.getRequest<InvoiceSell>(controller.invoicesells, "/" + id.ToString());
            this.Units = rest.getRequest<List<Unit>>(controller.units);
            TaxStages = rest.getRequest <List<TaxStage>>(controller.taxstages);
            Client = rest.getRequest<Client>(controller.clients, "/" + invoice.ClientID.ToString());
            PaymentMethod = rest.getRequest<PaymentMethodIn>(controller.payment, "/" + invoice.PaymentMethodID.ToString());
            if (invoice.IsPaid) PaidButton.Hide();
            foreach (ProductSell item in invoice.ProductsSell)
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
            CNameLabel.Text = Client.Name;
            CStreetLabel.Text = Client.Street;
            CCodeLabel.Text = Client.PostCode + " " + Client.City;
            CNipLabel.Text = Client.NIP;
            CodeLabel.Text = invoice.Code;
            DateLabel2.Text = invoice.Date.ToShortDateString() + ".r";

            SummaryNetto.Text = invoice.PriceNetto.ToString("C2");
            SummaryBrutto.Text = invoice.PriceBrutto.ToString("C2");
        }



        private void InvoiceSell_Load(object sender, EventArgs e)
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
            invoice = rest.getRequest<InvoiceSell>(controller.invoicesells, "/payinvoice/" + invoice.ID.ToString());
            IsPaidLabel.Text = "Tak";
        }
    }
}
