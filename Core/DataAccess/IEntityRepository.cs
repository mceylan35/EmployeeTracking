﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity ,new() //T IEntity türünde olmalıdır ve new lenebilir olmalı
    {
        T Get(Expression<Func<T, bool>> filter);
       
        IList<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);

    }
}
