using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesProyect;
using DatosProyect;

namespace NegocioProyect
{
    public static class NodoNegocio
    {
        public static NodoEntidad GuardarNodo(NodoEntidad nodoEntidad)
        {
            if (nodoEntidad.Id==0)
            {
                return NodoDatos.Nuevo(nodoEntidad);
            }
            else
            {
                return NodoDatos.Actualizar(nodoEntidad);
            }
        }
        public static List<NodoEntidad> DevolverListadoNodos()
        {
            return NodoDatos.DevolverListadoNodos();
        }
        public static NodoEntidad DevolverNodoPorId(int Id)
        {
            return NodoDatos.DevolverNodoPorId(Id);
        }
        public static NodoEntidad DevolverNodoPorLoggin(string user, string pass)
        {
            return NodoDatos.DevolverNodoPorLoggin(user, pass);
        }
        public static NodoEntidad DevolverNodoPorUsuario(string user)
        {
            return NodoDatos.DevolverNodoPorUsuario(user);
        }
        public static bool EliminarNodo(int Id)
        {
            return NodoDatos.EliminarNodo(Id);
        }

    }
}
