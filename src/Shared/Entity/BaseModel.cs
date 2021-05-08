using Codeman.BikeRentingSystem.Shared.Common;

namespace Codeman.BikeRentingSystem.Shared.Entity
{
    public abstract class BaseEntity
    {
        public EntityState CurrentState { get; set; }

        public abstract bool IsValid();
    }
}