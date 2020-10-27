using AE4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE4.Controllers
{
    public class ApuestasController : ApiController

      
    {
        ApuestaRepository apurep = new ApuestaRepository();

        // GET: api/Apuesta?tipoMercado=tipoMercado&usariosEmail=usariosEmail
        [Authorize(Roles = "Admin")]
        public void Get(Apuesta a)
        {

            apurep.Save2(a);
        }



        // GET: api/Apuesta?tipoMercado=tipoMercado&usariosEmail=usariosEmail
        [Authorize(Roles = "Admin")]
        public IEnumerable<Apuesta> GetTUsariosEmail(Apuesta a)
        {
            
            List<Apuesta> apuestas = apurep.RetrieveUsariosEmail(a);
            return apuestas;
        }

        public IEnumerable<ApuestaDTO> Get()
        {
           
            List<ApuestaDTO> apuestas = apurep.RetrieveDTO();
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
        public void Post([FromBody] Apuesta apuesta)
        {

            apurep.Save(apuesta);
        }


        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
