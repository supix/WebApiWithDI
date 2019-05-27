using DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.InMemory
{
    public class DbPersone
    {
        private IList<Persona> persone = new List<Persona>();
        public void Save(Persona persona)
        {
            persone.Add(persona);
        }

        public IEnumerable<Persona> GetAll()
        {
            return this.persone;
        }
    }
}
