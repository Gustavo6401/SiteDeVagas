using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories 
{
    public interface IEnterpriseRepository : IRepository<Enterprise> 
    {
        IEnumerable<Enterprise> BuscarPorNome(string nome);
        Enterprise BuscarPorCNPJ(string cnpj);
        IEnumerable<Enterprise> BuscarPorCidade(string cidade);
    }
}