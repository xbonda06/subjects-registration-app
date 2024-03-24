﻿using ICS.DAL.Entities;
using ICS.DAL.Mappers;
using ICS.DAL.Repositories;
using System;
using System.Threading.Tasks;

namespace ICS.DAL.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<TEntity> GetRepository<TEntity, TEntityMapper>()
            where TEntity : class, IEntity
            where TEntityMapper : IEntityMapper<TEntity>, new();

        Task CommitAsync();
    }
}