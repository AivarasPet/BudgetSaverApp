using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetSaverApp.Pricing
{
    public class APIFetcher
    {
        //public delegate void APIFetcherEventHandler(object source, EventArgs args);
        public static event EventHandler AllAPIsDownloaded = delegate { };

        class TaskEntity
        {
            public string url { set; get; }
            public IApiCallback obj;
        }

        private static List<TaskEntity> taskEntities = new List<TaskEntity>();
        private static List<Task> tasks = new List<Task>();

        private static async Task<string> DownloadAPIAsync(string url)
        {
            HttpRequest request = new HttpRequest();
            //request.HttpRequestCompleted += this.OnCryptoPricingDownloaded;
            return await request.StartHttpRequest(url);
        }

        public static async Task RunAllDownloadsAsync()
        {
            foreach(TaskEntity e in taskEntities)
            {
                tasks.Add((Task.Run(async () =>  e.obj.OnAPIDownload(await DownloadAPIAsync(e.url)))));
            }

            await Task.WhenAll(tasks);
            AllAPIsDownloaded(null, EventArgs.Empty);
        }

        public static void AddDownloadEntity(string url, IApiCallback obj)
        {
            taskEntities.Add(new TaskEntity
            {
                url = url,
                obj = obj
            });
        }

        private static void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.data);
        }

    }
}
