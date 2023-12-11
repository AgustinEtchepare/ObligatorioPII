using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool VerClientes { get; set; }
        public bool VerUsuarios { get; set; }
        public bool VerVentas { get; set; }
        public bool VerVehiculos { get; set; }
        public bool VerAlquileres { get; set; }

        public string getNombreUsuario()
        {
            return NombreUsuario;
        }
        public void setNombreUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        public string getContrasena()
        {
            return Contrasena;
        }
        public void setContrasena(string cont)
        {
            Contrasena = cont;
        }

        public bool getVerClientes()
        {
            return VerClientes;
        }
        public bool getVerUsuarios()
        {
            return VerUsuarios;
        }
        public bool getVerVehiculos()
        {
            return VerVehiculos;
        }
        public bool getVerVentas()
        {
            return VerVentas;
        }
        public bool getVerAlquileres()
        {
            return VerAlquileres;
        }


        public void setVerClientes(bool verClientes)
        {
            VerClientes = verClientes;
        }

        public void setVerUsuarios(bool verUsuarios)
        {
            VerUsuarios = verUsuarios;
        }

        public void setVerVentas(bool verVentas)
        {
            VerVentas = verVentas;
        }

        public void setVerAlquileres(bool verAlquileres)
        {
            VerAlquileres = verAlquileres;
        }

        public void setVerVehiculos(bool verVehiculos)
        {
            VerVehiculos = verVehiculos;
        }
    }
}