﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Serilog;

namespace RapidLaunch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration(config => config.AddJsonFile("appsettings.json"))
                .ConfigureLogging((ctx, builder) =>
                {
                    builder.AddConfiguration(
                    ctx.Configuration.GetSection("Logging"));
                    builder.AddConsole();
                })
                .UseStartup<Startup>()
                .ConfigureLogging(builder =>  builder.AddConsole())
                .UseDefaultServiceProvider(options => options.ValidateScopes = false);
    }
}
