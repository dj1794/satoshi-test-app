
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SatoshiTestApp.Services
{
    public class ApiService : IApiService
    {
        private HttpClient apiClient;
        public ApiService(IHttpClientFactory _apiClient)
        {
           apiClient = _apiClient.CreateClient("microservice");
        }
     

        public async Task<T> Get<T>(string endpoint) where T : class, new()
        {
            T output = new T();

            try
            {
                Console.WriteLine("API GET request:  " + endpoint);

                output = await apiClient.GetFromJsonAsync<T>(endpoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return output;
        }

        public async Task Post<T>(string endpoint, T myObject)
        {
            try
            {
                Console.WriteLine("API simple Post request: " + endpoint);
                var response = await apiClient.PostAsJsonAsync<T>(endpoint, myObject);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
