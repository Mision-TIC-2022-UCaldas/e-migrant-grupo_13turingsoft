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
    }
}
