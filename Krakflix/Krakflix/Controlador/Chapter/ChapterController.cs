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
        private KrakflixDBEntities3 krakflixContext;
        private Random rnd;
        public bool addChapter(Chapter chapter)
        {
            try
            {
                krakflixContext = new KrakflixDBEntities3();
                rnd = new Random();
                chapter.IdChapter = chapter.NombreCap.ElementAt(2).ToString() + chapter.NombreCap.ElementAt(4) + rnd.Next(10, 100);
                krakflixContext.Chapters.Add(chapter);
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
            krakflixContext = new KrakflixDBEntities3();
            Chapter chapterFinal = krakflixContext.Chapters.SingleOrDefault(c => c.IdChapter == chapterToEdit.IdChapter);
            
            if (chapterFinal != null)
            {
                chapterFinal = chapterToEdit;
                krakflixContext.Chapters.AddOrUpdate(chapterFinal);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }

        public bool removeChapter(string chapterTitle)
        {
            krakflixContext = new KrakflixDBEntities3();
            var chapterToDelete = krakflixContext.Chapters.SingleOrDefault(f => f.NombreCap == chapterTitle);
            if (chapterToDelete != null)
            {
                krakflixContext.Chapters.Remove(chapterToDelete);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
        }
    }
}
