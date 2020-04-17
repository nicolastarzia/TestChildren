﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestChildren.Data.Context;

namespace TestChildren.Data.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20200417004330_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("TestChildren.Domain.Model.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredientName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentRecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeId");

                    b.HasIndex("ParentRecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("TestChildren.Domain.Model.Recipe", b =>
                {
                    b.HasOne("TestChildren.Domain.Model.Recipe", "ParentRecipe")
                        .WithMany("Children")
                        .HasForeignKey("ParentRecipeId");
                });
#pragma warning restore 612, 618
        }
    }
}
