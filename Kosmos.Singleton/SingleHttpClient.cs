using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace Kosmos.Singleton
{
    public static class SingleHttpClient
    {
        private static string _logServerAddress = ConfigurationManager.AppSettings["LogServerAddress"];
        private static string _identity = ConfigurationManager.AppSettings["Identity"];

        public static string Identity { get; set; }
        public static string LogServerAssress { get; set; }

        public static HttpClient Client { get; set; }
        static SingleHttpClient()
        {
            Client = new HttpClient();
        }

        public static void PostException<V>(V v)
        {
            Task.Run(async () => await Client.PostAsJsonAsync(LogServerAssress ?? _logServerAddress, new { Identity = Identity ?? _identity, Message = JsonConvert.SerializeObject(v) }));
        }
    }
}
