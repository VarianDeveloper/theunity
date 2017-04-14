using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            //TODO: replace by design time config
            RegisterUnity(container);
            var methodsLib = container.Resolve<IMethodsLib>();

            methodsLib.Method1("param");
        }

        private static void RegisterUnity(IUnityContainer container)
        {
            container.AddNewExtension<Interception>();
            container.RegisterType<IMethodsLib, MethodsLib>(
                new Interceptor<InterfaceInterceptor>(),
                //new InterceptionBehavior<LoggingInterceptionBehavior>()
                new InterceptionBehavior<PolicyInjectionBehavior>()
                );
        }


    }
}
