using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories
{
    public interface IAreaUserRepository : IRepository<AreaUser>
    {
        IEnumerable<AreaUser> ProcurarPorArea(string nome);
    }
}
