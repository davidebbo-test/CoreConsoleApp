using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace CoreConsoleApp
{
    class Program
    {
        static public IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            Console.WriteLine($"foo = {Configuration["foo"]}");
            Console.WriteLine($"MyDatabase = {Configuration.GetConnectionString("MyDatabase")}");
        }
    }
}