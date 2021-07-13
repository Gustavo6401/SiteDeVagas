using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories 
{
    public interface ICandidateRepository : IRepository<Candidate> 
    {
        IEnumerable<Candidate> ProcurarPorNome(string nome);
        IEnumerable<Candidate> ProcurarPorEMail(string email);
        IEnumerable<Candidate> ProcurarPorArea(string nome);
        IEnumerable<Candidate> ProcurarPorCargo(string nome);
        IEnumerable<Candidate> ProcurarPorDataDeNascimento(DateTime dataNascimento);
        IEnumerable<Candidate> ProcurarPorEscolaridadeAtual(string escolaridade);
        IEnumerable<Candidate> ProcurarPorPretencaoSalarialMinima(decimal salario);
        IEnumerable<Candidate> ProcurarPorPretencaoSalarialMaxima(decimal salario);
        Candidate BuscarCandidato(string nome,
                                  string email,
                                  DateTime dataNascimento,
                                  string escolaridade,
                                  string empresa,
                                  decimal salarioMinimo,
                                  decimal salarioMaximo);

        Candidate BuscarPorCPF(string cpf);
    }
}