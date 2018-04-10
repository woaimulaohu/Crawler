using Microsoft.AspNetCore.Hosting;
using System;

namespace crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                 .UseKestrel()           // 指定WebServer为Kestrel
                 .UseStartup<Startup>()  // 配置WebHost
                 .Build();

            host.Run();
        }
    }
}
