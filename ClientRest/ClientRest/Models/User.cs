using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid RoleID { get; set; }
    }
}
