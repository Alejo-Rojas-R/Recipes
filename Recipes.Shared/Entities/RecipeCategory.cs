﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class RecipeCategory
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public int CategoryId { get; set; }
    }
}
