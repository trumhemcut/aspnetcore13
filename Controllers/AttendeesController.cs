using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore13.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly TrainingDbContext _dbContext;
        public AttendeesController(TrainingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attendee>>> Get()
        {
            return await this._dbContext.Attendees.ToListAsync();
        }

        [HttpPost]
        public async Task Post([FromBody] Attendee attendee)
        {
            this._dbContext.Add(attendee);
            await this._dbContext.SaveChangesAsync();
        }
    }
}
