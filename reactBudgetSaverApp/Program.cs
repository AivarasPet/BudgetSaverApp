using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BudgetSaverApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace my_new_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ApiTestAsync();
            Session.serviceManager = new ServiceManager();
            CreateHostBuilder(args).Build().Run();
        }

        static async Task ApiTestAsync()
        {
            Console.WriteLine("daaamn");
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://live-metal-prices.p.rapidapi.com/v1/latest"),
                Headers =
    {
        { "x-rapidapi-key", "410e812211mshd681ea22e78bcf3p1a126cjsnccc3512e2d1f" },
        { "x-rapidapi-host", "live-metal-prices.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
