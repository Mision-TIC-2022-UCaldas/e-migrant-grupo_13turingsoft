using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;

namespace entidades.app.page
{
    public class EntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repoEntidad;
        public Entidad entidad { get; set; }
        public CrearMigranteModel(IRepositorioEntidad _repoEntidad)
        {
            this._repoEntidad = _repoEntidad;
        }
        public void OnGet()
        {
            entidad = new Entidad();

        }
        public IActionResult OnPost(Entidad entidad)
        {
            _repoEntidad.AddPersona(entidad);
            return RedirectToPage("Index");
        }
    }
}
