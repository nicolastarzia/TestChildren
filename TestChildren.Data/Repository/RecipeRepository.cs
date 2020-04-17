using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestChildren.Data.Context;
using TestChildren.Domain.Interfaces;
using TestChildren.Domain.Model;

namespace TestChildren.Data.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        RecipeContext recipeContext;
        public RecipeRepository(RecipeContext recipeContext)
        {
            this.recipeContext = recipeContext;
        }

        public List<Recipe> GetAll()
        {
            var resultData = recipeContext.Recipes
                .Include(f => f.Children)
                .AsEnumerable();

            return resultData
                .Where(f => f.ParentRecipe == null)
                .ToList();
        }
    }
}
