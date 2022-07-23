using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace APIProyect.Models
{
    public class NodoModel
    {
        [Key]
        public int Id { get; set; }
        public String TipoIdentificacion { get; set; }
        public String NumeroIdentificacion { get; set; }
        public String RazonSocial { get; set; }
        public String Representante { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Password { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
    }
}