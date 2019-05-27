using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Servizi
{
    public interface IGetTutteLePersone
    {
        IEnumerable<Persona> Get();
    }
}
