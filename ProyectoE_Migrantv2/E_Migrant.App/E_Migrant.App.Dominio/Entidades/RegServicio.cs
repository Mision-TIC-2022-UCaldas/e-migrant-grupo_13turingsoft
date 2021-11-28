using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class RegServicio
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public int MaximoMigrantes {get; set;}
        public DateTime FechaIncio {get; set;}
        public DateTime FechaFin {get; set;}
        public EstadoServicio EstadoServicio {get; set;}
    }

    public enum EstadoServicio
    {
        Activos,
        Cerrados,
        ConCupo,
        SinCupo
    }
}