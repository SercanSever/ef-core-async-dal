﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Data.DataAccees
{
    public interface IEntityRepository<T> where T : class,new()
    {
        Task<List<T>> GetAll(Expression<Func<T,bool>> filter = null);
        Task<T> Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}