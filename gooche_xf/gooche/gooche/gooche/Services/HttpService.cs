using gooche.Classes;
using gooche.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient httpClient;

        private string baseUri;

        public HttpService()
        {
            httpClient = new HttpClient();
            baseUri = "http://10.0.2.2:7071/api/";
        }

        public async Task<ServiceResponse> GetRequest(string uri)
        {
            var getUri = baseUri.ToString() + uri;

            HttpResponseMessage response = null;

            response = await httpClient.GetAsync(getUri);
            if (response.IsSuccessStatusCode)
            {
                var resultObject = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ServiceResponse>(response.Content.ReadAsStringAsync().Result);
            }

            return new ServiceResponse(Classes.Enum.Enums.ServiceResponseState.Failure);
        }

        public async Task<ServiceResponse> PostRequest(string uri, object obj)
        {
            var serializedObject = JsonConvert.SerializeObject(obj);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var postUri = baseUri.ToString() + uri;

            HttpResponseMessage response = null;

            response = await httpClient.PostAsync(new Uri(postUri), content);
            if (response.IsSuccessStatusCode)
            {
                var resultObject = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ServiceResponse>(response.Content.ReadAsStringAsync().Result);
            }

            return new ServiceResponse(Classes.Enum.Enums.ServiceResponseState.Failure);
        }
    }
}
