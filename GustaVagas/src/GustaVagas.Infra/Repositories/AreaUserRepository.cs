using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class AreaUserRepository : Repository<AreaUser>, IAreaUserRepository
    {
        public IEnumerable<AreaUser> ProcurarPorArea(string nome)
        {
            VagasContext Db = new();

            return Db.AreaUser.Where(t => t.Area.NameArea.Contains(nome));
        }
    }
}
