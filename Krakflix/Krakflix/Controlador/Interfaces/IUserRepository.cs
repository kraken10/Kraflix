using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krakflix.Controlador.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
    }
}
