using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.In
{
    public class ProductSell
    {
        public Guid ID { get; set; }
        public Guid InvoiceSellID { get; set; }
        public Guid ProductID { get; set; }
        public int Amount { get; set; }
        public double PricePerItemNetto { get; set; }
        public double PricePerItemBrutto { get; set; }
    }
}
