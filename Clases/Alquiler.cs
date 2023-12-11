using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Alquiler
    {
        public string Cedula { get; set; }

        public string Matricula { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime FechaAlquiler { get; set; }

        public int Dias { get; set; }

        public int Precio { get; set; }

        public bool AutoDevuelto { get; set; }

        public DateTime fechaDevolucion { get; set; }


        public string Estado
        {
            get
            {
                if (!AutoDevuelto && DateTime.Now > FechaAlquiler.AddDays(Dias))
                {
                    return "Atrasado";
                }
                else if (!AutoDevuelto)
                {
                    return "Al dia";
                }
                else
                {
                    return "Vehiculo devuelto";
                }
            }
        }

        public DateTime getFechaDevolucion()
        {
            return fechaDevolucion;
        }

        public void setFechaDevolucion(DateTime fechaDevolucion)
        {
            this.fechaDevolucion = fechaDevolucion;
        }



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
            return FechaAlquiler;
        }
        public int getDias()
        {
            return Dias;
        }

        internal void setCedula(object value)
        {
            throw new NotImplementedException();
        }

        public int getPrecio()
        {
            return Precio;
        }

        public bool getAutoDevuelto()
        {
            return AutoDevuelto;
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
        public void setDias(int dias)
        {
            Dias = dias;
        }
        public void setFechaAlquiler(DateTime ferchaAlquiler)
        {
            FechaAlquiler = ferchaAlquiler;
        }
        public void setAutoDevuelto(bool autoDevuelto)
        {
            AutoDevuelto = autoDevuelto;
        }
    }
}