using System;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Persona
    {
        public string Nombres {get; set;}
        public string Apelidos {get; set;}
        public TipoDocumento TipoDocumento {get; set;}
        public string Documento {get; set;}
        public string PaisOrigen {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Email {get; set;}
        public string Telefono {get; set;}
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public SituacionLaboral SituacionLaboral {get; set;}
    }
}