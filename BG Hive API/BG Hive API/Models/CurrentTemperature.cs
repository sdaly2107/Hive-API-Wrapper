using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Averages
    {
        public int today { get; set; }
        public int yesterday { get; set; }
        public int lastWeek { get; set; }
    }

    public class Inside
    {
        public double now { get; set; }
        public Averages averages { get; set; }
    }

    public class Weather
    {
        public string now { get; set; }
        public string description { get; set; }
    }

    public class Outside
    {
        public int now { get; set; }
        public Weather weather { get; set; }
    }

    public class CurrentTemperature
    {
        public string temperatureUnit { get; set; }
        public Inside inside { get; set; }
        public Outside outside { get; set; }
    }


}
