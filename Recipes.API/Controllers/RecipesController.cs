﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.Shared.Entities;

namespace Recipes.API.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipesController : ControllerBase
    {

        private readonly DataContext _context;

        public RecipesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Recipes.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var recipe = await _context.Recipes.FirstOrDefaultAsync(x => x.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }


        // Post- Create
        [HttpPost]
        public async Task<ActionResult> Post(Recipe recipe)
        {
            recipe.Date = DateTime.Now;

            _context.Add(recipe);
            await _context.SaveChangesAsync();

            return Ok(recipe);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Recipe recipe)
        {
            recipe.Date = DateTime.Now;

            _context.Update(recipe);
            await _context.SaveChangesAsync();

            return Ok(recipe);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaAfectada = await _context.Recipes
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
