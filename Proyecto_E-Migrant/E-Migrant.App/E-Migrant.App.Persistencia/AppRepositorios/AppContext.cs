using Microsoft.EntityFrameworkCore;
//using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        //public DbSet<Persona> Personas { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = G35_TuringSoft.Data");
            }
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder){
        //     modelBuilder.Entity<Persona>().HasMany(m => m.AmigoFamiliares).WithMany(v => v.Personas);
        // }

  
    }
}