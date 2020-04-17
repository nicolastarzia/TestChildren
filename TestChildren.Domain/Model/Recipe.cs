using System;
using System.Collections.Generic;
using System.Text;

namespace TestChildren.Domain.Model
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string IngredientName { get; set; }
        public int? Quantity { get; set; }
        public int? ParentRecipeId { get; set; }

        public virtual Recipe ParentRecipe { get; set; }

        public virtual ICollection<Recipe> Children { get; set; }
    }
}
