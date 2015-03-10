using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace hackweekend7.dal.Serializers
{
    public class SharePointJsonDeserializer : IDeserializer
    {
        public T Deserialize<T>(IRestResponse response)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            catch (Exception exception)
            {
                //log exception
                Console.WriteLine(exception.Message);
            }
            return default(T);

        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
    }
}
