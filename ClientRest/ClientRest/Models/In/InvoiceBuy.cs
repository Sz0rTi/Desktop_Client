using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.In
{
    public class InvoiceBuy
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid SellerID { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public Guid PaymentMethodID { get; set; }
        public double PriceNetto { get; set; }
        public double PriceBrutto { get; set; }
        public bool IsPaid { get; set; }
        public string UserID { get; set; }
        public List<ProductBuy> ProductsBuy { get; set; }
    }
}
