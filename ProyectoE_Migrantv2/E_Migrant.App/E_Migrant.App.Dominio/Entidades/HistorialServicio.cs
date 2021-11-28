using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class HistorialServicio
    {
        public int Id {get; set;}
        public DateTime FechaSolicitud {get;set;}
        public DateTime FechaAcepRech {get;set;}
        public string DescripcionServicio {get; set;}
        public string EntidadOfrece {get;set;}
        public Estado Estado {get; set;}
    }

    public enum Estado
    {
        EnEspera,
        Autorizado,
        Activo,
        Rezachado,
        Cancelado,
        Negado
    }
}