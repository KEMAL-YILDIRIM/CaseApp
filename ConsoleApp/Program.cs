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
                var result = calculate.Execute();
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

            Console.ReadKey();
            AutofacSetup.DisposeServices(_serviceProvider);
        }
    }
}
