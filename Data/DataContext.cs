using Microsoft.EntityFrameworkCore;
using CartaoApiModels;

namespace CartaoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    

    public DbSet<CartaoCredito> CartaoCreditos { get; set;}

    public DbSet<Cliente> Clientes { get; set; }
    
    }
}