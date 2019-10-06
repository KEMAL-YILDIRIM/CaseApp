using System;

using ConsoleApp.Configuration;
using ConsoleApp.Interfaces;

using Microsoft.Extensions.DependencyInjection;

using Serilog;

namespace ConsoleApp
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            _serviceProvider = AutofacSetup.RegisterServices(_serviceProvider);

            var calculate = _serviceProvider.GetService<ICalculate>();

            try
            {
                bool run = true;
                while (run)
                {
                    run = calculate.Execute();
                    Console.WriteLine("Press ESC to exit or any other key to continue.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) run = false;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (e.GetType().GetInterface("IApplicationException") != null)
                {
                    Console.WriteLine(e.Message);
                }
                else
                {
                    Log.Error(e, e.Message);
                    Console.WriteLine("An unexpected error occured please refer to your Administrator.");
                }
            }

            AutofacSetup.DisposeServices(_serviceProvider);
        }
    }
}
