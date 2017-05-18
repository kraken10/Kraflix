using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Login
{
    public class LoginController
    {
        private UserRepository userRepo = new UserRepository();

        public User verificarUser(string user, string pass)
        {

            var allUsers = userRepo.GetAll();
            User query;
            try
            {
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
