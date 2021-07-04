using System;
using System.Linq;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Domain.Interfaces.Repositories.Base;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        VagasContext Db = new();
        public Usuario FazerLogin(string email, string password)
        {
            return Db.Usuario.FirstOrDefault(t => t.EMail.Contains(email)
                                             ||   t.Password.Contains(password));
        }

        public Usuario FazerLoginComUserName(string userName, string password)
        {
            return Db.Usuario.FirstOrDefault(t => t.UserName.Contains(userName)
                                             ||   t.Password.Contains(password));
        }
    }
}
