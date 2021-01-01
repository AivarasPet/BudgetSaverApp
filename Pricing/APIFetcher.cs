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
            public IApiCallback objectThatNeedApiCallback;
        }

        private List<ApiTaskEntity> taskEntities = new List<ApiTaskEntity>();
        private List<Task> tasks = new List<Task>();

        private static void DownloadAPIAsync(ApiTaskEntity taskEntity)
        {
            HttpRequest request = new HttpRequest();
            string response = request.StartHttpRequest(taskEntity.apiLink);
            taskEntity.objectThatNeedApiCallback.OnAPIDownload(response);
        }

        public async Task RunAllDownloadsAsync()
        {
            foreach(ApiTaskEntity e in taskEntities)
            {
                tasks.Add(Task.Run(() =>  DownloadAPIAsync(e)));
            }

            await Task.WhenAll(tasks);
            AllAPIsDownloaded(null, EventArgs.Empty);
        }

        public void AddDownloadEntity(ApiLink apiLink, IApiCallback callback)
        {
            taskEntities.Add(new ApiTaskEntity
            {
                apiLink = apiLink,
                objectThatNeedApiCallback = callback
            });
        }
    }
}
