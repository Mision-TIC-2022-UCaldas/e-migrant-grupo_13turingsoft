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
    public class RegMigranteModel : PageModel
    {
        private readonly IRepoPersona _repoPersona;
        public Persona persona { get; set; }
        public Credencial credencial {get; set;}
        public RegMigranteModel(IRepoPersona _repoPersona)
        {
            this._repoPersona = _repoPersona;
        }
        public void OnGet()
        {
            persona = new Persona();
            credencial = new Credencial();

        }
        public IActionResult OnPost(Persona persona, Credencial credencial)
        {
            _repoPersona.AddPersona(persona);
            _repoPersona.AddCredencial(credencial);
            return RedirectToPage("RegMigrante");
        }
    }
}
