using System;
namespace E_Migrant.App.Dominio.Entidades
{
    public class Persona
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public TipoDocument TipoDocumento{get;set;}
        public string NumeroDocumento{get;set;}
        public string PaisOrigen{get;set;}
        public DateTime FNacimiento{get;set;}
        public string Correo{get;set;}
        public string Telefono{get;set;}
        public string Direccion{get;set;}
        public string Ciudad{get;set;}
    }
}