﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaSpecials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSpecials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PizzaSpecials",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 89.99m, "Es de queso y delicioso. ¿Por qué no querrías una?", "cheese.jpg", "Pizza clásica de queso" },
                    { 2, 127.99m, "Tiene TODO tipo de tocino", "bacon.jpg", "Tocinator" },
                    { 3, 99.50m, "Es la pizza con la que creciste, ¡pero ardientemente deliciosa!", "pepperoni.jpg", "Clásica de pepperoni" },
                    { 4, 128.75m, "Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor", "meaty.jpg", "Pollo búfalo" },
                    { 5, 109.00m, "Tiene champiñones. ¿No es obvio?", "mushroom.jpg", "Amantes del champiñón" },
                    { 6, 90.25m, "De piña, jamón y queso...", "hawaiian.jpg", "Hawaiana" },
                    { 7, 118.50m, "Es como una ensalada, pero en una pizza", "salad.jpg", "Delicia vegetariana" },
                    { 8, 89.99m, "Pizza italiana tradicional con tomates y albahaca", "margherita.jpg", "Margarita" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Queso extra", 23.50m },
                    { 2, "Tocino de pavo", 28.80m },
                    { 3, "Tocino de jabalí", 28.80m },
                    { 4, "Tocino de ternera", 28.80m },
                    { 5, "Té y bollos", 47.00m },
                    { 6, "Bollos recién horneados", 43.50m },
                    { 7, "Pimiento", 9.00m },
                    { 8, "Cebolla", 9.00m },
                    { 9, "Champiñones", 9.00m },
                    { 10, "Pepperoni", 9.00m },
                    { 11, "Salchicha de pato", 30.80m },
                    { 12, "Albóndigas de venado", 24.50m },
                    { 13, "Cubierta de langosta", 612.50m },
                    { 14, "Caviar de esturión", 965.25m },
                    { 15, "Corazones de alcachofa", 32.60m },
                    { 16, "Tomates frescos", 19.00m },
                    { 17, "Albahaca", 19.00m },
                    { 18, "Filete", 80.50m },
                    { 19, "Pimientos picantes", 39.80m },
                    { 20, "Pollo búfalo", 48.00m },
                    { 21, "Queso azul", 24.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaSpecials");

            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
