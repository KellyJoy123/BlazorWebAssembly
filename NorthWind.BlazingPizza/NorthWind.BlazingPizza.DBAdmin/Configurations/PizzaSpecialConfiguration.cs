using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    public class PizzaSpecialConfiguration : IEntityTypeConfiguration<PizzaSpecial>
    {
        public void Configure(EntityTypeBuilder<PizzaSpecial> builder)
        {
            builder.Property(s => s.BasePrice).HasPrecision(8, 2);

            builder.HasData(
                [
                 new PizzaSpecial{
                     Id= 1,
                    Name = "Pizza clásica de queso",
                    BasePrice =89.99m,
                    Description = "Es de queso y delicioso. ¿Por qué no querrías una?",
                    ImageUrl= "cheese.jpg" },
                    new PizzaSpecial{
                        Id=2,
                    Name= "Tocinator",
                    BasePrice= 127.99m,
                    Description= "Tiene TODO tipo de tocino",
                    ImageUrl="bacon.jpg" },
                new PizzaSpecial{ Id = 3,
                    Name="Clásica de pepperoni",
                    BasePrice =99.50m,
                    Description ="Es la pizza con la que creciste, ¡pero ardientemente deliciosa!",
                    ImageUrl = "pepperoni.jpg" },
                new PizzaSpecial{ Id= 4,
                    Name="Pollo búfalo",
                    BasePrice =  128.75m,
                    Description="Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor",
                    ImageUrl= "meaty.jpg" },
                new PizzaSpecial{
                    Id= 5,
                    Name="Amantes del champiñón",
                    BasePrice=109.00m,
                    Description="Tiene champiñones. ¿No es obvio?",
                    ImageUrl="mushroom.jpg" },
                new PizzaSpecial{ Id= 6,
                    Name="Hawaiana",
                    BasePrice = 90.25m,
                    Description="De piña, jamón y queso...",
                    ImageUrl="hawaiian.jpg" },
                new PizzaSpecial{ Id= 7,
                    Name="Delicia vegetariana",
                    BasePrice= 118.50m,
                    Description="Es como una ensalada, pero en una pizza",
                    ImageUrl="salad.jpg" },
                new PizzaSpecial{ Id= 8,
                    Name="Margarita",
                    BasePrice= 89.99m,
                    Description="Pizza italiana tradicional con tomates y albahaca",
                    ImageUrl="margherita.jpg" },


                ]
                );
        }
    }
}
