using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPITesting.Tests
{
    abstract class SetupBase
    {
        /// <summary>
        /// Executes a Get request for generic models
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        protected T ExecuteGetRequest<T>(string endpoint)
        {
            // Use restsharp to instantiate the client
            var client = new RestClient(endpoint);
            // Instantiate the request and the type of request
            var request = new RestRequest();
            request.Method = Method.Get;
            // Execute request 
            var response = client.Execute(request);
            // Extract the generic body of the response
            var responseBody = JsonConvert.DeserializeObject<T>(response.Content);
            // Return responseBody
            return responseBody;    
        }
    }
}
