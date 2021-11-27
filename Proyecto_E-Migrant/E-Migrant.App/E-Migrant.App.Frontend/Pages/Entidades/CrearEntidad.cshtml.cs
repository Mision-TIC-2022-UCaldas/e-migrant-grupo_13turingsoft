using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio.Entidades;
using E_Migrant.App.Persistencia.AppRepositorios;

namespace E_Migrant.App.Frontend.Pages.Entidades
{
    public class CrearEntidadModel : PageModel

    {
        private readonly IRepositorioEntidadColaboradora _repoEntidad;
        public EntidadColaboradora entidadColaboradora {get; set;}
        public CrearEntidadModel (IRepositorioEntidadColaboradora _repoEntidad)
        {
            this._repoEntidad = _repoEntidad;
        }
        public void OnGet()
        {
            entidadColaboradora = new EntidadColaboradora();
        }
        public IActionResult OnPost (EntidadColaboradora entidadColaboradora)
        {
            _repoEntidad.AddEntidadColaboradora(entidadColaboradora);
            return RedirectToPage("Index");
        }
    }
}
