using System.Collections.Generic;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Migrante : Persona
    {
        
        public List<NecesidadServicio> NecesidadServicios {get; set;}
        public List<HistorialServicio> HistorialServicios {get; set;}
    }
}