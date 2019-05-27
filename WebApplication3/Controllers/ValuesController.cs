using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DomainModel;
using DomainModel.Servizi;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPersonaSaver personaSaver;
        private readonly IGetTutteLePersone getTutteLePersone;

        public ValuesController(IPersonaSaver personaSaver, IGetTutteLePersone getTutteLePersone)
        {
            this.personaSaver = personaSaver ?? throw new ArgumentNullException(nameof(personaSaver));
            this.getTutteLePersone = getTutteLePersone ?? throw new ArgumentNullException(nameof(getTutteLePersone));
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get()
        {
            return Ok(getTutteLePersone.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Persona persona)
        {
            personaSaver.Save(persona);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
