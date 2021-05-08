using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Shared.Common
{
    public interface IDBConnectionHelper
    {
        string ConnectionString { get; }
    }
}