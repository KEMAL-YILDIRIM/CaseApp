using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp.Configuration
{
    public static class AutofacSetup
    {
        internal static IServiceProvider RegisterServices(IServiceProvider serviceProvider)
        {
            var collection = new ServiceCollection();
            var builder = new ContainerBuilder();

            //builder.RegisterType<AmbientTemperatureProcessor>().As<IAmbientTemperatureProcessor>();

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
