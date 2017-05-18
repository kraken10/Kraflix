using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Registrer
{
    public class RegisterController
    {

        User user;
        KrakflixDBEntities3 krakflixContext;
        public bool registerUser(string userName, string pass, string photoPath)
        {
            bool correct = false;

            try
            {
                user = new User();
                krakflixContext = new KrakflixDBEntities3();
                user.UserName = userName;
                user.Password = pass;
                user.photoPath = string.IsNullOrEmpty(photoPath) ? null : photoPath;
                krakflixContext.Users.Add(user);
                krakflixContext.SaveChanges();
                krakflixContext.Dispose();
                correct = true;
            }
            catch (Exception)
            {

                correct = false;
            }

            return correct;
        }
    }
}
