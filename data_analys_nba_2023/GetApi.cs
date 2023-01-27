using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace data_analys_nba_2023
{
    internal class GetApi
    {        
        private bool endflag = false;
        private async Task Get_Api_MethodAsync(string uri)
        {
            endflag = false;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uri),
                Headers =
                {
                    { "X-RapidAPI-Key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" },
                    { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                GlobalValariables.json_body = body;
            }
            endflag = true;
        }

        public void Get_Api_Method_Async(string api_type)
        {
            
            Task.Run(() => Get_Api_MethodAsync(Make_Uri(api_type)));
            while (!endflag) { Thread.Sleep(100); }
        }

        private string Make_Uri(string api_type)
        {
            return "https://api-nba-v1.p.rapidapi.com/" + api_type;
        }

    }
}
