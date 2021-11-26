using System;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia.AppRespositorios;

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
                Apellidos = "Gomez",
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

            _repoPersona.AddPaciente(persona);

            Console.WriteLine("Paciente, " + paciente.Nombres + " " + paciente.Apellidos + " ha sido agregad@ exitosamente!\n");


        }


    }
}
