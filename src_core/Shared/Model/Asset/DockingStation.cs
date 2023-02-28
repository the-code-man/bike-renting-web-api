using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Model.Core;

namespace Codeman.BRS.Shared.Model.Asset
{
    public class DockingStation : ModelBaseWithAudit
    {
        public string DockingStationId { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public DockingStationStatus Status { get; set; }
    }
}