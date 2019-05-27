using DomainModel;
using DomainModel.Servizi;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.MongoDB
{
    public class GetTutteLePersone : IGetTutteLePersone
    {
        private readonly DbContext dbContext;

        public GetTutteLePersone(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Persona> Get()
        {
            return this.dbContext.PersoneCollection.Find(Builders<Persona>.Filter.Empty).ToList();
        }
    }
}
