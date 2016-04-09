using BG_Hive_API.Models;
using RestSharp;

namespace BG_Hive_API.Interfaces
{
    public interface ISession
    {
        IRestClient Client { get; }
        SessionInfo Info { get; }
        IDeviceController DeviceController { get; }
        ITemperatureController TemperatureController { get; }

        void Login();
        void Logout();
    }
}
