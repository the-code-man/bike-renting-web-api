using Codeman.BRS.Shared.Model.Shared;
using System;

namespace Codeman.BRS.Shared.Model.Customer
{
    public class CustomerDetails : CustomerSlim
    {
        public Address[] Addresses { get; set; }

        public string PhotoRef { get; set; }

        public string VerificationDocRef { get; set; }

        public int AvaiableGreenEnergy { get; set; }

        public DateTime JoinedOn { get; set; }

        public DateTime ServiceLastUsed { get; set; }
    }
}
