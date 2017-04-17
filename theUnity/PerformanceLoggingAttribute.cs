using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
    public class PerformanceLoggingAttribute : HandlerAttribute
    {
        private readonly int order;

        public PerformanceLoggingAttribute()
        {
            this.order = 1;
        }

        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new PerformanceLoggingCallHandler() {Order = order};
        }
    }
}
