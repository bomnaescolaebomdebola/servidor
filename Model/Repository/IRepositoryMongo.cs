using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Model.Repository
{
    public interface IRepositoryMongo<TEntity> where TEntity : Mongo.MongoID
    {
         void Add(string identificador, TEntity entity);
         void AddAll(string identificador, List<TEntity> entity);
         void Edit(string identificador, TEntity entity);
         void Delete(string identificador, TEntity entity);
         List<TEntity> Get( string identificador,Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null); 
    }
}