using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Entities.Base 
{
    public interface ICandidateRepository : IRepository<Candidate> 
    {
        IEnumerable<Candidate> ProcurarPorNome(string nome);
        IEnumerable<Candidate> ProcurarPorEMail(string email);
        IEnumerable<Candidate> ProcurarPorDataDeNascimento(DateTime dataNascimento);
        IEnumerable<Candidate> ProcurarPorEscolaridadeAtual(string escolaridade);
        IEnumerable<Candidate> ProcurarPorCargo(string cargo);
        IEnumerable<Candidate> ProcurarPorEmpresa(string empresa);
        IEnumerable<Candidate> ProcurarPorPretencaoSalarialMinima(decimal salario);
        IEnumerable<Candidate> ProcurarPorPretencaoSalarialMaxima(decimal salario);
        IEnumerable<Candidate> ProcurarPorArea(string nome);
        IEnumerable<Candidate> BuscarCandidato(string nome,
                                               string email,
                                               DateTime dataNascimento,
                                               string escolaridade,
                                               string area,
                                               string cargo,
                                               string empresa,
                                               decimal salario,
                                               decimal salarioMaximo);
    }
}