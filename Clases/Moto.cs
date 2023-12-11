using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public static string Tipo = "Moto";
        


        public int getCilindrada()
        {
            return this.Cilindrada;
        }
        public void setCilindrada(int Cilindrada)
        {
            this.Cilindrada = Cilindrada;
        }
        public string DatosMostrar { get { return Tipo + " " + Marca + " " + Modelo + " - Matricula: " + Matricula; } }

       
    }
}