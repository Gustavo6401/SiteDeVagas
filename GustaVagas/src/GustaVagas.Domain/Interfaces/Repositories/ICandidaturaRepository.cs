using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories
{
    public interface ICandidaturaRepository : IRepository<Candidatura>
    {
        IEnumerable<Candidatura> PesquisarPorVaga(string vaga);
        IEnumerable<Candidatura> PesquisarPorCandidato(string nome);
        IEnumerable<Candidatura> PesquisarPorEmpresa(string nome);
    }
}
