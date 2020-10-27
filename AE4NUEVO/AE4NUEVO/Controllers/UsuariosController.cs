using AE4NUEVO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE4NUEVO.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        [Authorize(Roles = "Standard")]
        public IEnumerable<Usuario> Get()
        {
            var repo = new UsuarioRepository();
            List<Usuario> usuarios = repo.Retrieve();
            return usuarios;
        }


        //public IEnumerable<UsuarioDTO> Get()
        //{
        //    var repo = new UsuarioRepository();
        //    List<UsuarioDTO> usuarios = repo.RetrieveDTO();
        //    return usuarios;
        //}

        // GET: api/Usuarios/5
        public Usuario Get(int id)
        {
            /* var repo = new UsuarioRepository();
             Usuario u= repo.Retrieve();
             return u;*/
            return null;
        }
        // POST: api/Usuarios
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
