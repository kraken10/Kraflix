using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Login
{
    public class LoginController
    {
        private UserRepository userRepo = new UserRepository();

        public bool verificarUser(string user, string pass)
        {
            
            var allUsers = userRepo.GetAll();
            var query = allUsers.Where(u => u.UserName == user).Where(p => p.Password == pass).ToList();

            if(query.Count > 0)
                return true;
            else
            return false;
        }
    }
}
