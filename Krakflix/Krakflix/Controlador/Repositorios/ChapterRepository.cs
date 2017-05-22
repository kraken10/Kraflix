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
            var query = allChapters.Where(c => c.IdSerie == idSerie);
            //var query = query.Where(c => c.IdSerie == idSerie).Where(c => c.temp == temp);

            //return query;
            return query;
        }
        public IQueryable<Chapter> getChapterToPlay(IQueryable<Chapter> chapters, string idSerie, int tempSelected)
        {
            var query = chapters.Where(c => c.IdSerie == idSerie);
            //var query = chapters.Where(c => c.IdSerie == idSerie).Where(c => c.temp == tempSelected);
            return query;
        }
    }
}
