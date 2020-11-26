using BudgetSaverApp.Possessions.Links;
using System;
using System.Collections;
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
            public ApiLink apiLink { set; get; }
            public IApiCallback ocjectThatNeedApiCallback;
        }

        private static List<ApiTaskEntity> taskEntities = new List<ApiTaskEntity>();
        private static List<Task> tasks = new List<Task>();

        private static void DownloadAPIAsync(ApiTaskEntity taskEntity)
        {
            HttpRequest request = new HttpRequest();
            string response = request.StartHttpRequest(taskEntity.apiLink);
            taskEntity.ocjectThatNeedApiCallback.OnAPIDownload(response);
        }

        public static async Task RunAllDownloadsAsync()
        {
            foreach(ApiTaskEntity e in taskEntities)
            {
                tasks.Add(Task.Run(() =>  DownloadAPIAsync(e)));
            }

            await Task.WhenAll(tasks);
            AllAPIsDownloaded(null, EventArgs.Empty);
        }

        public static void AddDownloadEntity(ApiLink apiLink, IApiCallback callback)
        {
            taskEntities.Add(new ApiTaskEntity
            {
                apiLink = apiLink,
                ocjectThatNeedApiCallback = callback
            });
        }

        private static void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.data);
        }

    }
}
