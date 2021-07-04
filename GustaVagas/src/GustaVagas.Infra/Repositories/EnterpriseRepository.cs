using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class EnterpriseRepository : Repository<Enterprise>, IEnterpriseRepository
    {
        VagasContext Db = new();
        public IEnumerable<Enterprise> BuscarPorCidade(string cidade)
        {
            return Db.Enterprise.Where(t => t.Cidade.Contains(cidade));
        }

        public Enterprise BuscarPorCNPJ(string cnpj)
        {
            return Db.Enterprise.FirstOrDefault(t => t.CNPJ.Contains(cnpj));
        }

        public IEnumerable<Enterprise> BuscarPorNome(string nome)
        {
            return Db.Enterprise.Where(t => t.Name.Contains(nome));
        }
    }
}
