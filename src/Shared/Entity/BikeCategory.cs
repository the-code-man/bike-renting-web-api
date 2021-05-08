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

//Road bikes: Roads.
//Mountain bikes: Off road.
//Hybrid/commuter bikes: A bit of everything.

//Cyclocross bikes: A bit of everything, but with a road bike feel.

//Folding bikes: Commuting, leisure or touring for the short-on-space.
//Electric bikes: An electric-assisted bit of everything.

//Touring bikes: designed for carrying loads over longer distances while remaining comfortable for the rider.

//Women’s bikes: All of the above, designed specifically for women.
