using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class ControlModeInfo
    {
        public string control { get; set; }
        public bool confirmed { get; set; }
        public List<string> validControls { get; set; }
    }
}
