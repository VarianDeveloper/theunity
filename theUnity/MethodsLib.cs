using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theUnity
{
    public interface IMethodsLib
    {
        string Method1();
        void Method2();
    }

    public class MethodsLib : IMethodsLib
    {
        public string Method1()
        {
            Method2();
            return "Method1 finished";
        }

        public void Method2()
        {

        }
    }
}
