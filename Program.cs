using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace GifRoulette
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var port = Environment.GetEnvironmentVariable("PORT");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:" + port)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
