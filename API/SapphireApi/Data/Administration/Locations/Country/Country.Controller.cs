using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data;

namespace SapphireApi.Data.Adminsitration.Locations.Country
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly Sapphire_Context _context;

        public CountryController(Sapphire_Context context)
        {
            _context = context;
        }

        // GET: api/Country
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetCountry()
        {
            return await _context.Country.ToListAsync();
        }

        // GET: api/Country/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryModel>> GetCountryModel(int id)
        {
            var countryModel = await _context.Country.FindAsync(id);

            if (countryModel == null)
            {
                return NotFound();
            }

            return countryModel;
        }

        // PUT: api/Country/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountryModel(int id, CountryModel countryModel)
        {
            if (id != countryModel.id)
            {
                return BadRequest();
            }

            _context.Entry(countryModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryModelExists(id))
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

        // POST: api/Country
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CountryModel>> PostCountryModel(CountryModel countryModel)
        {
            _context.Country.Add(countryModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountryModel", new { id = countryModel.id }, countryModel);
        }

        // DELETE: api/Country/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountryModel(int id)
        {
            var countryModel = await _context.Country.FindAsync(id);
            if (countryModel == null)
            {
                return NotFound();
            }

            _context.Country.Remove(countryModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryModelExists(int id)
        {
            return _context.Country.Any(e => e.id == id);
        }
    }
}
