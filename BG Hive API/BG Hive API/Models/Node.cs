using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class Node
    {
        public List<Link> links { get; set; }
        public List<string> content { get; set; }
    }
}
