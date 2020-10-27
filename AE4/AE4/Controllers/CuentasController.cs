using AE4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE4.Controllers
{
    public class CuentasController : ApiController
    { // GET: api/Cuentas
        /* public IEnumerable<Cuenta> Get()
         {
             var repo = new CuentaRepository();
             List<Cuenta> cuentas = repo.Retrieve();
             return cuentas;
         }*/

        //public IEnumerable<CuentaDTO> Get()
        //{
        //    var repo = new CuentaRepository();
        //    List<CuentaDTO> cuentas = repo.RetrieveDTO();
        //    return cuentas;
        //}

        // GET: api/Cuentas/5
        public Cuenta Get(int id)
        {
            /* var repo = new CuentaRepository();
             Cuenta c= repo.Retrieve();
             return c;*/
            return null;
        }
        // POST: api/Cuentas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cuentas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cuentas/5
        public void Delete(int id)
        {
        }
    }
}
