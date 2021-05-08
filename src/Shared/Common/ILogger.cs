using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Shared.Common
{
    public interface ILogger
    {
        void Initialize();

        void Log(string userFriendlyMessage, string exceptionMessage, LogLevel level);
    }
}