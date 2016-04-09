using BG_Hive_API.Models;

namespace BG_Hive_API.Interfaces
{
    public interface ITemperatureController
    {
        TemperatureHistory History(HistoryPeriod period, int year = 0, int month = 0);
        void Set(int temperature, string unit = "C");
        CurrentTemperature Current();
        Schedule Schedule();
        ControlModeInfo ControlInfo();
        void SetControl(ControlMode mode);
    }
}
