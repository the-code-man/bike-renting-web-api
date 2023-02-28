using Autofac;
using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Repository;

namespace Codeman.BRS.Data.SqlServer.EF
{
    public class EFSqlServerRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConnectionHelper>().AsSelf().SingleInstance();

            //builder.RegisterType<AddressRepository>().As<IAddressRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<BikeRepository>().As<IBikeRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<DockingStationRepository>().As<IDockingStationRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<RepairmentRepository>().As<IRepairmentRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<TripRepository>().As<ITripRepository>().InstancePerLifetimeScope();
        }
    }
}
