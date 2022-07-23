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
    public class IncidenciaController : ApiController
    {
        // GET api/<controller>
        public List<IncidenciaEntidad> Get()
        {
            return IncidenciaNegocio.DevolverListadoIncidentes();
        }

        // GET api/<controller>/5
        public IncidenciaEntidad Get(int id)
        {
            return IncidenciaNegocio.DevolverIncidentePorId(id);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] IncidenciaEntidad incidencia)
        {
            return Ok(IncidenciaNegocio.GuardarIncidencia(incidencia));

        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] IncidenciaEntidad incidencia)
        {
            return Ok(IncidenciaNegocio.GuardarIncidencia(incidencia));
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            IncidenciaEntidad incidencia = new IncidenciaEntidad();
            if (incidencia == null)
            {
                return NotFound();
            }
            else
            {
                IncidenciaNegocio.EliminarIncidente(id);
            }
            return Ok(incidencia);
        }
    }
}