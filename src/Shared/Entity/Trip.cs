using Codeman.BRS.Shared.Common;

namespace Codeman.BRS.Shared.Entity
{
    public class Trip : BaseEntity
    {
        public long Id { get; set; }

        public Bike Bike { get; set; }

        public Customer PickedBy { get; set; }

        public DockingStation PickedFrom { get; set; }

        public DockingStation DroppedAt { get; set; }

        public Duration Duration { get; set; }

        public TripStatus Status { get; set; }

        public string Remarks { get; set; }

        public decimal GreenEnergySpent { get; set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
