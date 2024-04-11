using NLog;
using SearchService.Domain.Interface.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Services
{
    public class LoggerManager : ILoggerManager
    {
        private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {

        }
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(Exception ex, string message)
        {
            logger.Error(message + ex.Message + ex.InnerException?.Message);
            logger.Error(ex.StackTrace);
        }

        public void LogFatal(string message)
        {
            logger.Fatal(message);
        }

        public void LogInformation(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}
