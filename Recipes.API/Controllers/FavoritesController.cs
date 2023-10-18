using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/favorites")]
    public class FavoritesController:ControllerBase
    {

        private readonly DataContext _context;

        public FavoritesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Favorites.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var favorite = await _context.Favorites.FirstOrDefaultAsync(x => x.Id == id);
            if (favorite == null)
            {
                return NotFound();
            }

            return Ok(favorite);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Favorite favorite)
        {

            _context.Add(favorite);
            await _context.SaveChangesAsync();
            return Ok(favorite);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Favorite favorite)
        {

            _context.Update(favorite);
            await _context.SaveChangesAsync();
            return Ok(favorite);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Favorites
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
