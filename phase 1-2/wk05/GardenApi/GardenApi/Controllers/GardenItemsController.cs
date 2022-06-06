using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GardenApi.Models;

namespace GardenApi.Controllers
{
    [Route("api/GardenItems")]
    [ApiController]
    public class GardenItemsController : ControllerBase
    {
        private readonly GardenContext _context;

        public GardenItemsController(GardenContext context)
        {
            _context = context;
        }

        // GET: api/GardenItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GardenItem>>> GetGardenItems()
        {
            return await _context.GardenItems.ToListAsync();
        }

        // GET: api/GardenItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GardenItem>> GetGardenItem(long id)
        {
            var gardenItem = await _context.GardenItems.FindAsync(id);

            if (gardenItem == null)
            {
                return NotFound();
            }

            return gardenItem;
        }

        // PUT: api/GardenItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGardenItem(long id, GardenItem gardenItem)
        {
            if (id != gardenItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(gardenItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GardenItemExists(id))
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

        // POST: api/GardenItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GardenItem>> PostGardenItem(GardenItem gardenItem)
        {
            _context.GardenItems.Add(gardenItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGardenItem), new { id = gardenItem.Id }, gardenItem);
        }

        // DELETE: api/GardenItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGardenItem(long id)
        {
            var gardenItem = await _context.GardenItems.FindAsync(id);
            if (gardenItem == null)
            {
                return NotFound();
            }

            _context.GardenItems.Remove(gardenItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GardenItemExists(long id)
        {
            return _context.GardenItems.Any(e => e.Id == id);
        }
    }
}
