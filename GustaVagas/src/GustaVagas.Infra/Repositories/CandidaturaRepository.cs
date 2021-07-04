using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class CandidaturaRepository : Repository<Candidatura>, ICandidaturaRepository
    {
        VagasContext Db = new();
        public IEnumerable<Candidatura> PesquisarPorCandidato(string nome, bool pessoaFisica)
        {
            /// Ele está verificando se o candidato é mesmo pessoa física.
            return pessoaFisica switch
            {
                true => Db.Candidatura.Where(t => t.Candidato.Name.Contains(nome)),
                false => Db.Candidatura.Where(t => t.CandidatoPJ.Name.Contains(nome)),
            };
        }

        public IEnumerable<Candidatura> PesquisarPorEmpresa(string nome, bool pessoaJuridica)
        {
            /// Ele está verificando se o contratante é mesmo pessoa jurídica
            return pessoaJuridica switch
            {
                true => Db.Candidatura.Where(t => t.Enterprise.Name.Contains(nome)),
                false => Db.Candidatura.Where(t => t.ContratantePF.Name.Contains(nome)),
            };
        }

        public IEnumerable<Candidatura> PesquisarPorVaga(string vaga)
        {
            return Db.Candidatura.Where(t => t.Vaga.Nome.Contains(vaga));
        }
    }
}
