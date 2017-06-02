using Krakflix.Controlador.Interfaces;
using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Repositorios
{
    public class SerieRepository : ISerieRepository
    {
        private KrakflixDBEntities3 krakflixContext;
        //devuelve todas las series
        public IQueryable<Serie> getAll()
        {
            krakflixContext = new KrakflixDBEntities3();
            var query = from s in krakflixContext.Series
                        orderby s.IdSerie
                        select s;
            return query;
           
        }
        //devuelve la serie indicandole el idSerie
        public IQueryable<Serie> GetById(IQueryable<Serie> series, string serieSelected)
        {
            var query = series.Where(x => x.Title == serieSelected);

            return query;
        }
        //devuelve la serie indicandole el titulo
        public IQueryable<Serie>GetBytitle(IQueryable<Serie> series, string serieSelected)
        {
            var query = series.Where(x => x.Title == serieSelected);

            return query;
        }
        //devuelve la serie por usuario
        public IQueryable<Serie> GetByUser(IQueryable<Serie> series, int genre, User user)
        {
            var query = series.Where(x => x.IdUser == user.IdUser);

            if (genre != -1)
                query = query.Where(x => x.IdGenre == genre);

            return query;
        }
        //devuleve las temporadas pasandole idSerie
        public int getTempsById (IQueryable<Serie> series, string idSerie)
        {
            var query = series.Where(c => c.IdSerie == idSerie).Max(c => c.NumTemp);
            
            return query;
        }
    }
}
