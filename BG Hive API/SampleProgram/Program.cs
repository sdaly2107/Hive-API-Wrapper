using BG_Hive_API;
using BG_Hive_API.Interfaces;
using System;
using System.Linq;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            ISession hive = new Session("YOUR_LOGIN", "YOUR_PASSWORD");

            hive.Login();

            ITemperatureController temp = hive.TemperatureController;

            //show inside temp, outside temp and weather
            var currentTemp = temp.Current();
            Console.WriteLine(currentTemp.inside.now);
            Console.WriteLine(currentTemp.outside.now);
            Console.WriteLine(currentTemp.outside.weather);

            //set temperature to 20 degrees celcius
            temp.Set(20);

            //get temperature history for today
            var temphistory = temp.History(HistoryPeriod.today);
            foreach(var historyItem in temphistory.data)
            {
                Console.WriteLine($"{historyItem.date} = {historyItem.temperature}");
            }

            //get temperature history for Jan 2016 
            temphistory = temp.History(HistoryPeriod.thisMonth, 2016, 1);

            //get temperature schedule and show temp of first schedule on Sunday
            var schedule = temp.Schedule();
            Console.WriteLine(schedule.days.sunday.First().temperature);

            //show current control mode, example manual, off, override 
            var controlInfo = temp.ControlInfo();
            Console.WriteLine(controlInfo.control);

            //switch heating off
            temp.SetControl(ControlMode.OFF);

            //switch back to schedule
            temp.SetControl(ControlMode.SCHEDULE);

            //turn on boost
            temp.SetControl(ControlMode.BOOST);


            IDeviceController devices = hive.DeviceController;

            //output number of devices and info about them - this will include thermostat, hub etc
            var deviceInfo = devices.Details();
            Console.WriteLine(deviceInfo.Count());
            foreach(var device in deviceInfo)
            {
                Console.WriteLine($"Device {device.name} ID is {device.id} and is a {device.type}");
            }

            //show device events
            var history = devices.EventHistory();
            foreach(var @event in history.events)
            {
                Console.WriteLine(@event.time);
                Console.WriteLine(@event.type);
            }

            //get history with limit of 10
            devices.EventHistory(10);

            //show hub details
            var hub = devices.HubDetails();
            Console.WriteLine(hub.name);
            Console.WriteLine(hub.ip);
            Console.WriteLine(hub.macAddress);
            Console.WriteLine(hub.upTime);

            


            hive.Logout();
        }
    }
}
