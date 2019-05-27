using DomainModel;
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
    public class DbContext
    {
        private readonly IMongoDatabase database;

        public DbContext()
        {
            var client = new MongoClient();
            database = client.GetDatabase("prova");

            BsonClassMap.RegisterClassMap<Persona>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(c => c.Id)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }

        public IMongoCollection<Persona> PersoneCollection
        {
            get { return database.GetCollection<Persona>("persone"); }
        }
    }
}
