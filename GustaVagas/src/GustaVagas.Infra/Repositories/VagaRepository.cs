using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class VagaRepository : Repository<Vaga>, IVagaRepository
    {
        VagasContext Db = new();
        public IEnumerable<Vaga> ProcurarEmpregoParaPJ(bool paraPessoaJuridica)
        {
            return Db.Vaga.Where(t => t.PessoaJuridica == paraPessoaJuridica);
        }

        public IEnumerable<Vaga> ProcurarEmpregoTemporario(bool temporario)
        {
            return Db.Vaga.Where(t => t.Temporario == temporario);
        }

        public IEnumerable<Vaga> ProcurarFreelance(bool freelance)
        {
            return Db.Vaga.Where(t => t.Freelance == freelance);
        }

        public IEnumerable<Vaga> ProcurarPeloCargo(string cargo)
        {
            return Db.Vaga.Where(t => t.Cargo.Nome.Contains(cargo));
        }

        public IEnumerable<Vaga> ProcurarPorEscolaridade(string escolaridade)
        {
            return Db.Vaga.Where(t => t.Escolaridade.Contains(escolaridade));
        }

        public IEnumerable<Vaga> ProcurarPorNome(string nome)
        {
            return Db.Vaga.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Vaga> ProcurarPorSalario(decimal salario)
        {
            return Db.Vaga.Where(t => t.Salario == salario);
        }

        public IEnumerable<Vaga> ProcurarPorSenioridade(string senioridade)
        {
            return Db.Vaga.Where(t => t.Senioridade.Contains(senioridade));
        }

        public IEnumerable<Vaga> ProcurarVagas(string nome, decimal salario, string senioridade, string escolaridade, bool remoto, bool temporario, bool freelance, bool paraPessoaJuridica, string cargo)
        {
            return Db.Vaga.Where(t => t.Nome.Contains(nome)
                                 ||   t.Salario == salario
                                 ||   t.Senioridade.Contains(senioridade)
                                 ||   t.Escolaridade.Contains(escolaridade)
                                 ||   t.Remoto == remoto
                                 ||   t.Temporario == temporario
                                 ||   t.Freelance == freelance
                                 ||   t.PessoaJuridica == paraPessoaJuridica
                                 ||   t.Cargo.Nome.Contains(nome));
        }

        public IEnumerable<Vaga> ProcurarVagasRemotas(bool remoto)
        {
            return Db.Vaga.Where(t => t.Remoto == remoto);
        }
    }
}
