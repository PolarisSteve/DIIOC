using Autofac;
using Autofac.Extensions.DependencyInjection;
using InterfaceClass;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using static InterfaceClass.Interfaces;

namespace InjectorClass
{
    public class Injector 
    {
        IServiceProvider _sp;

        public Injector()
        {
            var FacadeClass = Assembly.LoadFrom("FacadeClass.dll");
            var DateHelperClass = Assembly.LoadFrom("DateHelperClass.dll");
            var HelloWorldClass = Assembly.LoadFrom("HelloWorldClass.dll");


            //Wire up the 
            var sc = new ServiceCollection();


            sc.AddLogging(a => a.AddConsole())
                .AddLogging(a => a.AddDebug())
                .AddSingleton(typeof(ILoggerClass), typeof(LoggerClass));
                
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(sc);
            containerBuilder.RegisterAssemblyTypes(DateHelperClass).As<Interfaces.IDateFactory>();
            containerBuilder.RegisterAssemblyTypes(FacadeClass).As<Interfaces.IFacadeClass>();
            containerBuilder.RegisterAssemblyTypes(DateHelperClass).As<Interfaces.IDisplayDateClass>();
            containerBuilder.RegisterAssemblyTypes(HelloWorldClass).As<Interfaces.IHelloWorld>();

            var container = containerBuilder.Build();
            _sp = new AutofacServiceProvider(container);    
            

        }

        public T GetInstance<T>()
        {
            return _sp.GetService<T>();
        }

    }
}
