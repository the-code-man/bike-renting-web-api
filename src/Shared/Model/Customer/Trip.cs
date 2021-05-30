using Codeman.BRS.Shared.Model.Asset;
using System;

namespace Codeman.BRS.Shared.Model.Customer
{
    public abstract class Trip : ModelBase
    {
        public string TripId { get; set; }

        public float DistanceCovered { get; set; }

        public int GreenEnergySpent { get; set; }

        public int DarkEnergyEarned { get; set; }

        public DockingStation PickedFrom { get; set; }

        public DockingStation DroppedAt { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Remarks { get; set; }

        public TripDetail[] TripDetails { get; set; }
    }
}