using BG_Hive_API.Models;
using System.Collections.Generic;

namespace BG_Hive_API.Interfaces
{
    public interface IDeviceController
    {
        List<Device> Details();
        Hub HubDetails();
        Node Nodes();
        Events EventHistory(int limit = 0);
        List<TopologyItem> TopologyDetails();
    }
}
