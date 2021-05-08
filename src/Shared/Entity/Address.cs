namespace Codeman.BRS.Shared.Entity
{
    public class Address : BaseEntity
    {
        public long Id { get; set; }

        public string HouseNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public bool IsDefault { get; set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} - {PostalCode}";
        }
    }
}