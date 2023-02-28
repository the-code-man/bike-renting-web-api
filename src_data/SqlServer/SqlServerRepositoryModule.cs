using Autofac;
using Codeman.BRS.Data.SqlServer.Repository.Core;
using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Repository.Core;

namespace Codeman.BRS.Data.SqlServer
{
    public class SqlServerRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConnectionHelper>().AsSelf().SingleInstance();
            builder.RegisterType<StateRepository>().As<IStateRepository>().SingleInstance();

            // https://autofac.readthedocs.io/en/latest/faq/per-request-scope.html
            builder.RegisterType<DataSourceManager>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
