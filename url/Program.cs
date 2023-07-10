using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Unipluss.Sign.ExternalContract.Entities;
using System.Net;
using System.Net.Http.Headers;
using Google.Api.Ads.AdWords.v201809;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;

namespace url
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            UserList user = new UserList();
            var response = await client.GetAsync("http://free-generator.ru/generator.php?action=word&type=3");
            var responseBody = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseBody);
            string word = json["word"]["word"].ToString();
            Console.WriteLine(word);
        }
    }
}
