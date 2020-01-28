using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.Out
{
    public class InvoiceBuyOut
    {
        public Guid SellerID { get; set; }
        public Guid PaymentMethodID { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public double PriceNetto { get; set; }
        public double PriceBrutto { get; set; }
        public bool IsPaid { get; set; }
        public string Code { get; set; }
        public List<ProductBuyOut> ProductsBuy { get; set; }
    }
}
