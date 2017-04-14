using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
    class LoggingCallHandler : ICallHandler //IInterceptionBehavior
    {
        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute { get { return true; } }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            var args = input.Arguments.Count == 0 ? null : input.Arguments[0];

            Console.WriteLine(
                            $"Start: Invoking method: {input.MethodBase} with parameters \"{args}\" " +
                            $"at {DateTime.Now.ToLongTimeString()}");

            var result = getNext()(input, getNext);

            Console.WriteLine(
                $"Method {input.MethodBase} returned \"{result.ReturnValue}\" " +
                              $"at {DateTime.Now.ToLongTimeString()}");

            return result;
        }

        public int Order { get; set; }
    }
}
