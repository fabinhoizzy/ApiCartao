using Microsoft.EntityFrameworkCore;
using CartaoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartaoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    

    public DbSet<CartaoCredito> CartaoCreditos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            modelBuilder.Entity<CartaoCredito>()
                .Property(cartaoCredito => cartaoCredito.Email)
                .HasMaxLength(100);

            modelBuilder.Entity<CartaoCredito>()
                .Property(cartaoCredito => cartaoCredito.Id)
                .ValueGeneratedOnAdd();
        }
    
    }
}