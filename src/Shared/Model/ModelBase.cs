using Codeman.BRS.Shared.Common;
using System;

namespace Codeman.BRS.Shared.Model
{
    public abstract class ModelBase
    {
        public EntityState CurrentState { get; set; }
    }
}
