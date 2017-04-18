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
        private ILog _logger; //, _xmlLogger;
        

        public Logger()
        {
            _logger = LogManager.GetLogger(typeof(Logger));
            //_xmlLogger = LogManager.GetLogger()
        }

        public void LogSimple(string msg)
        {
            _logger.Debug(msg);
        }
    }
}
