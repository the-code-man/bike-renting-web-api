using Autofac;
using Codeman.BRS.Core.Service;
using Codeman.BRS.Shared.Service;

namespace Codeman.BRS.Core
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UtilityService>().As<IUtilityService>().SingleInstance();
        }
    }
}
