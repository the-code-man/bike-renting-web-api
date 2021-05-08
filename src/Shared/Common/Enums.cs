namespace Codeman.BikeRentingSystem.Shared.Common
{
    public enum CustomerStatus
    {
        Active,
        Inactive
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

    public enum RepairmentStatus
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

    public enum EntityState
    {
        New,
        Updated,
        Deleted,
        Unchanged
    }

    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error
    }
}