using System.Collections;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;


namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidadColaboradora : IRepositorioEntidadColaboradora
    {
        private readonly AppContext _appContext = new AppContext();
        EntidadColaboradora IRepositorioEntidadColaboradora.AddEntidadColaboradora(EntidadColaboradora entidadColaboradora)
        {
            var EntidadAdicionada = _appContext.EntidadesColaboradoras.Add(entidadColaboradora);
            _appContext.SaveChanges();
            return EntidadAdicionada.Entity;
        }
    }
}
