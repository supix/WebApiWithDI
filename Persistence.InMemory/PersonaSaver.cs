using DomainModel;
using DomainModel.Servizi;
using System;

namespace Persistence.InMemory
{
    public class PersonaSaver : IPersonaSaver
    {
        private readonly DbPersone dbPersone;

        public PersonaSaver(DbPersone dbPersone)
        {
            this.dbPersone = dbPersone;
        }

        public void Save(Persona persona)
        {
            this.dbPersone.Save(persona);
        }
    }
}
