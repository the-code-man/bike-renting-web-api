namespace Codeman.BRS.Shared.Common
{
    public enum AccountStatus
    {
        Active,
        Suspended
    }

    public enum VerificationStatus
    {
        Verified,
        VerficationPending,
        Rejected
    }

    public enum PaymentType
    {
        DebitCard,
        CreditCard,
        UPI,
        Paytm,
        NetTransfer
    }

    public enum PaymentStatus
    {
        InProgress,
        Success,
        Failure
    }

    public enum TripStatus
    {
        Ongoing,
        Completed,
        Unknown
    }

    public enum RepairStatus
    {
        NotStarted,
        InProgress,
        Completed,
        TotalDamage
    }

    public enum BikeStatus
    {
        FitToUse,
        NeedsRepair,
        Stolen,
        Decommisioned
    }

    public enum DockingStationStatus
    { 
        Operational,
        ComingSoon,
        UnderMaintanence,
        Decommissioned
    }

    public enum EntityState
    {
        New,
        Updated,
        Deleted,
        Unchanged,
        Locked
    }

    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error
    }
}