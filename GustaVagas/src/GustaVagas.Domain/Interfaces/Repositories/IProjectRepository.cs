using System;
using System.Collections.Generic;
using GustaVagas.Domain.Entities;
using GustaVagas.Domain.Interfaces.Repositories.Base;

namespace GustaVagas.Domain.Interfaces.Repositories 
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> BuscarPorAutor(string nome);
        IEnumerable<Project> BuscarPorNome(string nome);
        IEnumerable<Project> BuscarPorUrl(string url);
        IEnumerable<Project> BuscarPorTipo(string tipo);
        IEnumerable<Project> BuscarPorArea(string area);
    }
}