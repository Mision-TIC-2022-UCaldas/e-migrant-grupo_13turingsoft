using System;

namespace E_Migrant.App.Dominio.Entidades
{
    public class EntidadOrg
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Tefefono { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public Sector Sector { get; set; }
        public OfertaServicios OfertaServicios { get; set; }
    }

    public enum Sector
    {
        Publico = 0,
        Privado = 1,
        SinAnimoLucro = 2,
        NoGubernamental = 3,
        Otro = 4
    }

    public enum OfertaServicios
    {
        Salud = 0,
        Juridicos = 1,
        Viveres = 2,
        ComidaPreparada = 3,
        Empleo = 4,
        AlojamientoTemporal = 5,
        AlojamientoPermanente = 6,
        Educacion = 7,
        Otro = 8
    }
}