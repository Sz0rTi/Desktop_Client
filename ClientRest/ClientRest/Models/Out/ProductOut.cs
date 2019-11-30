using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.Out
{
    public class ProductOut
    {
        public string Name { get; set; }
        public double PriceNetto { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
        public Guid TaxStageID { get; set; }
        public Guid UnitID { get; set; }
        public int Amount { get; set; }
    }
}
