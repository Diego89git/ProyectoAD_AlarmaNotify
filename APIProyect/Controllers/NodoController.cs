using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using APIProyect.Models;
using NegocioProyect;
using EntidadesProyect;

namespace APIProyect.Controllers
{
    public class NodoController : ApiController
    {
        // GET api/<controller>
        public List<NodoEntidad> Get()
        {
            return NodoNegocio.DevolverListadoNodos();
        }

        // GET api/<controller>/5
        public NodoEntidad Get(int id)
        {
            return NodoNegocio.DevolverNodoPorId(id);
        }


        // POST api/<controller>
        public IHttpActionResult Post([FromBody] NodoEntidad nodo)
        {
            return Ok(NodoNegocio.GuardarNodo(nodo));
          
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] NodoEntidad nodo)
        {
           return Ok( NodoNegocio.GuardarNodo(nodo));
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            NodoEntidad nodoEntidad = new NodoEntidad();
            if (nodoEntidad==null)
            {
                return NotFound();
            }
            else
            {
                NodoNegocio.EliminarNodo(id);
            }
            return Ok(nodoEntidad);
        }
    }
}