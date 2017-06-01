using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Login
{
    public class LoginController
    {
        //incializamos el repositorio de usuarios
        private UserRepository userRepo = new UserRepository();

        public User verificarUser(string user, string pass)
        {
            //obtenemos todos los usuarios.
            var allUsers = userRepo.GetAll();
            User query;
            try
            {
                //seleccionamos el usuario comparando con el user y la pass que nos llega como parametro y cogemos el primero.
                query = allUsers.Where(u => u.UserName == user).Where(p => p.Password == pass).First();
            }
            catch (InvalidOperationException)
            {
                return null;
            }
            
            return query;
        }
    }
}
