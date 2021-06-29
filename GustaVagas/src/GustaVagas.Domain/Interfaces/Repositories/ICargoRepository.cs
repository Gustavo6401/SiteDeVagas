using System;
using System.Collections.Generic;
using GustaVagas.Domain.Interfaces.Repositories.Base;
using GustaVagas.Domain.Entities;

namespace GustaVagas.Domain.Interfaces.Repositories
{
    public interface ICargoRepository : IRepository<Cargo>
    {
        IEnumerable<Cargo> ProcurarPorNome(string nome);
        IEnumerable<Cargo> ProcurarPorArea(string area);
    }
}