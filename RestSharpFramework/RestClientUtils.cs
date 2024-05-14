using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APILearningRestSharpFramework
{
    public class RestClientUtils
    {
       
        static RestRequest? _RestRequest;

        public static RestRequest CreateRequest(string url, Method method, DataFormat format)
        {
            _RestRequest = new RestRequest(url);

            _RestRequest.Method = method;
            _RestRequest.RequestFormat = format;

            return _RestRequest;

        }

        public static RestResponse ExecuteRequest(RestRequest restRequest)
        {

            RestClient restClient = new RestClient();
            return restClient.Execute(restRequest);           
                
        }
       
    }
}
