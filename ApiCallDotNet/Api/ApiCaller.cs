using ApiCallDotNet.Models;
using Newtonsoft.Json;

namespace ApiCallDotNet.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();

            // Lägg till en basadress till klienten, eftersom alla calls kommer gå till den sidan
            Client.BaseAddress = new Uri("https://dummyjson.com/");
        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }
            }

            throw new HttpRequestException();
        }
    }
}
