using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Interfaces
{
    public interface IChapterRepository
    {
        IQueryable<Chapter> getAll();
        IQueryable<Chapter> getById(IQueryable<Chapter> allChapters, string titleSerie, int temp);
        IQueryable<Chapter> getChapterToPlay(IQueryable<Chapter> chapters, string idSerie, int tempSelected);
        IQueryable<Chapter> getTemps(IQueryable<Chapter> allChapters, Serie serie);
    }
}
