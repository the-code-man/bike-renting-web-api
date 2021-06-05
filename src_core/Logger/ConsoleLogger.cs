using Codeman.BRS.Shared.Common;
using System;

namespace Codeman.BRS.Logger
{
    public class ConsoleLoger : ILogger
    {
        public void Initialize()
        {
            Console.WriteLine($"{DateTime.Now} | Initializing Console Logger");
        }

        public void Log(string userFriendlyMessage, string exceptionMessage, LogLevel level)
        {
            Console.WriteLine($"{DateTime.Now} | {level} | {userFriendlyMessage} | {exceptionMessage}");
        }
    }
}