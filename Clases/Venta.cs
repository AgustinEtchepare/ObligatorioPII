using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Venta
    {
        public string Cedula { get; set; }

        public string Matricula { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime FechaVenta { get; set; }

        public int Precio { get; set; }

        public string getCedula()
        {
            return Cedula;
        }

        public string getMatricula()
        {
            return Matricula;
        }

        public string getNombreUsuario()
        {
            return NombreUsuario;
        }
        public DateTime getFechaAlquiler()
        {
            return FechaVenta;
        }
        public int getPrecio()
        {
            return Precio;
        }

        public void setCedula(string cedula)
        {
            Cedula = cedula;
        }
        public void setMatricula(string matricula)
        {
            Matricula = matricula;
        }
        public void setNombreUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }

        public void setPrecio(int precio)
        {
            Precio = precio;
        }

        public void setFechaVenta(DateTime ferchaVenta)
        {
            FechaVenta = ferchaVenta;
        }
    }
}