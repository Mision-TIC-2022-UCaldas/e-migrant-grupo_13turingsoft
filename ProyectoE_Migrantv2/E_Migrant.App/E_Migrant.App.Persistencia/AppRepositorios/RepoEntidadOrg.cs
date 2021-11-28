using System.Collections;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class RepoEntidadOrg : IRepoEntidadOrg
    {
        private readonly ContextApp _appContext = new ContextApp();
        EntidadOrg IRepoEntidadOrg.AddEntidadOrg(EntidadOrg entidad)
        {
            var EntidadAdicionada = _appContext.EntidadesOrgs.Add(entidad);
            _appContext.SaveChanges();
            return EntidadAdicionada.Entity;
        }
    }
}