using System;
using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
        }
    }