namespace Codeman.BRS.Shared.Model.Core
{
    public class State : ModelBase
    {
        public string StateCode { get; set; }

        public string Name { get; set; }

        public City[] Cities { get; set; }
    }
}
