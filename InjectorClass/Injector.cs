using DateHelperClass;
using facadeClass;
using HelloWorldClass;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using static InterfaceClass.Interfaces;

namespace InjectorClass
{
    public class Injector 
    {
        IServiceProvider _sp;

        public Injector()
        {
            //Wire up the 
            _sp = new ServiceCollection()
               .AddLogging(a => a.AddConsole()).AddLogging(a => a.AddDebug())
               .AddSingleton(typeof(IFacadeClass), typeof(FacadeClass))
               .AddSingleton(typeof(IHelloWorld), typeof(HelloWorld))
               .AddSingleton(typeof(IDisplayDateClass), typeof(dateHelper))
               .AddSingleton(typeof(IDateFactory),typeof(DateFactory))
               .BuildServiceProvider();

        }

        public T GetInstance<T>()
        {
            return _sp.GetService<T>();
        }

    }
}
