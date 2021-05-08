using Codeman.BikeRentingSystem.Shared.Common;
using System;

namespace Codeman.BikeRentingSystem.Shared.Entity
{
    public class Repairment : BaseEntity
    {
        public long Id { get; set; }

        public Bike Bike { get; set; }

        public RepairmentStatus Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Remarks { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
