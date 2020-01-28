using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models.In
{
    public class PaymentMethodIn
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
