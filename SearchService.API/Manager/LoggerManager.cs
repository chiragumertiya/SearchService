using NLog;
using SearchService.Domain.Interface.RepositoryInterface;

namespace SearchService.API.Manager
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
