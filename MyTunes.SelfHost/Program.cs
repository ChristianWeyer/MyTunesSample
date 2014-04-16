using System;
using System.Reflection;
using Microsoft.Owin.Hosting;
using MyTunes.Hosting;

namespace MyTunes.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Assembly.Load("MyTunes.Services");

            using (var server = WebApp.Start<SelfHostStartup>("http://localhost:7777/mytunes/"))
            {
                Console.WriteLine("myTunes Server läuft...");
                Console.ReadLine();
            }
        }
    }
}
