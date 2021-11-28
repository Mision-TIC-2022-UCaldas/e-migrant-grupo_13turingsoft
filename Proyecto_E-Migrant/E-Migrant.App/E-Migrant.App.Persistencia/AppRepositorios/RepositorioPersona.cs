using System.Collections;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;


namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext = new AppContext();

        Persona IRepositorioPersona.AddPersona(Persona Persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(Persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrado != null)
            {
                personaEncontrado.Nombres = persona.Nombres;
                personaEncontrado.Apelidos = persona.Apelidos;
                personaEncontrado.TipoDocumento = persona.TipoDocumento;
                personaEncontrado.Documento = persona.Documento;
                personaEncontrado.PaisOrigen = persona.PaisOrigen;
                personaEncontrado.FechaNacimiento = persona.FechaNacimiento;
                personaEncontrado.Email = persona.Email;
                personaEncontrado.Telefono = persona.Telefono;
                personaEncontrado.Direccion = persona.Direccion;
                personaEncontrado.Ciudad = persona.Ciudad;
                personaEncontrado.SituacionLaboral = persona.SituacionLaboral;
                _appContext.SaveChanges();
            }
            return personaEncontrado;
        }
    }
}
