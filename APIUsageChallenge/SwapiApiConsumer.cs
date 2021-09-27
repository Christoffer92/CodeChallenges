using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIUsageChallenge
{
    class SwapiApiConsumer {

        private readonly RestClient client;
        private readonly ApiRequestCache apiRequestCache;
        public static SwapiApiConsumer Instance { get; protected set; } = new SwapiApiConsumer();

        public SwapiApiConsumer() {
            this.client = new RestClient("https://swapi.dev/api/");
            this.apiRequestCache = new ApiRequestCache();
        }


        public string GetPerson(int id) {
            string requestStr = "people/" + id;
            string content = apiRequestCache.GetCachedRequestContent(requestStr);

            if (content != "") {
                return content;
            }

            var request = new RestRequest(requestStr, DataFormat.Json);
            var response = this.client.Get(request);
            HttpStatusCode responseStatusCode = response.StatusCode;
            if (responseStatusCode != HttpStatusCode.OK) {
                return "Sorry there was a fault with your request, ERROR: " + responseStatusCode;
            }
            content = response.Content;
            apiRequestCache.AddRequest(requestStr, content);
            return response.Content;
        }
    }
}
