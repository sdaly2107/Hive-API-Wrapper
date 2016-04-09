using BG_Hive_API.Interfaces;
using RestSharp;

namespace BG_Hive_API
{
    abstract public class ControllerBase
    {
        protected ISession _session;

        public ControllerBase(ISession session)
        {
            _session = session;
        }

        protected TModel RequestWithDeserialise<TModel>(string url, Method method, params Parameter[] parameters) where TModel : new()
        {
            var request = new RestRequest(url, method);
            request.AddCookie("ApiSession", _session.Info.ApiSession);

            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter);
            }

            return _session.Client.Execute<TModel>(request).Data; ;
        }

    }
}
