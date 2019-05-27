using DomainModel;
using DomainModel.Servizi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.InMemory
{
    public class GetTutteLePersone : IGetTutteLePersone
    {
        private readonly DbPersone dbPersone;

        public GetTutteLePersone(DbPersone dbPersone)
        {
            this.dbPersone = dbPersone;
        }

        public IEnumerable<Persona> Get()
        {
            return this.dbPersone.GetAll();
        }
    }
}
