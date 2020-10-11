using BudgetSaverApp.Possessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetSaverApp.Pricing
{
    public class APIFetcher
    {


        class TaskEntity
        {
            public string url { set; get; }
            public IHasAPI obj;
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
        }

        public static void AddDownloadEntity(string url, IHasAPI obj)
        {
            taskEntities.Add(new TaskEntity
            {
                url = url,
                obj = obj
            });
        }

        public static void AttachActionOnObserver()
        {
        }

        private static void OnCryptoPricingDownloaded(object sender, MyEventArgs e)
        {
                
        }

    }
}
