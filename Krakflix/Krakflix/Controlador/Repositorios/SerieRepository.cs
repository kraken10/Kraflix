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
        public IQueryable<Serie> getAll()
        {
            krakflixContext = new KrakflixDBEntities3();
            var query = from s in krakflixContext.Series
                        orderby s.IdSerie
                        select s;
            return query;
           
        }
        public IQueryable<Serie> GetById(IQueryable<Serie> series, string serieSelected)
        {
            var query = series.Where(x => x.IdSerie == serieSelected);

            return query;
        }
        
        public IQueryable<Serie>GetBytitle(IQueryable<Serie> series, string serieSelected)
        {
            var query = series.Where(x => x.Title == serieSelected);

            return query;
        }
        public IQueryable<Serie> GetByUser(IQueryable<Serie> series, int genre, User user)
        {
            var query = series.Where(x => x.IdUser == user.IdUser);

            if (genre != -1)
                query = query.Where(x => x.IdGenre == genre);

            return query;
        }
        

    }
}
