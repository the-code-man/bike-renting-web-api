using Autofac;
using Codeman.BikeRentingSystem.Shared.Service;

namespace Codeman.BikeRentingSystem.Core
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerService>().As<ICustomerService>().SingleInstance();
        }
    }
}
