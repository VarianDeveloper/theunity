using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theUnity
{
    public interface IMethodsLib2
    {
        string Method1(string param);
    }
    public class MethodsLib2 : IMethodsLib2
    {
        public string Method1(string param)
        {
            return $"I've got {param}";
        }
    }
}
