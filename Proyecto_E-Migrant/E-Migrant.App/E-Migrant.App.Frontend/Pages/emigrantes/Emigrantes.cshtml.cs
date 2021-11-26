using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using E_Migrant.App.Persistencia;
using E_Migrant.App.Dominio;

namespace emigrantes.app.page
{
    public class EmigrantesModel : PageModel
    {
    private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());

        public void OnGet()
        {
        }
        public void OnPostAdd(Persona emigrante)
        {
            _repoPersona.AddPersona(emigrante);

            //
            //this.listaCuidadores = repositorioCuidador.GetCuidadores();
        }
    }
}
