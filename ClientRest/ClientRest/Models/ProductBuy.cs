using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models
{
    class ProductBuy
    {
        public int ProductBuyId { get; set; }
        public int InvoiceBuyId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double PricePerItemNetto { get; set; }
        public double PricePerItemBrutto { get; set; }
    }
}
