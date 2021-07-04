using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories
{
    public interface ICargoUserRepository : IRepository<CargoUser>
    {
        IEnumerable<CargoUser> BuscarPorCargo(string cargo);
    }
}
