using Microsoft.EntityFrameworkCore;
using Mission10_Boud.Data;
using Mission10_Boud.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Mission10_Boud.Repositories
{
    public class EFBowlerRepository : iBowlerRepository
    {
        private BowlerDbContext _context;

        public EFBowlerRepository(BowlerDbContext temp)
        {
            _context = temp;
        }

        //Formatting data with filters to send over

        public IEnumerable<Bowler> GetBowlers()
        {
            return _context.Bowlers.Include(b => b.Teams).Where(b => b.Teams.TeamName == "Marlins" || b.Teams.TeamName == "Sharks").ToList();
        }
    }
}