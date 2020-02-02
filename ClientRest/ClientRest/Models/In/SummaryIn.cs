using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.In
{
    public class SummaryIn
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double SumBought { get; set; }
        public double SumSold { get; set; }
        public double SumEarned { get; set; }
        public string UserID { get; set; }
        public List<SummaryProductBuy> SummaryProductBuys { get; set; }
        public List<SummaryProductSell> SummaryProductSells { get; set; }
    }
}
