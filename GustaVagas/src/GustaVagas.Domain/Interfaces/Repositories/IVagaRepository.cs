using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories 
{
    public interface IVagaRepository : IRepository<Vaga> 
    {
        IEnumerable<Vaga> ProcurarVagas(string nome, 
                                        decimal salario,
                                        string senioridade,
                                        string escolaridade,
                                        bool remoto,
                                        bool temporario,
                                        bool freelance,
                                        bool paraPessoaJuridica,
                                        string cargo);
        IEnumerable<Vaga> ProcurarPorNome(string nome);
        IEnumerable<Vaga> ProcurarPorSalario(decimal salario);
        IEnumerable<Vaga> ProcurarPorSenioridade(string senioridade);
        IEnumerable<Vaga> ProcurarPorEscolaridade(string escolaridade);
        IEnumerable<Vaga> ProcurarVagasRemotas(bool remoto);
        IEnumerable<Vaga> ProcurarEmpregoTemporario(bool temporario);
        IEnumerable<Vaga> ProcurarFreelance(bool freelance);
        IEnumerable<Vaga> ProcurarEmpregoParaPJ(bool paraPessoaJuridica);
        IEnumerable<Vaga> ProcurarPeloCargo(string cargo);
    }
}