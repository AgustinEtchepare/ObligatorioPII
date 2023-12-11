using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public string getCecula()
        {
            return Cedula;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getApellido()
        {
            return Apellido;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public void setCedula(string cedula)
        {
            Cedula = cedula;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }

        public void setDireccion(string direccion)
        {
            Direccion = direccion;
        }

        public string DatosMostrar { get { return Cedula + " - Nombre: " + Nombre + " " + Apellido; } }
    }
}