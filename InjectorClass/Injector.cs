using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;
using static InterfaceClass.Interfaces;

namespace InjectorClass
{
    public class Injector 
    {
        IServiceProvider _sp;

        public Injector()
        {
            List<Assembly> DynClass = new List<Assembly>();

            //This can be replaced with a loop in future. Searching the bin directory.
            DynClass.Add(Assembly.LoadFrom("FacadeClass.dll"));
            DynClass.Add(Assembly.LoadFrom("DateHelperClass.dll"));
            DynClass.Add(Assembly.LoadFrom("HelloWorldClass.dll"));

            //Notice we do not need to register the types for the injector or Interface classes.
            //This is because they have a hard dependency to project and are included in the executing assembly.
            

            //Wire up the 
            var sc = new ServiceCollection();


            sc.AddLogging(a => a.AddConsole())
                .AddLogging(a => a.AddDebug())
                .AddSingleton(typeof(ILoggerClass), typeof(LoggerClass));
                
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(sc);
            
            //We need to register the facadeOAP class and pass in a LoggerClass instance.
            containerBuilder.Register(r => new facadeAOP(r.Resolve<ILoggerClass>()));
            //The following allows for the resolver to also look into its own assembly to find interfaces. (InstancePerDependency)
            containerBuilder.RegisterAssemblyTypes(DynClass.ToArray()).InstancePerDependency().AsImplementedInterfaces().EnableInterfaceInterceptors().InterceptedBy(typeof(facadeAOP));
            
            var container = containerBuilder.Build();
            _sp = new AutofacServiceProvider(container);    
            

        }

        public T GetInstance<T>()
        {
            return _sp.GetService<T>();
        }

    }

    //Requires Autofac.Extras.DynamicProxy (Part of Castle.Core)
    public class facadeAOP : IInterceptor
    {
        ILogger _lg;


        public facadeAOP(ILoggerClass lg)
        {
            _lg = lg.GetLogger("AOP");
        }


        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                _lg.LogInformation(ex.Message);
            }
        }
    }

}
