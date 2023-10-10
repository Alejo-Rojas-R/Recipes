using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/steps")]
    public class StepController : ControllerBase
    {

        private readonly DataContext _context;

        public StepController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.steps.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var step = await _context.steps.FirstOrDefaultAsync(x => x.Id == id);
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

            var filaAfectada = await _context.steps
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
