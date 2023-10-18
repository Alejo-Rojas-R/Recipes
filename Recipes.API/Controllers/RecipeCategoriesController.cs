using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/recipescategories")]
    public class RecipeCategoriesController : ControllerBase
    {

        private readonly DataContext _context;

        public RecipeCategoriesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.RecipeCategories.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var recipecategories = await _context.RecipeCategories.FirstOrDefaultAsync(x => x.Id == id);
            if (recipecategories == null)
            {
                return NotFound();
            }

            return Ok(recipecategories);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(RecipeCategory recipeCategory)
        {

            _context.Add(recipeCategory);
            await _context.SaveChangesAsync();
            return Ok(recipeCategory);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(RecipeCategory recipeCategory)
        {

            _context.Update(recipeCategory);
            await _context.SaveChangesAsync();
            return Ok(recipeCategory);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.RecipeCategories
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
