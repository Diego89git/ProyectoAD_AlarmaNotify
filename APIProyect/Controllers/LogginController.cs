using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NegocioProyect;
using EntidadesProyect;

namespace APIProyect.Controllers
{
    public class LogginController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/user/pass
        public NodoEntidad Get(string user, string pass)
        {
            NodoEntidad tmp = new NodoEntidad();
            var nodoUser = NodoNegocio.DevolverNodoPorUsuario(user);
            if (nodoUser.Id!=0)
            {
               tmp=  NodoNegocio.DevolverNodoPorLoggin(user, pass);
                if (tmp.Id==0)
                {
                    tmp.Id = -2;
                }
            }
            else
            {
                tmp.Id =-1 ;
            }
            return tmp;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}