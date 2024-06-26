using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;


namespace NorthWind.BlazingPizza.DBAdmin.DataContext
{
    internal class BlazingPizzaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BlazingPizza");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<CustomPizza> CustomPizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
