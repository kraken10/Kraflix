using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    
    public class ChapterController
    {
        private KrakflixDBEntities3 krakflixContext = new KrakflixDBEntities3();

        public bool modififyChapter(Chapter chapter)
        {
            return false;
        }

        public bool removeChapter(string ChapterTitle)
        {

            return false;
        }
    }
}
