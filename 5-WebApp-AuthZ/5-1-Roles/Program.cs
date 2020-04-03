using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp_OpenIDConnect_DotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public async void DoSomething()
        {
            var resp = await new HttpClient().GetAsync("http://www.hotmail.com");
            return;
        }
    }
}
