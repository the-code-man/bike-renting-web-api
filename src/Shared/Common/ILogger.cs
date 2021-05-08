namespace Codeman.BikeRentingSystem.Shared.Common
{
    public interface ILogger
    {
        void Initialize();

        void Log(string userFriendlyMessage, string exceptionMessage, LogLevel level);
    }
}