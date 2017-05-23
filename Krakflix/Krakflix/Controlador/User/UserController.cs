using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador
{
    public class UserController
    {
        private KrakflixDBEntities3 krakflixContext;
        public bool cambiarPass(User user)
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
            return false;
        }
    }
}
