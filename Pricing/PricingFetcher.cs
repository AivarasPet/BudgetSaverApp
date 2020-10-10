using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetSaverApp.Pricing
{
    public class PricingFetcher
    {
        //crypto, commodeties, stocks

        public PricingFetcher() 
        {
            DownloadCryptoPricesAsync();
        }
        async Task DownloadCryptoPricesAsync()
        {
            HttpRequest request = new HttpRequest();
            request.HttpRequestCompleted += this.OnCryptoPricingDownloaded;
            string data = await request.StartHttpRequest("https://min-api.cryptocompare.com/data/top/totalvolfull?limit=15&tsym=USD");
        }

        public void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.data);
        }

    }
}
