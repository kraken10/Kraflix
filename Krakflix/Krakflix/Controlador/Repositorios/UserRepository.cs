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
        //devuelve todos los usuarios
        public IQueryable<User> GetAll()
        {
            krakflixContext = new KrakflixDBEntities3();

            var query = from f in krakflixContext.Users
                        orderby f.IdUser
                        select f;

            return query;
        }
        //devuelve el usuario pasandole id
        public IQueryable<User> GetbyId(int user)
        {
            krakflixContext = new KrakflixDBEntities3();

            var query = from f in krakflixContext.Users
                        select f;
            query = query.Where(u => u.IdUser == user);
            return query;
        }
    }
}
