using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.Out
{
    public class InvoiceSellOut
    {
        public Guid ClientId { get; set; }
        public double PriceNetto { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public bool IsPaid { get; set; }
        public List<ProductSellOut> ProductsSell { get; set; }
    }
}
