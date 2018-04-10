using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace crawler
{
    internal class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            Console.WriteLine("app start");
            app.Run(c => {
                return c.Response.WriteAsync("Hello dotnet core.");
            });
        }
    }
}