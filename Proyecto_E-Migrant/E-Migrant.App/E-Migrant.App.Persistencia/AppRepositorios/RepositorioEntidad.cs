using System.Collections;
using System.Collections.Generic;
using System.Linq;
using E_Migrant.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;


namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private readonly AppContext _appContext = new AppContext();
        Entidad IRepositorioEntidad.AddEntidad(Entidad Entidad)
        {
            var EntidadAdicionada = _appContext.Entidades.Add(Entidad);
            _appContext.SaveChanges();
            return EntidadAdicionada.Entity;
        }
    }
}
