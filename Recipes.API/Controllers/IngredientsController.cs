using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/ingredients")]
    public class IngredientsController : ControllerBase
    {

        private readonly DataContext _context;

        public IngredientsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Ingredients.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var ingredient = await _context.Ingredients.FirstOrDefaultAsync(x => x.Id == id);
            if (ingredient == null)
            {
                return NotFound();
            }

            return Ok(ingredient);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Ingredient ingredient)
        {

            _context.Add(ingredient);
            await _context.SaveChangesAsync();
            return Ok(ingredient);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Ingredient ingredient)
        {

            _context.Update(ingredient);
            await _context.SaveChangesAsync();
            return Ok(ingredient);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Ingredients
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
