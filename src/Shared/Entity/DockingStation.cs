namespace Codeman.BikeRentingSystem.Shared.Entity
{
    public class DockingStation : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address StationAddress { get; set; }

        public string Landmark { get; set; }

        public int Capacity { get; set; }

        public Bike[] Bikes { get; set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}