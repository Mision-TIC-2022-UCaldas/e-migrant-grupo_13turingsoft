using System;

namespace E_Migrant.App.Dominio.Entidades
{
    public class EntidadColaboradora
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public Sector Sector { get; set; }
        public OfertaServicios OfertaServicios { get; set; }
    }


}