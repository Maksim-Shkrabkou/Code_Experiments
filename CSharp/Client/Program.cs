using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using var httpClient = new HttpClient {Timeout = new TimeSpan(0, 0, 5)};
            httpClient.DefaultRequestHeaders.Add("TEST_HEADER", "Test Value");
            var response = httpClient.GetAsync("http://localhost:51370/").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            
            Console.Write(content);
        }
    }
}