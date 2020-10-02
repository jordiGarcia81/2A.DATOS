using AE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE2.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<Evento> Get()
        {
            var repo = new EventoRepository();
            List<Evento> eventos = repo.Retrieve();
            return eventos;
        }

        // GET: api/Eventos/5
        public Evento Get(int id)
        {
            /*var repo = new EventoRepository();
            Evento d = repo.Retrieve();
            return d;*/
            return null;
        }

        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
