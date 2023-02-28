namespace Codeman.BRS.Shared.Model.Core
{
    public class City : ModelBase
    {
        public int CityId { get; set; }

        public string Name { get; set; }

        public Area[] Areas { get; set; }
    }
}
