using Autofac;
using Codeman.BikeRentingSystem.Shared.Common;

namespace Codeman.BikeRentingSystem.Logger
{
    public class LoggerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleLoger>().As<ILogger>();

            base.Load(builder);
        }
    }
}