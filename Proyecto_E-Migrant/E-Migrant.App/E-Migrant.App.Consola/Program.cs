using System;
using E_Migrant.App.Dominio;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;

namespace E_Migrant.App.Consola
{
    
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            AddPersona();
        }
        private static void AddPersona()
        {
            var persona = new Persona 
            {
                Nombres = "Andrea",
                Apelidos = "Gomez",
                TipoDocumento = TipoDocumento.CedulaCiudadania,
                Documento = "1071231637",
                PaisOrigen = "Col",
                FechaNacimiento = new DateTime(2000, 05, 20),
                Email = "wal@mail.com",
                Telefono = "13123123",
                Direccion = "calle xxx",
                Ciudad = "Ibagué",
                SituacionLaboral = SituacionLaboral.Empleado

            };

            _repoPersona.AddPersona(persona);
            Console.WriteLine("La Persona, " + persona.Nombres + " " + persona.Apelidos + " ha sido agregad@ exitosamente!\n");


        }
    }
}
