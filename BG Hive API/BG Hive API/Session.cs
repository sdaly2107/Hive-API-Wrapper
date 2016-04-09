using System;
using BG_Hive_API.Interfaces;
using BG_Hive_API.Models;
using RestSharp;

namespace BG_Hive_API
{
    public class Session : ISession
    {
        const string API_URL = "https://api.bgchlivehome.co.uk/v5/";

        private string _username;
        private string _password;

        private Lazy<ITemperatureController> _temperatureController;
        private Lazy<IDeviceController> _deviceController;

        public IRestClient Client { get; set; }
        public SessionInfo Info { get; set; }


        public IDeviceController DeviceController
        {
            get
            {
                return _deviceController.Value;
            }
        }

        public ITemperatureController TemperatureController
        {
            get
            {
                return _temperatureController.Value;
            }
        }

        public Session(string username, string password) {

            _username = username.Trim();
            _password = password.Trim();

            Client = new RestClient(API_URL);
            Client.AddDefaultHeader("User-Agent", "bg-hive-api/1.0.4");

            _temperatureController = new Lazy<ITemperatureController>(() => new Temperature(this));
            _deviceController = new Lazy<IDeviceController>(() => new Devices(this));
        }

        public void Login()
        {
            var request = new RestRequest("login", Method.POST);
            request.AddParameter("username", _username);
            request.AddParameter("password", _password);
            request.AddParameter("caller", "HiveHome");

            var response = Client.Execute<SessionInfo>(request);

            Info = response.Data;
        }

        public void Logout()
        {
            Client.Execute(new RestRequest("logout", Method.POST));
        }
    }
}

//V5 API info here - http://www.smartofthehome.com/2016/03/hive-api-v5/


