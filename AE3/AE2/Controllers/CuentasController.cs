using AE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE2.Controllers
{
    public class CuentasController : ApiController
    {
        // GET: api/Cuentas
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
      /*  public void Post([FromBody] Cuenta cuenta)
        {
            var repo = new CuentaRepository();
            repo.Save(cuenta);
        }
      */
        // PUT: api/Cuentas/5
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/Cuentas/5
        public void Delete(int id)
        {
        }
    }
}
