using Codeman.BRS.Shared.Common;
using System;

namespace Codeman.BRS.Shared.Entity
{
    public class Payment : BaseEntity
    {
        public long Id { get; set; }

        public Customer PaidBy { get; set; }

        public Trip PaidFor { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaidOn { get; set; }

        public PaymentStatus Status { get; set; }

        public PaymentType PaymentType { get; set; }

        public string Remarks { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}