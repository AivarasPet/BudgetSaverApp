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
            DownloadCryptoPrices();
        }
        void DownloadCryptoPrices()
        {
             
            HttpRequest request = new HttpRequest();
            new Thread(() => {
                Console.WriteLine("start");
                request.HttpRequestCompleted += this.OnCryptoPricingDownloaded;
                request.StartHttpRequest("https://min-api.cryptocompare.com/data/top/totalvolfull?limit=15&tsym=USD");
             }).Start();
        }

        public void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.data);
        }

    }
}
