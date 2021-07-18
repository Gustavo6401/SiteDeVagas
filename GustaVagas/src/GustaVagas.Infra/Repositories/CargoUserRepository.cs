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
        VagasContext Db = new();

        public IEnumerable<CargoUser> BuscarPorCargo(string cargo)
        {
            return Db.CargoUser.Where(t => t.Cargo.Nome.Contains(cargo));
        }

        public IEnumerable<CargoUser> BuscarPorUsuario(string cpf)
        {
            return Db.CargoUser.Where(t => t.Candidate.CPF.Contains(cpf));
        }
    }
}
