using Infrastructure.Common;
using NLog.Config;
using NLog.Targets.Wrappers;
using NLog.Targets;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bootstrapper.Logging
{
    public class LogManagerInitializer : ILogManagerInitializer, IDisposable
    {
        private readonly IPathService _pathService;

        public LogManagerInitializer(IPathService pathService)
        {
            _pathService = pathService;
            var loggingConfiguration = CreateLoggingConfiguration();
            LogManager.Configuration = loggingConfiguration;
        }

        private LoggingConfiguration CreateLoggingConfiguration()
        {
            var loggingConfiguration = new LoggingConfiguration();
            var appLoginRule = CreateAppLoginRule();
            loggingConfiguration.AddRule(appLoginRule);
            return loggingConfiguration;
        }

        private LoggingRule CreateAppLoginRule()
        {
            var appLogfileTarget = new FileTarget
            {
                FileName = Path.Combine(_pathService.ApplicationFolder, "Logs", "app.log")
            };
            var asyncTargetWrapper = new AsyncTargetWrapper(appLogfileTarget)
            {
                TimeToSleepBetweenBatches = 1000
            };
            return new LoggingRule("*", LogLevel.Info, asyncTargetWrapper);
        }

        public void Dispose()
        {
            LogManager.Flush();
            LogManager.Shutdown();
        }
    }
}
