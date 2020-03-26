using System;
using System.Net.Http;
using System.Threading;

namespace Test
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            TimeSpan span = new TimeSpan(0, 0, 30, 30, 0);
            httpClient.Timeout = span;
            string url = "http://" + "protractortestcasesnew.eastus.azurecontainer.io" + "/api/test";
            var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseContentRead, new CancellationTokenSource(TimeSpan.FromMinutes(30)).Token);
            Console.WriteLine("Hello World!");
        }
    }
}
