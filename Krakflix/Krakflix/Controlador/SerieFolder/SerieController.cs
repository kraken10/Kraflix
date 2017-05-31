using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class SerieController
    {
        private KrakflixDBEntities3 krakflixContext;
        private Random rnd ;
        public bool crearSerie(Serie serie)
        {
            try
            {
                krakflixContext = new KrakflixDBEntities3();
                rnd = new Random();
                serie.IdSerie = serie.Title.ElementAt(2).ToString() + serie.Title.ElementAt(4) + rnd.Next(10, 100);
                krakflixContext.Series.Add(serie);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool modificarSerie(Serie serieToEdit)
        {
            krakflixContext = new KrakflixDBEntities3();
            var serieFinal = krakflixContext.Series.SingleOrDefault(f => f.IdSerie == serieToEdit.IdSerie);

            if (serieFinal != null)
            {
                serieFinal = serieToEdit;
                krakflixContext.Series.AddOrUpdate(serieFinal);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
        public bool removeSerie(string serieTitle)
        {
            krakflixContext = new KrakflixDBEntities3();
            var serieToDelete = krakflixContext.Series.SingleOrDefault(f => f.Title == serieTitle);
            if (serieToDelete != null)
            {
                krakflixContext.Series.Remove(serieToDelete);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
    }
}
