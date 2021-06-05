namespace Codeman.BRS.Shared.Model.Shared
{
    public class State : ModelBase
    {
        public string StateId { get; set; }

        public string Name { get; set; }

        public City[] Cities { get; set; }
    }
}
