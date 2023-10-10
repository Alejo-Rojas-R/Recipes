using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController:ControllerBase
    {

        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.categories.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var category = await _context.categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Category category)
        {

            _context.Add(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {

            _context.Update(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.categories
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
