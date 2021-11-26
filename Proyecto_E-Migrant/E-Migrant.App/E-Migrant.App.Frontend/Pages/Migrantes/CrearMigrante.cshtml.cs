using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;

namespace E_Migrant.App.Frontend.Pages.Migrantes
{
    public class CrearMigranteModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public Persona persona { get; set; }
        public CrearEntidadModel(IRepositorioPersona _repoPersona)
        {
            this._repoPersona = _repoPersona;
        }
        public void OnGet()
        {
            persona = new Persona();

        }
        public IActionResult OnPost(Persona persona)
        {
            _repoPersona.AddPersona(persona);
            return RedirectToPage("Index");
        }
    }
}
