namespace Codeman.BRS.Shared.Model.Core
{
    public class Address : ModelBase
    {
        public Address() => IsDefault = true;

        public long AddressId { get; set; }

        public string AddressMain { get; set; }

        public string Street { get; set; }

        public Area Area { get; set; }

        public City City { get; set; }

        public State State { get; set; }

        public string PostalCode { get; set; }

        public bool IsDefault { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} - {PostalCode}";
        }
    }
}
