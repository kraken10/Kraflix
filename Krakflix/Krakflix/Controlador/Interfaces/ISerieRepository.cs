using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public interface ISerieRepository
    {
        IQueryable<Serie> getAll();
        IQueryable<Serie> GetBytitle(IQueryable<Serie> series, string serieSelected);
        IQueryable<Serie> GetById(IQueryable<Serie> series, string serieSelected);
        IQueryable<Serie> GetByUser(IQueryable<Serie> series, int genre, User user);
    }
}
