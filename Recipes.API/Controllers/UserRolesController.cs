using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/userroles")]
    public class UserRolesController : ControllerBase
    {
        private readonly DataContext _context;

        public UserRolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.UserRoles.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var userRoles = await _context.UserRoles.FirstOrDefaultAsync(x => x.Id == id);
            if (userRoles == null)
            {
                return NotFound();
            }

            return Ok(userRoles);
        }

        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(UserRole userRole)
        {
            _context.Add(userRole);
            await _context.SaveChangesAsync();
            return Ok(userRole);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(UserRole userRole)
        {
            _context.Update(userRole);
            await _context.SaveChangesAsync();
            return Ok(userRole);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaAfectada = await _context.UserRoles
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
