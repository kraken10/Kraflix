using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Serie
{
    public class SerieController
    {
        private KrakflixDBEntities3 krakflixContext = new KrakflixDBEntities3();
        public bool crearSerie()
        {
            return false;
        }
        public bool modificarSerie()
        {
            return false;
        }
        public bool removeSerie(string serieTitle)
        {
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
