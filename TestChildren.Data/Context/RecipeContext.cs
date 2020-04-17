using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestChildren.Domain.Model;

namespace TestChildren.Data.Context
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
            .HasMany(e => e.Children)
            .WithOne(e => e.ParentRecipe)
            .HasForeignKey(e => e.ParentRecipeId);
            base.OnModelCreating(modelBuilder);
        }

        internal object Entry<T>()
        {
            throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=blogging.db");
    }
}
