using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest
{
    class Test
    {
        //[JsonProperty("id")]
        public int ID { get; set; }
        //[JsonProperty("name")]
        public string Name { get; set; }
        //[JsonProperty("isComplete")]
        public bool IsComplete { get; set; }

    }
}
