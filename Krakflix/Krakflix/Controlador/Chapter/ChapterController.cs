using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    
    public class ChapterController
    {
        //variable para el contexto de la BDD
        private KrakflixDBEntities3 krakflixContext;
        private Random rnd;
        public bool addChapter(Chapter chapter)
        {
            try
            {
                //inicializamos la variable del contexto de la BDD
                krakflixContext = new KrakflixDBEntities3();
                rnd = new Random();
                //Para el id cogemos la letra de la posición 2 y la 4 y le sumamos un numero aleatorio entre 10 y 99
                chapter.IdChapter = chapter.NombreCap.ElementAt(2).ToString() + chapter.NombreCap.ElementAt(4) + rnd.Next(10, 100);
                //añadimos el capitulo
                krakflixContext.Chapters.Add(chapter);
                //y guardamos los cambios
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool modififyChapter(Chapter chapterToEdit)
        {
            //inicializamos la variable del contexto de la BDD
            krakflixContext = new KrakflixDBEntities3();
            //mediante linq seleccionamos el capitulo por el id del capitulo que nos llega como parametro
            Chapter chapterFinal = krakflixContext.Chapters.SingleOrDefault(c => c.IdChapter == chapterToEdit.IdChapter);
            
            if (chapterFinal != null)
            {
                //igulamos el capitulo de la query con el que nos llega como parametro que es el modificado.
                chapterFinal = chapterToEdit;
                krakflixContext.Chapters.AddOrUpdate(chapterFinal);
                //y guardamos los cambios
                krakflixContext.SaveChanges();
                //cerramos conexión
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }

        public bool removeChapter(string chapterTitle)
        {
            //inicializamos la variable del contexto de la BDD
            krakflixContext = new KrakflixDBEntities3();
            //mediante linq seleccionamos el capitulo por el id del capitulo que nos llega como parametro
            var chapterToDelete = krakflixContext.Chapters.SingleOrDefault(f => f.NombreCap == chapterTitle);
            if (chapterToDelete != null)
            {
                //y procedemos a borrarlo
                krakflixContext.Chapters.Remove(chapterToDelete);
                //y guardamos los cambios
                krakflixContext.SaveChanges();
                //cerramos conexión
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
    }
}
