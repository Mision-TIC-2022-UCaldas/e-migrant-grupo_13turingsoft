using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DataSource = (localdb)\\MSSQLLocalDB; Initial Catalog = G35_TuringSoft.Data");
            }
        }
  
    }
}