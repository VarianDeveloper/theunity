using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly:log4net.Config.XmlConfigurator]
namespace Logger
{
    public class Logger
    {
        private ILog _logger;

        public Logger()
        {
            _logger = LogManager.GetLogger(typeof(Logger));
        }

        public void LogSimple(string msg)
        {
            _logger.Debug(msg);
        }
    }
}
