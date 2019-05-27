using DomainModel;
using DomainModel.Servizi;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.MongoDB
{
    public class PersonaSaver : IPersonaSaver
    {
        private readonly DbContext dbContext;

        public PersonaSaver(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Save(Persona persona)
        {
            this.dbContext.PersoneCollection.InsertOne(persona);
        }
    }
}
