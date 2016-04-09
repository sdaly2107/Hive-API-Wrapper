using BG_Hive_API.Interfaces;
using BG_Hive_API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace BG_Hive_API
{
    sealed public class Devices : ControllerBase, IDeviceController
    {
        string _hubsResource;

        public Devices(ISession session) : base(session)
        {
            _hubsResource = $"users/{session.Info.username}/hubs/{session.Info.hubIds.First()}";
        }

        public Hub HubDetails()
        {
            var request = new RestRequest(_hubsResource, Method.GET);
            request.AddCookie("ApiSession", _session.Info.ApiSession);

            return _session.Client.Execute<Hub>(request).Data;
        }

        public List<Device> Details()
        {
            return RequestWithDeserialise<List<Device>>($"{_hubsResource}/devices", Method.GET);
        }

        public Node Nodes()
        {
            return RequestWithDeserialise<Node>($"users/{_session.Info.username}/nodes", Method.GET);
        }

        public Events EventHistory(int limit = 0)
        {
            var parameters = new List<Parameter>();
            if (limit > 0)
            {
                parameters.Add(new Parameter() { Name = "limit", Value = limit, Type = ParameterType.GetOrPost });
            }

            return RequestWithDeserialise<Events>($"users/{_session.Info.username}/events", Method.GET, parameters.ToArray());
        }

        public List<TopologyItem> TopologyDetails()
        {
            return RequestWithDeserialise<List<TopologyItem>>($"{_hubsResource}/topology", Method.GET);
        }

    }
}
