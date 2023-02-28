using Autofac;
using Codeman.BRS.Shared.Common;

namespace Codeman.BRS.Logger
{
    public class LoggerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleLoger>().As<ILogger>().SingleInstance();
        }
    }
}