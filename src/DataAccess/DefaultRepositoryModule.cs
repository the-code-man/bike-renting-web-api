using Autofac;
using Codeman.BikeRentingSystem.Shared.Common;
using Codeman.BikeRentingSystem.Shared.Repository;

namespace Codeman.BikeRentingSystem.DataAccess
{
    public class DefaultRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConnectionHelper>().As<IDBConnectionHelper>().InstancePerLifetimeScope();

            builder.RegisterType<AddressRepository>().As<IAddressRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BikeRepository>().As<IBikeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DockingStationRepository>().As<IDockingStationRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RepairmentRepository>().As<IRepairmentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TripRepository>().As<ITripRepository>().InstancePerLifetimeScope();
        }
    }
}
