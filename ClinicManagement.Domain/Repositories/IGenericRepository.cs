using System;
using System.Collections.Generic;

namespace ClinicManagement.Domain.Repositories
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entidade);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Update(TEntity entidade);

        void Remove(int id);

        int SaveChanges();
    }
}