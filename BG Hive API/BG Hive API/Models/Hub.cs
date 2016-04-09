using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{

    public class Hub
    {
        public bool available { get; set; }
        public bool configured { get; set; }
        public string version { get; set; }
        public string latestVersion { get; set; }
        public string upgrade { get; set; }
        public string reason { get; set; }
        public string powerType { get; set; }
        public string connectionType { get; set; }
        public string connection { get; set; }
        public int onSince { get; set; }
        public int upTime { get; set; }
        public int uptime { get; set; }
        public int timezone { get; set; }
        public string daylightSaving { get; set; }
        public int behaviourId { get; set; }
        public string behaviourType { get; set; }
        public string model { get; set; }
        public string ip { get; set; }
        public string externalIp { get; set; }
        public int hardwareRevision { get; set; }
        public int zigbeeNetworkInfo { get; set; }
        public string macAddress { get; set; }
        public string name { get; set; }
        public bool upgrading { get; set; }
        public string bootLoaderVersion { get; set; }
        public string zigBeeTileFirmwareVersion { get; set; }
        public string kernelVersion { get; set; }
        public string rootFSVersion { get; set; }
        public int status { get; set; }
    }
}
