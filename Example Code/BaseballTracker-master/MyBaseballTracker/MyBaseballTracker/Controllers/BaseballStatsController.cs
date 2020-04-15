using MyBaseballTracker.Cors;
using MyBaseballTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyBaseballTracker.Controllers
{
    [AllowCrossSite]
    public class BaseballStatsController : ApiController
    {
        ApplicationDbContext context;
        public BaseballStatsController()
        {
            context = new ApplicationDbContext();
        }
        // GET api/hitters
        public IHttpActionResult Get()
        {
            var hitters = context.Hitters.ToList();
            return Ok(hitters);
        }

        // GET api/hitters/5
        public IHttpActionResult Get(int id)
        {
            var hitter = context.Hitters.Where(p => p.Id == id).SingleOrDefault();
            return Ok(hitter);
        }

        // POST api/hitters
        public void Post([FromBody]Hitter hitter)
        {
            context.Hitters.Add(hitter);
            context.SaveChanges();
        }

        // PUT api/hitters/5
        public void Put(int id, [FromBody]Hitter hitter)
        {
            var hitterInDb = context.Hitters.Where(p => p.Id == id).SingleOrDefault();
            hitterInDb.AtBats = hitter.AtBats;
            hitterInDb.BattingAverage = hitter.BattingAverage;
            hitterInDb.FirstName = hitter.FirstName;
            hitterInDb.LastName = hitter.LastName;
            hitterInDb.Position = hitter.Position;
            hitterInDb.Runs = hitter.Runs;
            hitterInDb.RunsBattedIn = hitter.RunsBattedIn;
            hitterInDb.HomeRuns = hitter.HomeRuns;
            hitterInDb.Games = hitter.Games;

            context.SaveChanges();
        }
    }
}
