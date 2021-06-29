using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Entities.Base 
{
    public interface IEnterpriseRepository : IRepository<Enterprise> 
    {
        IEnumerable<Enterprise> BuscarPorNome(string nome);
        IEnumerable<Enterprise> BuscarPorCNPJ(string cnpj);
        IEnumerable<Enterprise> BuscarPorCidade(string cidade);
    }
}