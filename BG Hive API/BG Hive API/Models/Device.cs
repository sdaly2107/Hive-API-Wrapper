using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Channels
    {
        public bool presence { get; set; }
        public bool tamper { get; set; }
        public double? temperature { get; set; }
        public double? battery { get; set; }
        public int? batteryPercentage { get; set; }
        public int? batteryLevel { get; set; }
        public int signal { get; set; }
    }

    public class Device
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string nodeType { get; set; }
        public Channels channels { get; set; }
        public int maxNumSetpoints { get; set; }

        public List<string> hubIds { get; set; }
    }

    
}
