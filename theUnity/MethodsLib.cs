using System.Threading;

namespace theUnity
{
    public interface IGeneralMethods { }

    [Logging]
    public interface IMethodsLib
    {
        string Method1(string param);

        void Method2();
    }

   
    public class MethodsLib : IMethodsLib, IGeneralMethods
    {
        public virtual string Method1(string param)
        {
            Method2();
            Thread.Sleep(100);
            return "I'm done!";
        }
        
        public virtual void Method2()
        {
            Thread.Sleep(1000);
        }
    }
}
