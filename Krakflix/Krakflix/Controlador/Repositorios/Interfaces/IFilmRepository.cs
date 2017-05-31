using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Interfaces
{
    public interface IFilmRepository
    {
        IQueryable<Film> GetAll();
        IQueryable<Film> GetByUser(IQueryable<Film> films, int genre, User user);
        IQueryable<Film> GetBytitle(IQueryable<Film> films, string filmSelected);
    }
}
