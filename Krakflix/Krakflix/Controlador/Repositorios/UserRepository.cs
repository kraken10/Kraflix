using Krakflix.Controlador.Interfaces;
using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class UserRepository : IUserRepository
    {
        private KrakflixDBEntities3 krakflixContext;

        public IQueryable<User> GetAll()
        {
            krakflixContext = new KrakflixDBEntities3();

            var query = from f in krakflixContext.Users
                        orderby f.IdUser
                        select f;

            return query;
        }
    }
}
