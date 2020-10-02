using AE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE2.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuesta
        public IEnumerable<Apuesta> Get()
        {
            var repo = new ApuestaRepository();
            List<Apuesta> apuestas = repo.Retrieve();
            return apuestas;
        }

            // GET: api/Apuesta/5
            public Apuesta Get(int id)
        {
            /* var repo = new ApuestaRepository();
             Apuesta a= repo.Retrieve();
             return a;*/
            return null;
        }

        // POST: api/Apuesta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
