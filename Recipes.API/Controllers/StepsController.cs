using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/steps")]
    public class StepsController : ControllerBase
    {

        private readonly DataContext _context;

        public StepsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Steps.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var step = await _context.Steps.FirstOrDefaultAsync(x => x.Id == id);
            if (step == null)
            {
                return NotFound();
            }

            return Ok(step);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Step step)
        {

            _context.Add(step);
            await _context.SaveChangesAsync();
            return Ok(step);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Step step)
        {

            _context.Update(step);
            await _context.SaveChangesAsync();
            return Ok(step);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Steps
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filaAfectada == 0)
            {

                return NotFound();

            }

            return NoContent();
        }

    }
}
