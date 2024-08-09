namespace NZWalk.Api.Models.Domain
{
    public class Walk
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string? walkImageUrl { get; set; }
        public double lengthInKm { get; set; }
        public Guid difficltyId{ get; set; }
        public Guid regionId { get; set; }
        public Region region { get; set; }
        public Difficalty difficalty { get; set; }

    }
}
