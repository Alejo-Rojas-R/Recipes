using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/reviews")]
    public class ReviewsController : ControllerBase
    {

        private readonly DataContext _context;

        public ReviewsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Reviews.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var review = await _context.Reviews.FirstOrDefaultAsync(x => x.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Review review)
        {

            _context.Add(review);
            await _context.SaveChangesAsync();
            return Ok(review);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Review review)
        {

            _context.Update(review);
            await _context.SaveChangesAsync();
            return Ok(review);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Reviews
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
