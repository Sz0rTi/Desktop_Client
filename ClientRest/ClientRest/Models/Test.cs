﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest
{
    public class Test
    {
        //[JsonProperty("id")]
        public Guid ID { get; set; }
        //[JsonProperty("name")]
        public string Name { get; set; }
        //[JsonProperty("isComplete")]
        public bool IsComplete { get; set; }

    }
}
