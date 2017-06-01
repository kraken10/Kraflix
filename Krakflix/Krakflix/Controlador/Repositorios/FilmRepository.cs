using Krakflix.Controlador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Krakflix.Modelo;

namespace Krakflix.Controlador.Repositorios
{
    public class FilmRepository : IFilmRepository
    {
        private KrakflixDBEntities3 krakflixContext;
        //metodo que devuelve todas las peliculas
        public IQueryable<Film> GetAll()
        {
            krakflixContext = new KrakflixDBEntities3();

            var query = from f in krakflixContext.Films
                        orderby f.IdGenre
                        select f;

            return query;
        }
        //metodo que devuelve las peliculas pasandole el titulo
        public IQueryable<Film> GetBytitle(IQueryable<Film> films, string filmSelected)
        {
            var query = films.Where(x => x.Title == filmSelected);

            return query;
        }
        //metodo que devuelve las peliculas indicandole el id user.
        public IQueryable<Film> GetByUser(IQueryable<Film> films, int genre, User user)
        {
            var query = films.Where(x => x.IdUser == user.IdUser);

            if (genre!=-1)
                query = query.Where(x => x.IdGenre == genre);

            return query;
        }

    }
}
