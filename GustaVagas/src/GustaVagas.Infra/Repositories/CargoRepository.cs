using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class CargoRepository : Repository<Cargo>, ICargoRepository
    {
        VagasContext Db = new();
        public IEnumerable<Cargo> ProcurarPorArea(string area)
        {
            return Db.Cargo.Where(t => t.Area.NameArea.Contains(area));
        }
        public IEnumerable<Cargo> ProcurarPorNome(string nome)
        {
            return Db.Cargo.Where(t => t.Nome.Contains(nome));
        }
    }
}
