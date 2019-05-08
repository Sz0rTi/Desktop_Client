using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double PriceNetto { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int TaxStageId { get; set; }
        public int UnitId { get; set; }
    }
}
