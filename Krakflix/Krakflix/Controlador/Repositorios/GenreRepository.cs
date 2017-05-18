using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Krakflix;
using Krakflix.Modelo;
using Krakflix.Controlador.Interfaces;

namespace Krakflix.Controlador
{
    public class GenreRepository : IGenreRepository
    {
        private KrakflixDBEntities3 krakflixContext;

        public IQueryable<Genre> GetAll()
        {
            krakflixContext = new KrakflixDBEntities3();

            var query = from f in krakflixContext.Genres
                        orderby f.IdGenre
                        select f;
            
            return query;
        }

       
    }
}
