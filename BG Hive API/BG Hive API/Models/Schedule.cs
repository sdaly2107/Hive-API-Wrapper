using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class Formatting
    {
        public string locale { get; set; }
        public string temperatureUnit { get; set; }
        public string currencyUnit { get; set; }
        public string timezoneOffset { get; set; }
    }

    public class Monday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Tuesday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Wednesday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Thursday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Friday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Saturday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Sunday
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Days
    {
        public List<Monday> monday { get; set; }
        public List<Tuesday> tuesday { get; set; }
        public List<Wednesday> wednesday { get; set; }
        public List<Thursday> thursday { get; set; }
        public List<Friday> friday { get; set; }
        public List<Saturday> saturday { get; set; }
        public List<Sunday> sunday { get; set; }
    }

    public class Previous
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Current
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class Next
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class NextPlusOne
    {
        public double temperature { get; set; }
        public string time { get; set; }
        public string name { get; set; }
        public int @event { get; set; }
        public int setpoint { get; set; }
    }

    public class RelativeSetpoints
    {
        public Previous previous { get; set; }
        public Current current { get; set; }
        public Next next { get; set; }
        public NextPlusOne nextPlusOne { get; set; }
    }

    public class Schedule
    {
        public string mode { get; set; }
        public string control { get; set; }
        public string complexity { get; set; }
        public List<string> setpoints { get; set; }
        public Formatting formatting { get; set; }
        public Days days { get; set; }
        public RelativeSetpoints relativeSetpoints { get; set; }
    }
}
