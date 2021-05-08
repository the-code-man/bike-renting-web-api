using Codeman.BikeRentingSystem.Shared.Common;
using System;

namespace Codeman.BikeRentingSystem.Shared.Entity
{
    public class ServiceUsage
    {
        public int ExperienceGained { get; set; }

        public float AvailableGreenEnergy { get; set; }

        public CustomerStatus Status { get; set; }

        public DateTime JoinedOn { get; set; }

        public DateTime LastUsed { get; set; }
    }
}