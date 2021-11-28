using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace E_Migrant.App.FrontEnd.Pages
{
    public class ListMigrantesModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public IEnumerable<Persona> Personas {get;set;}
        public Persona persona {get;set;}
        public ListMigrantesModel(IRepositorioPersona _repoPersona)
        {
            this._repoPersona = _repoPersona;/* new RepositorioPersona(new E_Migrant.App.Persistencia.AppContext()); */
        }
        public void OnGet()
        {
            Personas = _repoPersona.GetAllPersonas();
        }
    }
}
