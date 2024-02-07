using ApiCallDotNet.Api;
using ApiCallDotNet.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiCallDotNet.Pages
{
    public class IndexModel : PageModel
    {
        public List<User> Users { get; set; }
        public string? ErrorMessage { get; set; }

        public async Task OnGet()
        {
            try
            {
                Root result = await new ApiCaller().MakeCall("userszzzzzzzzzzzzzzzzzzzzzzzzzzzz");

                Users = result.Users;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }


            //// Anropa ett API för att hämta users

            //// 1. Skapa en ny http-klient
            //HttpClient client = new();

            //// 2. Skicka ett asynkront get request
            //HttpResponseMessage response = await client.GetAsync("https://dummyjson.com/users");

            //// 3. Se om responset var lyckat
            //if (response.IsSuccessStatusCode)
            //{
            //    // Requestet var lyckat

            //    // 4. Läs responsets body som json
            //    string jsonStrResult = await response.Content.ReadAsStringAsync();

            //    // 5. Omvandla json-strängen till C#-objekt
            //    Root? result = JsonConvert.DeserializeObject<Root>(jsonStrResult);

            //    Users = result.Users;
            //}

            //// Displaya alla users genom att loopa genom dom
        }
    }
}
