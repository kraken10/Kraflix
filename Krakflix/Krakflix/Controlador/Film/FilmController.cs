using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class FilmController
    {
        //variable para el contexto de la BDD
        private KrakflixDBEntities3 krakflixContext;
        private Random rnd;
        public bool agregarPeli(Film film)
        {
            try
            {
                rnd = new Random();
                //generamos un idFilm aleatorio atraves de un par de char y un numero aleatorio
                film.IdFilm = film.Title.ElementAt(2).ToString() + film.Title.ElementAt(4) + rnd.Next(10, 100);
                //inicializamos la variable del contexto de la BDD
                krakflixContext = new KrakflixDBEntities3();
                //añadimos el capitulo
                krakflixContext.Films.Add(film);
                //guardamos cambios
                krakflixContext.SaveChanges();
                //cerramos conexión con la BDD
                krakflixContext.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool modificarPeli(Film filmToedit)
        {
            //inicializamos la variable del contexto de la BDD
            krakflixContext = new KrakflixDBEntities3();
            //mediante linq seleccionamos la pelicula por el id de pelicula que nos llega como parametro
            var filmFinal = krakflixContext.Films.SingleOrDefault(f => f.IdFilm == filmToedit.IdFilm);

            if (filmFinal != null)
            {
                //igulamos la pelicula de la query con la que nos llega como parametro que es la modificado.
                filmFinal = filmToedit;
                krakflixContext.Films.AddOrUpdate(filmFinal);
                //y guardamos los cambios
                krakflixContext.SaveChanges();
                //cerramos conexión con la BDD
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
        public bool borrarPeli(string filmSelected)
        {
            //inicializamos la variable del contexto de la BDD
            krakflixContext = new KrakflixDBEntities3();
            //mediante linq seleccionamos la pelicula por el titulo de pelicula que nos llega como parametro
            var filmtoDelete = krakflixContext.Films.SingleOrDefault(f => f.Title == filmSelected);
            if (filmtoDelete != null)
            {
                //borramos
                krakflixContext.Films.Remove(filmtoDelete);
                //guardamos cambios
                krakflixContext.SaveChanges();
                //cerramos conexión con la BDD
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }

    }
}
