using System.Collections;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class RepoPersona : IRepoPersona
    {
        private readonly ContextApp _appContext = new ContextApp();

        Persona IRepoPersona.AddPersona(Persona Persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(Persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepoPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }

        Persona IRepoPersona.UpdatePersona(Persona persona)
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

        Credencial IRepoPersona.AddCredencial(Credencial credencial)
        {
            var CredencialAdicionado = _appContext.Credenciales.Add(credencial);
            _appContext.SaveChanges();
            return CredencialAdicionado.Entity;
        }
    }
}