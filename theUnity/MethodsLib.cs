using System.Threading;

namespace theUnity
{
    public interface IGeneralMethods { }

    public interface IMethodsLib
    {
        [Logging]
        string Method1(string param);

        [Logging]
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
