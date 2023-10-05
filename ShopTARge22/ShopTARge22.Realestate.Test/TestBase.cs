using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using ShopTARge22.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ShopTARge22.Realestate.Test.Macros;
using Microsoft.EntityFrameworkCore;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.ApplicationServices.Services;
using Microsoft.Extensions.Hosting;
using ShopTARge22.Realestate.Test.Mock;

namespace ShopTARge22.Realestate.Test
{
    public abstract class TestBase
    {
        protected IServiceProvider serviceProvider { get; }
        protected TestBase()
        {
            var services = new ServiceCollection();
            SetupServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        public void Dispose()
        {

        }
        protected T Svc<T>()
        {
            return serviceProvider.GetService<T>();
        }
        
        protected T Macro<T>() where T : IMacros
        {
            return serviceProvider.GetService<T>();
        }
        public virtual void SetupServices(IServiceCollection services)
        {
            services.AddScoped<IRealestatesServices, RealestatesServices>();
            services.AddScoped<IFileServices, FileServices>();
            services.AddScoped<IHostEnvironment, MockIHostEnvironment>();
            services.AddDbContext<ShopTARge22Context>(x =>
            {
                x.UseInMemoryDatabase("TEST");
                x.ConfigureWarnings(e => e.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            });
            RegisterMacros(services);
        }

        private void RegisterMacros(IServiceCollection services)
        {
            var macroBaseType = typeof(IMacros);
            var macros = macroBaseType.Assembly.GetTypes()
                .Where(x => macroBaseType.IsAssignableFrom(x) && !x.IsInterface
                && !x.IsAbstract);

            foreach(var macro in macros)
            {
                services.AddSingleton(macro);
            }
        }
    }
}
