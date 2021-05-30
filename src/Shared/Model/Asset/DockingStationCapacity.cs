namespace Codeman.BRS.Shared.Model.Asset
{
    public class DockingStationCapacity : DockingStation
    {
        public (BikeCategory Category, int Available, int Max) Capacity { get; set; }
    }
}