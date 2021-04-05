using Incident_Tracker_API.Data;
using Incident_Tracker_API.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Incident_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackerController : ControllerBase
    {
        private readonly DataContext dbContext;
        public TrackerController(DataContext _dbContext)
        {
            dbContext = _dbContext;
        }

        // GET: api/<TrackerController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrackerDetails>>> Get()
        {
            return await dbContext.tbTracker.ToListAsync();
        }

        // GET api/<TrackerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackerDetails>> Get(int id)
        {
            return await this.dbContext.tbTracker.SingleOrDefaultAsync(s => s.Id == id);
        }

        // POST api/<TrackerController>
        [HttpPost]
        public async Task<ActionResult<TrackerDetails>> Post([FromBody] TrackerDetails value)
        {
            dbContext.tbTracker.Add(value);
            await dbContext.SaveChangesAsync();
            return CreatedAtAction("GetTracker", new { id = value.Id }, value);
        }

        // PUT api/<TrackerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TrackerDetails value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }

            dbContext.Entry(value).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [NonAction]

        bool TrackerExists(int id)
        {
            return dbContext.tbTracker.Single(s => s.Id == id) != null;
        }

        // DELETE api/<TrackerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrackerDetails>> Delete(int id)
        {
            var data = await dbContext.tbTracker.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }

            dbContext.tbTracker.Remove(data);
            await dbContext.SaveChangesAsync();

            return data;
        }
    }
}
