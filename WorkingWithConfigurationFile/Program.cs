﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WorkingWithConfigurationFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = new WebHostBuilder()
               .UseKestrel()
               .UseStartup<Startup>()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   var env = hostingContext.HostingEnvironment;
                   config.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile(path: $"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                   if (env.IsDevelopment())
                   {
                       var appAssemble = Assembly.Load(new AssemblyName(env.ApplicationName));
                       if (appAssemble != null)
                       {
                           config.AddUserSecrets(appAssemble, optional: true);
                       }
                   }
                   config.AddEnvironmentVariables();
                   if (args != null)
                   {
                       config.AddCommandLine(args);
                   }
               })
              .ConfigureLogging((hostingContext, logging) =>
              {
                  logging.AddConfiguration(hostingContext.Configuration.GetSection(key: "Logging"));
                  logging.AddConsole();
                  logging.AddDebug();
              })
              .UseIISIntegration()
              .UseDefaultServiceProvider((context, option) =>
              {
                  option.ValidateScopes = context.HostingEnvironment.IsDevelopment();
              });

            return builder;
        }
    }
}