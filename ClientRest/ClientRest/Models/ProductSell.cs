using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models
{
    class ProductSell
    {
        public int ProductSellId { get; set; }
        public int InvoiceSellId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double PricePerItemNetto { get; set; }
        public double PricePerItemBrutto { get; set; }
        public int TaxStageId { get; set; }
    }
}
