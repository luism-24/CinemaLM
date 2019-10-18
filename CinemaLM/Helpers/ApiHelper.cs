using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CinemaLM.Helpers
{
    public class ApiHelper
    {
        public static T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }

        public static T Post<T,C>(string url, C body)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var body2 = JsonConvert.SerializeObject(body);

            var request = httpClient.PostAsync(url, new StringContent(body2, Encoding.UTF8, "application/json")).Result;

            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);

        }
    }
}
