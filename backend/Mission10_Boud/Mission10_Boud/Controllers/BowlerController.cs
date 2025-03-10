using Mission10_Boud.Data;
using Mission10_Boud.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mission10_Boud.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private iBowlerRepository _bowlerRepo;

        public BowlerController(iBowlerRepository bowlerRepo)
        {
            _bowlerRepo = bowlerRepo;
        }

        [HttpGet(Name = "GetBowler")]
        public IEnumerable<Bowler> Get()
        {
            return _bowlerRepo.GetBowlers();
        }
    }
}
