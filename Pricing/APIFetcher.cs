using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetSaverApp.Pricing
{
    public class APIFetcher
    {
        //public delegate void APIFetcherEventHandler(object source, EventArgs args);
        public static event EventHandler AllAPIsDownloaded = delegate { };

        struct ApiTaskEntity
        {
            public string url { set; get; }
            public IApiCallback ocjectThatNeedApiCallback;
        }

        private static List<ApiTaskEntity> taskEntities = new List<ApiTaskEntity>();
        private static List<Task> tasks = new List<Task>();

        private static async Task<string> DownloadAPIAsync(string url)
        {
            HttpRequest request = new HttpRequest();
            //request.HttpRequestCompleted += this.OnCryptoPricingDownloaded;
            return await request.StartHttpRequest(url);
        }

        public static async Task RunAllDownloadsAsync()
        {
            foreach(ApiTaskEntity e in taskEntities)
            {
                tasks.Add((Task.Run(async () =>  e.ocjectThatNeedApiCallback.OnAPIDownload(await DownloadAPIAsync(e.url)))));
            }

            await Task.WhenAll(tasks);
            AllAPIsDownloaded(null, EventArgs.Empty);
        }

        public static void AddDownloadEntity(string url, IApiCallback callback)
        {
            taskEntities.Add(new ApiTaskEntity
            {
                url = url,
                ocjectThatNeedApiCallback = callback
            });
        }

        private static void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.data);
        }

    }
}
