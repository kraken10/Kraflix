using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class UserController
    {
        private KrakflixDBEntities3 krakflixContext;
        public bool cambiarPass(User user)
        {
            krakflixContext = new KrakflixDBEntities3();
            var UserToEdit = krakflixContext.Users.SingleOrDefault(f => f.IdUser == user.IdUser);

            if (UserToEdit != null)
            {
                UserToEdit = user;
                krakflixContext.Users.AddOrUpdate(UserToEdit);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            return false;
            
        }
        public bool cambiarFoto(User user)
        {
            var UserToEdit = krakflixContext.Users.SingleOrDefault(f => f.IdUser == user.IdUser);
            if (UserToEdit != null)
            {
                UserToEdit = user;
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                return true;
            }
            
            return false;
        }
    }
}
