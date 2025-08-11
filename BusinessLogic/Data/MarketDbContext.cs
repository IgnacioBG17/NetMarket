using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BusinessLogic.Data
{
    public class MarketDbContext : DbContext
    {
        //al recibir el optios se podra inicializar desde el webApi
        public MarketDbContext(DbContextOptions<MarketDbContext> options): base(options) { }

        //clase que se convertira en Entidad en Sql server
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // para que lea todas las clases que heredan del entityframework
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
