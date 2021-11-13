﻿using Microsoft.EntityFrameworkCore;
using RateMyAir.Common.Entities.Models;
using RateMyAir.Common.Interfaces.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RateMyAir.Common.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DatabaseContext RepositoryContext;

        public RepositoryBase(DatabaseContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            trackChanges ? RepositoryContext.Set<T>() :
            RepositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            trackChanges ? RepositoryContext.Set<T>().Where(expression) :
            RepositoryContext.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
