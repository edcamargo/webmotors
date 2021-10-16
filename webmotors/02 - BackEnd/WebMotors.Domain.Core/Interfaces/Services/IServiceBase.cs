﻿using System.Collections.Generic;

namespace WebMotors.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}