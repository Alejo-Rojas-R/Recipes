using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RolesController : Controller
    {

        private readonly DataContext _context;

        public RolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Roles.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
            if (role == null)
            {
                return NotFound();
            }

            return Ok(role);
        }

        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Role role)
        {

            _context.Add(role);
            await _context.SaveChangesAsync();
            return Ok(role);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Role role)
        {

            _context.Update(role);
            await _context.SaveChangesAsync();
            return Ok(role);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Roles
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
