using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Datum
    {
        public string date { get; set; }
        public double temperature { get; set; }
    }

    public class TemperatureHistory
    {
        public string period { get; set; }
        public string temperatureUnit { get; set; }
        public List<Datum> data { get; set; }
    }
    
}
