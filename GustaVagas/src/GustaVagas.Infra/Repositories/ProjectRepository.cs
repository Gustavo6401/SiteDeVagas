using System;
using System.Collections.Generic;
using System.Linq;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories;
using GustaVagas.Infra.Contexto;
using GustaVagas.Infra.Repositories.Base;

namespace GustaVagas.Infra.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        VagasContext Db = new();
        public IEnumerable<Project> BuscarPorArea(string area)
        {
            return Db.Project.Where(t => t.Area.NameArea.Contains(area));
        }

        public IEnumerable<Project> BuscarPorAutor(string cpf)
        {
            return Db.Project.Where(t => t.Candidato.CPF.Contains(cpf));
        }

        public IEnumerable<Project> BuscarPorEmpresa(string cnpj)
        {
            return Db.Project.Where(t => t.Empresa.CNPJ.Contains(cnpj));
        }
        public IEnumerable<Project> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> BuscarPorTipo(string tipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> BuscarPorUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
