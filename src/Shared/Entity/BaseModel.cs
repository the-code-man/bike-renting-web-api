using Codeman.BRS.Shared.Common;

namespace Codeman.BRS.Shared.Entity
{
    public abstract class BaseEntity
    {
        public EntityState CurrentState { get; set; }

        public abstract bool IsValid();
    }
}