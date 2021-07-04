using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class CargoUserRepository : Repository<CargoUser>, ICargoUserRepository
    {
        public IEnumerable<CargoUser> BuscarPorCargo(string cargo)
        {
            VagasContext Db = new();

            return Db.CargoUser.Where(t => t.Cargo.Nome.Contains(cargo));
        }
    }
}
