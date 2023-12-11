using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Auto : Vehiculo
    {
        public int CantidadPasajeros { get; set; }
        public static string Tipo = "Auto";


        public int getCantidadPasajeros()
        {
            return this.CantidadPasajeros;
        }
        public void setCantidadPasajeros(int CantidadPasajeros)
        {
            this.CantidadPasajeros = CantidadPasajeros;
        }

        public string DatosMostrar { get { return Tipo + " " + Marca + " " + Modelo + " - Matricula: " + Matricula; } }

    }
}