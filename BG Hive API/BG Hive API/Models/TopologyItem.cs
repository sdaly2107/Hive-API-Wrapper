using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Child
    {
        public string id { get; set; }
    }

    public class TopologyItem
    {
        public string id { get; set; }
        public List<Child> children { get; set; }
    }
}
