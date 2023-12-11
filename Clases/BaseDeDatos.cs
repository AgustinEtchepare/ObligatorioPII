using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public abstract class BaseDeDatos
    {
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Venta> listaVentas = new List<Venta>();
        public static List<Alquiler> listaAlquileres = new List<Alquiler>();

        public static Usuario usuarioLogeado;


        public static void CargarDatosIniciales()
        {
            if (listaUsuarios.Count == 0)
            {
                Usuario usuario = new Usuario();
                usuario.setNombreUsuario("Admin");
                usuario.setContrasena("Admin");
                usuario.setVerAlquileres(true);
                usuario.setVerVentas(true);
                usuario.setVerClientes(true);
                usuario.setVerUsuarios(true);
                usuario.setVerVehiculos(true);

                listaUsuarios.Add(usuario);


                Cliente cliente = new Cliente { Apellido = "Perez", Cedula = "4586658-0", Direccion = "dr Edye 3456", Nombre = "Juan" };
                Cliente cliente2 = new Cliente { Apellido = "Lopez", Cedula = "4589998-9", Direccion = "dr Edye 5585", Nombre = "Javier" };
                Cliente cliente3 = new Cliente { Apellido = "Gomez", Cedula = "3785468-2", Direccion = "Aigua 3588", Nombre = "Luis" };
                listaClientes.Add(cliente);
                listaClientes.Add(cliente2);
                listaClientes.Add(cliente3);


                Moto Moto1 = new Moto { Marca = "Ferrari", Matricula = "MA458855", Modelo = "F40", PrecioVenta = 1000000, PrecioAlquilerDia = 100, Activo = true, Cilindrada = 1000 };
                Camion Camion1 = new Camion { Marca = "Chery", Matricula = "TG945884", Modelo = "TIGO", PrecioVenta = 95600, PrecioAlquilerDia = 180, Activo = true, ToneladasDeCarga = 20 };
                Auto Auto1 = new Auto { Marca = "Fiat", Matricula = "FR46665", Modelo = "UNO", PrecioVenta = 857588, PrecioAlquilerDia = 300, Activo = true, CantidadPasajeros = 4 };
                listaVehiculos.Add(Moto1);
                listaVehiculos.Add(Auto1);
                listaVehiculos.Add(Camion1);

                Alquiler alquiler1 = new Alquiler { Cedula = "54911491", Matricula = "BEA 0090", AutoDevuelto = false, NombreUsuario = "AgustinEtchepare", Dias = 4, FechaAlquiler = DateTime.Now, Precio = 300 * 4, fechaDevolucion = DateTime.Now.AddDays(4) };
                listaAlquileres.Add(alquiler1);
            }
        }

        public static void GuardarUsuarioLogeado(Usuario usuario)
        {
            usuarioLogeado = usuario;
        }

        public static List<Vehiculo> listadoVehiculosActivos()
        {
            List<Vehiculo> vehiculosActivos = new List<Vehiculo>();
            foreach (var vehiculo in listaVehiculos)
            {
                if (vehiculo.Activo)
                {
                    vehiculosActivos.Add(vehiculo);
                }
            }
            return vehiculosActivos;
        }
        //public static List<Alquiler> mostrarAlquileresRealizados()
        //{
          //  foreach (var alquiler in listaAlquileres)
            //{

            //}
        //}


    }
}