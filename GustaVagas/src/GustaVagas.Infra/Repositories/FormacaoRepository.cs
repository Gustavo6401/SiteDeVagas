using System;
using System.Linq;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Domain.Interfaces.Repositories.Base;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class FormacaoRepository : Repository<Formacao>, IFormacaoRepository
    {
        public Formacao ProcurarPorCandidato(string cpf)
        {
            VagasContext Db = new();

            return Db.Formacao.FirstOrDefault(t => t.Candidate.CPF.Contains(cpf));
        }
    }
}
