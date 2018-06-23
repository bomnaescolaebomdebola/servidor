using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Model.Repository
{
    public class RepositoryMongo<TEntity> : IRepositoryMongo<TEntity> where TEntity : Mongo.MongoID
    {
        private MongoDB.Driver.IMongoDatabase dataBase;

        public RepositoryMongo(IConfiguration configuration)
        {
            var client = new MongoDB.Driver.MongoClient(configuration.GetConnectionString("defaultConnection"));
            this.dataBase = client.GetDatabase(configuration.GetConnectionString("dataBaseName"));
        }

        public void Add(string identificador,TEntity entity)
        {
            var dados = this.dataBase.GetCollection<TEntity>(typeof(TEntity).Name+ "_" + identificador);
            dados.InsertOne(entity);
        }
        public void AddAll(string identificador, List<TEntity> entity)
        {
            var dados = this.dataBase.GetCollection<TEntity>(typeof(TEntity).Name + "_" + identificador);
            dados.InsertMany(entity);
        }
        public void Edit(string identificador, TEntity entity)
        {
            var dados = this.dataBase.GetCollection<TEntity>(typeof(TEntity).Name + "_" + identificador);
            var filtro = Builders<TEntity>.Filter.Eq("Id", entity.Id);
            dados.ReplaceOne(filtro, entity);
        }
        public void Delete(string identificador, TEntity entity)
        {
            var dados = this.dataBase.GetCollection<TEntity>(typeof(TEntity).Name + "_" + identificador);
            var filtro = Builders<TEntity>.Filter.Eq("Id", entity.Id);
            dados.DeleteOne(filtro);
        }

        public virtual List<TEntity> Get(string identificador,Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            var dados = this.dataBase.GetCollection<TEntity>(typeof(TEntity).Name+ "_" + identificador);
            return dados.Find<TEntity>(new BsonDocument()).ToList();
        }
    }
}