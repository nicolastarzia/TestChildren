using System;
using System.Collections.Generic;
using TestChildren.Data.Context;
using TestChildren.Data.Repository;
using TestChildren.Domain.Model;
using TestChildren.Domain.Service;

namespace TestChildren
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RecipeContext recipeContext = new RecipeContext())
            {
                RecipeRepository recipeRepository = new RecipeRepository(recipeContext);
                RecipeService recipeService = new RecipeService(recipeRepository);
                var recipes = recipeService.GetAll();
                PrintAllRecipes(recipes);
                Console.ReadKey();
            }
        }

        private static void PrintAllRecipes(ICollection<Recipe> recipes, int level = 1)
        {
            foreach(var recipe in recipes)
            {
                Console.Write(new String('*', level));
                Console.WriteLine($" {recipe.IngredientName}");
                PrintAllRecipes(recipe.Children, level + 1);
            }
        }
    }
}
