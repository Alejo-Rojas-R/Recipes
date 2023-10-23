using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/ingredientrecipes")]
    public class IngredientRecipesController : ControllerBase
    {
        private readonly DataContext _context;

        public IngredientRecipesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.IngredientRecipes.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var ingredientRecipes = await _context.IngredientRecipes.FirstOrDefaultAsync(x => x.Id == id);
            if (ingredientRecipes == null)
            {
                return NotFound();
            }

            return Ok(ingredientRecipes);
        }

        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(IngredientRecipe ingredientRecipe)
        {
            _context.Add(ingredientRecipe);
            await _context.SaveChangesAsync();
            return Ok(ingredientRecipe);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(IngredientRecipe ingredientRecipe)
        {
            _context.Update(ingredientRecipe);
            await _context.SaveChangesAsync();
            return Ok(ingredientRecipe);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaAfectada = await _context.IngredientRecipes
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
