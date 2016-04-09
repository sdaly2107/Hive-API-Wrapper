using BG_Hive_API.Interfaces;
using BG_Hive_API.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BG_Hive_API
{
    public enum HistoryPeriod
    {
        thisHour,
        today,
        thisWeek,
        thisMonth,
        thisYear
    }

    public enum ControlMode
    {
        OFF,
        MANUAL,
        SCHEDULE,
        BOOST
    }

    sealed public class Temperature : ControllerBase, ITemperatureController
    {
        private string _thermostatID;
        private string _widgetsResource;

        public Temperature(ISession session): base(session)
        {
            _widgetsResource = $"users/{session.Info.username}/widgets";
        }

        public TemperatureHistory History(HistoryPeriod period, int year = 0, int month = 0)
        {
            var parameters = new List<Parameter>()
            {
                new Parameter() { Name = "period", Value = period.ToString(), Type = ParameterType.GetOrPost },

            };

            if (0 != year)
            {
                parameters.Add(new Parameter() { Name = "year", Value = year.ToString(), Type = ParameterType.GetOrPost });
            }

            if (0 != month)
            {
                parameters.Add(new Parameter() { Name = "month", Value = month.ToString(), Type = ParameterType.GetOrPost });
            }

            if (null == _thermostatID)
            {
                IDeviceController deviceController = new Devices(_session);
                var thermostat = deviceController.Details().Single(x => x.type == "HAHVACThermostatSLR2");
                _thermostatID = HttpUtility.UrlEncode(thermostat.id);
            }

            return RequestWithDeserialise<TemperatureHistory>($"{_widgetsResource}/temperature/{_thermostatID}/history", Method.GET, parameters.ToArray());
        }

        public void Set(int temperature, string unit = "C")
        {
            if (temperature < 0 || temperature > 30)
            {
                throw new ArgumentOutOfRangeException("Temparature must be between 0 and 30 degress celcius.");
            }

            var request = new RestRequest($"{_widgetsResource}/climate/targetTemperature", Method.PUT);
            request.AddParameter("temperature", temperature.ToString());
            request.AddParameter("temperatureUnit", unit);
            request.AddCookie("ApiSession", _session.Info.ApiSession);

           _session.Client.Execute(request);
        }

        public CurrentTemperature Current()
        {
            return RequestWithDeserialise<CurrentTemperature>($"{_widgetsResource}/temperature", Method.GET);
        }

        public Schedule Schedule()
        {
            return RequestWithDeserialise<Schedule>($"{_widgetsResource}/climate/controls/schedule", Method.GET);
        }

        public ControlModeInfo ControlInfo()
        {
            return RequestWithDeserialise<ControlModeInfo>($"{_widgetsResource}/climate/control", Method.GET);
        }

        public void SetControl(ControlMode mode)
        {
            var request = new RestRequest($"{_widgetsResource}/climate/control", Method.PUT);
            request.AddParameter("control", mode.ToString());
            request.AddCookie("ApiSession", _session.Info.ApiSession);

            _session.Client.Execute(request);
        }
    }
}
