using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            return UsuarioData.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody]Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody]Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return UsuarioData.Eliminar(id);
        }
    }
}