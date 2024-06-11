﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.DBAdmin.Configurations;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataContext
{
    internal class BlazingPizzaContext(IOptions<DBOptions> options) : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(options.Value.ConectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzaSpecialConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
    }
}
