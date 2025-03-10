using Mission10_Boud.Data;

namespace Mission10_Boud.Repositories
{
    public interface iBowlerRepository
    {
        IEnumerable<Bowler> GetBowlers();
    }
}
