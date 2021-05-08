using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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