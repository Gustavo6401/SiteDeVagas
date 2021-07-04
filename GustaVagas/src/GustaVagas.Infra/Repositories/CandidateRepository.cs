using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class CandidateRepository : Repository<Candidate>, ICandidateRepository
    {
        VagasContext Db = new();
        public Candidate BuscarCandidato(string nome, string email, DateTime dataNascimento, string escolaridade, string empresa, decimal salarioMinimo, decimal salarioMaximo)
        {
            return Db.Candidate.FirstOrDefault(t => t.Name.Contains(nome)
                                               ||   t.Email.Contains(email)
                                               ||   t.DataNascimento == dataNascimento
                                               ||   t.Escolaridade.Contains(escolaridade)
                                               ||   t.Empresa.Contains(empresa)
                                               ||   t.PretencaoSalarialMinima >= salarioMinimo
                                               ||   t.PretencaoSalarialMaxima <= salarioMaximo);
        }

        public IEnumerable<Candidate> ProcurarPorArea(string nome)
        {
            // Vou pegar todos os Ids de um usuário de alguma área.
            AreaUserRepository repository = new AreaUserRepository();
            List<AreaUser> usuario = repository.ProcurarPorArea(nome).ToList();

            // Cada ID que for pego na tabela da área do usuário será transferido para a tabela de candidato.
            List<Candidate> listaCandidatos = new();

            // Nesse foreach, eu pego a lista cheia de todos os candidatos que tem uma área específica.
            foreach(AreaUser item in usuario)
            {
                listaCandidatos = Db.Candidate.Where(t => t.Id == item.Id)
                                              .ToList();
            }

            return listaCandidatos;
        }

        public IEnumerable<Candidate> ProcurarPorCargo(string nome)
        {
            CargoUserRepository repository = new();
            List<CargoUser> usuario = repository.BuscarPorCargo(nome).ToList();

            // Cada ID que for pego na tabela da área do usuário será transferido para a tabela de candidato.
            List<Candidate> listaCandidatos = new();

            // Nesse foreach, eu pego a lista cheia de todos os candidatos que tem uma área específica.
            foreach (CargoUser item in usuario)
            {
                listaCandidatos = Db.Candidate.Where(t => t.Id == item.Id)
                                              .ToList();
            }

            return listaCandidatos;
        }

        public IEnumerable<Candidate> ProcurarPorDataDeNascimento(DateTime dataNascimento)
        {
            return Db.Candidate.Where(t => t.DataNascimento == dataNascimento);
        }

        public IEnumerable<Candidate> ProcurarPorEMail(string email)
        {
            return Db.Candidate.Where(t => t.Email.Contains(email));
        }

        public IEnumerable<Candidate> ProcurarPorEmpresa(string empresa)
        {
            return Db.Candidate.Where(t => t.Empresa.Contains(empresa));
        }

        public IEnumerable<Candidate> ProcurarPorEscolaridadeAtual(string escolaridade)
        {
            return Db.Candidate.Where(t => t.Escolaridade.Contains(escolaridade));
        }

        public IEnumerable<Candidate> ProcurarPorNome(string nome)
        {
            return Db.Candidate.Where(t => t.Name.Contains(nome));
        }

        public IEnumerable<Candidate> ProcurarPorPretencaoSalarialMaxima(decimal salario)
        {
            return Db.Candidate.Where(t => t.PretencaoSalarialMinima == salario);
        }

        public IEnumerable<Candidate> ProcurarPorPretencaoSalarialMinima(decimal salario)
        {
            return Db.Candidate.Where(t => t.PretencaoSalarialMaxima == salario);
        }
    }
}
