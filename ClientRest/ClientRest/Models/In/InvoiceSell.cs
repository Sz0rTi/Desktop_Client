using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.In
{
    public class InvoiceSell
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public Guid ClientID { get; set; }
        public double PriceNetto { get; set; }
        public double PriceBrutto { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public bool IsPaid { get; set; }
    }
}
