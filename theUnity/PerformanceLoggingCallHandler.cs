using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
    class PerformanceLoggingCallHandler : ICallHandler //IInterceptionBehavior
    {
        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute { get { return true; } }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            var args = input.Arguments.Count == 0 ? null : input.Arguments[0];
            var logger = new Logger.Logger();

            logger.LogSimple(
                            $"Start: Invoking method: {input.MethodBase} with parameters \"{args}\" " +
                            $"at {DateTime.Now.ToLongTimeString()}");

            var sw = Stopwatch.StartNew();

            var result = getNext()(input, getNext);
            
            logger.LogSimple($"Elapsed runtime for procedure {input.MethodBase} is {sw.ElapsedMilliseconds} ms");

            logger.LogSimple(
                $"Method {input.MethodBase} returned \"{result.ReturnValue}\" " +
                              $"at {DateTime.Now.ToLongTimeString()}");

            return result;
        }

        public int Order { get; set; }
    }
}
