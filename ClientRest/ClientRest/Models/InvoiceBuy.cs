﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models
{
    public class InvoiceBuy
    {
        public Guid ID { get; set; }
        public Guid SellerID { get; set; }
        public DateTime Date { get; set; }
        public double PriceNetto { get; set; }
        public double PriceBrutto { get; set; }
        public bool IsPaid { get; set; }
        public List<ProductBuy> Products { get; set; }
    }
}
