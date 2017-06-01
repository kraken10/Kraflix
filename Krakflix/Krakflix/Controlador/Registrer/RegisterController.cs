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
                //instanciamos un objeto User
                user = new User();
                //inicializamos la variable del contexto de la BDD
                krakflixContext = new KrakflixDBEntities3();
                //asignamos las propiedades.
                user.UserName = userName;
                user.Password = pass;
                user.photoPath = string.IsNullOrEmpty(photoPath) ? null : photoPath;
                //añadimos el usuario al conexto
                krakflixContext.Users.Add(user);
                //guardamos cambios
                krakflixContext.SaveChanges();
                //cerramos conexión
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
