﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value{Id = 1, Name = "Lijo"},
                    new Value{Id = 2, Name = "Allu"},
                    new Value{Id = 3, Name = "Norah"}
                );
        }
    }
}
