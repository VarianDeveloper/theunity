using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer().LoadConfiguration();
            var methodsLib = container.Resolve<IMethodsLib>();
            methodsLib.Method1("param");
        }

        //implemented in app.config
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
