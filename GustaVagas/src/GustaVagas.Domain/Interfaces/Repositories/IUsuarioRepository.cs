using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories 
{
    public interface IUsuarioRepository : IRepository<Usuario> 
    {
        Usuario FazerLogin(string email, string password);
        Usuario FazerLoginComUserName(string userName, string password);
    }
}