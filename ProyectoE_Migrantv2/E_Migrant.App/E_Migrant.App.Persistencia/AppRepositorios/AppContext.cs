using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Credencial> Credenciales {get; set;}
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Migrante> Migrantes { get; set; }
        public DbSet<NecesidadServicio> NecesidadServicios { get; set; }
        public DbSet<HistorialServicio> HistorialServicios { get; set; }
        public DbSet<EntidadOrg> EntidadesOrgs { get; set; }
        public DbSet<RegServicio> RegServicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = G35_TuringSoft2.Data");
            }
        }
    }
    
}