using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        VagasContext Db = new();
        public IEnumerable<Area> ProcurarPorNome(string nome)
        { 
            return Db.Area.Where(t => t.NameArea.Contains(nome));
        }
        public Area ProcurarArea(string nome)
        {
            return Db.Area.FirstOrDefault(t => t.NameArea.Contains(nome));
        }
    }
}
