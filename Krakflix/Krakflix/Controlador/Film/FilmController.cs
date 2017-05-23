using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class FilmController
    {
        private KrakflixDBEntities3 krakflixContext;
        private Random rnd;
        public bool agregarPeli(Film film)
        {
            try
            {
                rnd = new Random();
                //generamos un idFilm aleatorio atraves de un par de char y un numero aleatorio
                film.IdFilm = film.Title.ElementAt(2).ToString() + film.Title.ElementAt(4) + rnd.Next(10, 100);
                krakflixContext = new KrakflixDBEntities3();
                krakflixContext.Films.Add(film);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool modificarPeli(Film film)
        {
            var filmToedit = krakflixContext.Films.SingleOrDefault(f => f.IdFilm == film.IdFilm);
            if (filmToedit != null)
            {
                filmToedit = film;
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
        public bool borrarPeli(string filmSelected)
        {
            var filmtoDelete = krakflixContext.Films.SingleOrDefault(f => f.Title == filmSelected);
            if (filmtoDelete != null)
            {
                krakflixContext.Films.Remove(filmtoDelete);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }

    }
}
