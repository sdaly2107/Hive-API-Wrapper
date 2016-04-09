using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Hive_API.Models
{
    public class SessionInfo
    {
        public List<string> hubIds { get; set; }
        public int userId { get; set; }
        public int partnerId { get; set; }
        public string username { get; set; }
        public bool tandcConfirmed { get; set; }
        public int extCustomerLevel { get; set; }
        public List<object> permissions { get; set; }
        public string ApiSession { get; set; }
    }
}
