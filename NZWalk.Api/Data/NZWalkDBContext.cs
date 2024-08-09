using Microsoft.EntityFrameworkCore;
using NZWalk.Api.Models.Domain;


namespace NZWalk.Api.Data
{
    public class NZWalkDBContext : DbContext
    {
        public NZWalkDBContext(DbContextOptions<NZWalkDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Region> regions { get; set; }
        public DbSet<Difficalty> difficalties { get; set; }
        public DbSet<Walk> walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficlties = new List<Difficalty>() {
                new Difficalty {
                id= Guid.Parse("4fa8dfb5-2007-40fa-a240-e68d2d34f4f3"),
                name="Easy"
                },
                 new Difficalty {
                id=Guid.Parse("3b4d0475-2317-4889-bf97-4fed0a7bcc1c"),
                name="Medium"
                },
                  new Difficalty {
                id=Guid.Parse("7c581fc3-2a82-4e2f-9b37-8fc0e1a06279"),
                name="Hard"
                }
            };
            //seed data in database
            modelBuilder.Entity<Difficalty>().HasData(difficlties);

            var regions = new List<Region>()
            {
                new Region
                {
                    id = Guid.Parse("bb9add6b-74b9-4803-bcdc-1df37cbee169"),
                    name = "Auckland",
                    code = "AKL",
                    regionImageUrl = "https://pixabay.com/images/search/auckland/"
                },
                new Region
                {
                    id = Guid.Parse("e3b0c442-98fc-1c14-9af7-1a1768dfefaa"),
                    name = "Wellington",
                    code = "WLG",
                    regionImageUrl = "https://pixabay.com/images/search/wellington/"
                },
                new Region
                {
                    id = Guid.Parse("6d83e31a-d6b2-4b58-a9be-2d3a5823ff8c"),
                    name = "Christchurch",
                    code = "CHC",
                    regionImageUrl = "https://pixabay.com/images/search/christchurch/"
                },
                new Region
                {
                    id = Guid.Parse("9d9e2b79-93cb-4a9d-81a6-3a72e3c4b8f2"),
                    name = "Hamilton",
                    code = "HLZ",
                    regionImageUrl = "https://pixabay.com/images/search/hamilton/"

                },
                new Region
                {
                    id = Guid.Parse("a1f2c3d4-e5f6-7a8b-9c0d-e1f2a3b4c5d6"),
                      name = "Dunedin",
                         code = "DUD",
                      regionImageUrl = "https://pixabay.com/images/search/dunedin/"
},
                new Region
                {
                        id = Guid.Parse("b2c3d4e5-f6a7-8b9c-0d1e-f2a3b4c5d6e7"),
                        name = "Tauranga",
                        code = "TRG",
                        regionImageUrl = "https://pixabay.com/images/search/tauranga/"
                },
                new Region
                {
                    id = Guid.Parse("c3d4e5f6-a7b8-9c0d-1e2f-a3b4c5d6e7f8"),
                    name = "Napier",
                    code = "NPE",
                    regionImageUrl = "https://pixabay.com/images/search/napier/"
                },
                 new Region
                 {
                    id = Guid.Parse("d4e5f6a7-b8c9-0d1e-2f3a-b4c5d6e7f8a9"),
                    name = "Rotorua",
                    code = "ROT",
                    regionImageUrl = "https://pixabay.com/images/search/rotorua/"
                 }

            };

            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
