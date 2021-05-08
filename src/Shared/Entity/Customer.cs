namespace Codeman.BRS.Shared.Entity
{
    public class Customer : BaseEntity
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string ContactNumber { get; set; }

        public Address[] Addresses { get; set; }

        public ServiceUsage Usage { get; set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}