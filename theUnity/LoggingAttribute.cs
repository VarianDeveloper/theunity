using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace theUnity
{
    public class LoggingAttribute : HandlerAttribute
    {
        private readonly int order;

        public LoggingAttribute()
        {
            this.order = 1;
        }

        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LoggingCallHandler() {Order = order};
        }
    }
}
