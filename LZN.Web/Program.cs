﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LZN.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {

            //var config = new ConfigurationBuilder()
            //.AddCommandLine(args)
            //.Build();
            string ip = "127.0.0.1";// config["ip"];
            int port = 5001;//int.Parse(config["port"]);
            return  WebHost.CreateDefaultBuilder(args)
              //  .UseUrls($"http://{ip}:{port}")
             //.UseKestrel(option =>
             //{
             //    option.Listen(System.Net.IPAddress.Parse("127.0.0.1"), 5000);
             //})
              .UseStartup<Startup>();
        }
          
    }
}
