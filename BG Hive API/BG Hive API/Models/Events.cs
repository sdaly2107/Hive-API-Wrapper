using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Properties
    {
        public string deviceType { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public string nodeName { get; set; }
        public object parent { get; set; }
        public string time { get; set; }
        public Properties properties { get; set; }
    }

    public class Events
    {
        public List<Event> events { get; set; }
    }
}
