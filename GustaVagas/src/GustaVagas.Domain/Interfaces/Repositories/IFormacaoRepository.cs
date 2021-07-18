using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories
{
    public interface IFormacaoRepository : IRepository<Formacao>
    {
        Formacao ProcurarPorCandidato(string cpf);
    }
}
