using System;

using Autofac;
using Autofac.Extensions.DependencyInjection;

using Business.Interfaces;
using Business.Logic;

using ConsoleApp.Interfaces;
using ConsoleApp.Process;

using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.Configuration
{
    public static class AutofacSetup
    {
        internal static IServiceProvider RegisterServices(IServiceProvider serviceProvider)
        {
            var collection = new ServiceCollection();
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculate>().As<ICalculate>();
            builder.RegisterType<Letter>().As<ICount<char>>();
            builder.RegisterType<Number>().As<ICount<int>>();
            builder.RegisterType<SumInt>().As<IOperation<int, int>>();
            builder.RegisterType<Calculate>().As<ICalculate>();

            builder.Populate(collection);

            var appContainer = builder.Build();

            serviceProvider = new AutofacServiceProvider(appContainer);
            return serviceProvider;
        }

        internal static void DisposeServices(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                return;
            }
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
