using System;
using System.Collections.Generic;
using System.Text;
using TestChildren.Domain.Model;

namespace TestChildren.Domain.Service
{
    public class RecipeService : Interfaces.IRecipeService
    {
        Interfaces.IRecipeRepository recipeRepository;
        public RecipeService(Interfaces.IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }
        public List<Recipe> GetAll()
        {
            return this.recipeRepository.GetAll();
        }
    }
}
