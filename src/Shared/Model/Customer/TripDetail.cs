using System;

namespace Codeman.BRS.Shared.Model.Customer
{
    public class TripDetail : ModelBase
    {
        public long TripDetailId { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime Time { get; set; }
    }
}
