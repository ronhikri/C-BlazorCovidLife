using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife
{
     public class Program
     {
          public static void Main(string[] args)
          {
               Data.updateIntervaldata update = new Data.updateIntervaldata();
               System.Timers.Timer timer = new System.Timers.Timer();
               timer.Interval = 20000;
               timer.Elapsed += update.updateData;
               timer.Start();
               CreateHostBuilder(args).Build().Run();
          }

          public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                       webBuilder.UseStartup<Startup>();
                  });
     }
}
