using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntidadesProyect
{
    public class NodoEntidad
    {
        public int Id { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string RazonSocial { get; set; }
        public string Representante { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Password { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }

        public NodoEntidad()
        {
        }

        public NodoEntidad(int id, string tipoIdentificacion, string numeroIdentificacion, string razonSocial, string representante, string direccion, string telefono, string celular, string password, decimal latitud, decimal longitud)
        {
            Id = id;
            TipoIdentificacion = tipoIdentificacion;
            NumeroIdentificacion = numeroIdentificacion;
            RazonSocial = razonSocial;
            Representante = representante;
            Direccion = direccion;
            Telefono = telefono;
            Celular = celular;
            Password = password;
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}
