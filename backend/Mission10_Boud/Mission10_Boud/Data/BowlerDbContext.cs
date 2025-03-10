using Microsoft.EntityFrameworkCore;

namespace Mission10_Boud.Data
{
    public class BowlerDbContext : DbContext
    {

        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {

        }

        //Getting tables
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
