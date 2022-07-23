using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProyect
{
    public class IncidenciaEntidad
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Nodo { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public string Estado { get; set; }
        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }

        public IncidenciaEntidad()
        {
        }

        public IncidenciaEntidad(int id, int idUsuario, string nodo, DateTime fecha, string mensaje, string estado, decimal longitud, decimal latitud)
        {
            Id = id;
            IdUsuario = idUsuario;
            Nodo = nodo;
            Fecha = fecha;
            Mensaje = mensaje;
            Estado = estado;
            Longitud = longitud;
            Latitud = latitud;
        }
    }
}
