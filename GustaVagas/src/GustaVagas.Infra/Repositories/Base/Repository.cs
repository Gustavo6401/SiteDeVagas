using GustaVagas.Domain.Interfaces.Repositories.Base;
using GustaVagas.Domain.Entities.Base;
using GustaVagas.Infra.Contexto;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GustaVagas.Infra.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        VagasContext Db = new();
        public void Add(T entity)
        {
            Db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);

            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return Db.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            Db.Modify(entity);

            Db.SaveChanges();
        }
    }
}
