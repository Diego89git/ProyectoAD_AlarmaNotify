using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesProyect;
using DatosProyect;

namespace NegocioProyect
{
    public static class IncidenciaNegocio
    {
        public static IncidenciaEntidad GuardarIncidencia(IncidenciaEntidad incidenciaEntidad) 
        {
            if (incidenciaEntidad.Id == 0)
            {
                return IncidenciaDatos.Nuevo(incidenciaEntidad);
            }
            else
            {
                return IncidenciaDatos.Actualizar(incidenciaEntidad);
            }
        }
        
        public static List<IncidenciaEntidad> DevolverListadoIncidentes() 
        {
            return IncidenciaDatos.DevolverListadoIncidentes();
        }
        public static IncidenciaEntidad DevolverIncidentePorId(int Id) 
        {
            return IncidenciaDatos.DevolverIncidentePorId(Id);
        }
        public static bool EliminarIncidente(int Id) 
        {
            return IncidenciaDatos.EliminarIncidente(Id);
        }
    }
}
