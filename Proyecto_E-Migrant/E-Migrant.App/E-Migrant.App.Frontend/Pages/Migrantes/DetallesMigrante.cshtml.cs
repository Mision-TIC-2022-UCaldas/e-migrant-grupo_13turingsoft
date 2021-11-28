using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;

namespace E_Migrant.App.FrontEnd.Pages
{
    public class DetallesMigranteModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public Persona Persona {get;set;}
        public DetallesMigranteModel(IRepositorioPersona _repoPersona)
        {
            this._repoPersona = _repoPersona;/* new RepositorioPersona(new E_Migrant.App.Persistencia.AppContext()); */
        }
        public IActionResult OnGet(int idPersona)
        {
            Persona = _repoPersona.GetPersona(idPersona);
            if (Persona == null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }
    }
}
