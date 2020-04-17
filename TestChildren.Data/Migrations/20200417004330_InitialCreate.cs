using Microsoft.EntityFrameworkCore.Migrations;

namespace TestChildren.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IngredientName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ParentRecipeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Recipes_ParentRecipeId",
                        column: x => x.ParentRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ParentRecipeId",
                table: "Recipes",
                column: "ParentRecipeId");

            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE', 1, NULL)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 1', 5, 1)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 2', 4, 1)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 3', 3, 1)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 4', 2, 1)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 5', 5, 2)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 6', 6, 2)");
            migrationBuilder.Sql("INSERT INTO RECIPES(INGREDIENTNAME, QUANTITY, PARENTRECIPEID) VALUES ('TESTE 7', 7, 8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
