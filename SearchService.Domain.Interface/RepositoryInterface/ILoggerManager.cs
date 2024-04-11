using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Domain.Interface.RepositoryInterface
{
    public interface ILoggerManager
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogDebug(string message);
        void LogFatal(string message);
        void LogError(Exception ex, string message);
    }
}
