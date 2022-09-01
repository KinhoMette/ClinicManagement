using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ClinicManagement.Infra.Context;
using ClinicManagement.Domain.Repositories;

namespace ClinicManagement.Infra.Repositorios
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MainContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public GenericRepository(MainContext contexto)
        {
            Db = contexto;
            DbSet = Db.Set<TEntity>();
        }

        public void Add(TEntity entidade)
        {
            DbSet.Add(entidade);
        }

        public void Update(TEntity entidade)
        {
            DbSet.Update(entidade);
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}