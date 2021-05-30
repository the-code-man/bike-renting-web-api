using Codeman.BRS.Shared.Common;
using System;
using System.Collections.Generic;

namespace Codeman.BRS.Shared.Model.Asset
{
    public class Bike : ModelBaseWithAudit
    {
        public string BikeId { get; set; }

        public string BikeCode { get; set; }

        public Dictionary<string, string> Specification { get; set; }

        public BikeCategory[] BikeCategories { get; set; }

        public string Rate { get; set; }

        public BikeStatus Status { get; set; }

        public DateTime CommisionedOn { get; set; }

        public DateTime? DecommisionedOn { get; set; }

        public string PhotoRef { get; set; }
    }
}