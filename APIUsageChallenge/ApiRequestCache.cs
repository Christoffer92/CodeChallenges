using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIUsageChallenge
{
    class ApiRequestCache {

        private Dictionary<string, string> requestCacheDictionary;

        public ApiRequestCache() {
            requestCacheDictionary = new Dictionary<string, string>();
        }


        public void AddRequest(string request, string content) {
            requestCacheDictionary.TryAdd(request, content);
        }

        public string GetCachedRequestContent(string request) {
            string content = "";
            if (requestCacheDictionary.TryGetValue(request, out content)) {
                return content;
            }
            return "";
        }
    }
}
