using Codeman.BikeRentingSystem.Shared.Common;
using System;

namespace Codeman.BikeRentingSystem.Shared.Entity
{
    public class Bike : BaseEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public BikeCategory[] Categories { get; set; }

        public string Specifications { get; set; }

        public decimal Rate { get; set; }

        public BikeStatus Status { get; set; }

        public DateTime CommisionedOn { get; set; }

        public DateTime NextMaintenanceDueOn { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}