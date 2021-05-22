namespace Codeman.BRS.Shared.Entity
{
    public class BikeCategory : BaseEntity
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}