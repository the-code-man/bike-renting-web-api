using Codeman.BRS.Shared.Common;

namespace Codeman.BRS.Shared.Model.Customer
{
    public class CustomerSlim : ModelBaseWithAudit
    {
        public string CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string ContactNumber { get; set; }

        public VerificationStatus Status { get; set; }
    }
}