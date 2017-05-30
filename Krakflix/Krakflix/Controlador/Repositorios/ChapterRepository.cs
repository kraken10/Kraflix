using Krakflix.Controlador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Krakflix.Modelo;

namespace Krakflix.Controlador.Repositorios
{
    public class ChapterRepository : IChapterRepository
    {
        private KrakflixDBEntities3 krakflixContext;
        public IQueryable<Chapter> getAll()
        {
            krakflixContext = new KrakflixDBEntities3();
            var query = from c in krakflixContext.Chapters
                        orderby c.IdChapter
                        select c;
            return query;
        }
        
        public IQueryable<Chapter> getById(IQueryable<Chapter> allChapters, string idSerie, int temp)
        {
            var query = from c in allChapters.Where(c => c.IdSerie == idSerie && c.Temp == temp)
                        select c;
            return query;
        }
        public IQueryable<Chapter> getChapterToPlay(IQueryable<Chapter> chapters, string idSerie, int tempSelected, string title)
        {
            var query = chapters.Where(c => c.IdSerie == idSerie && c.NombreCap == title);
            return query;
        }

        public int getTemps(IQueryable<Chapter> allChapters, Serie serie)
        {
            var query = allChapters.Where(c => c.IdSerie == serie.IdSerie).Max(c => c.Temp);
                  
            return query;
        }

        public IQueryable<Chapter> getByTitle(IQueryable<Chapter> allChapters, string chapterTitle)
        {
            var query = allChapters.Where(c => c.NombreCap == chapterTitle);
            return query;
        }
    }
}
