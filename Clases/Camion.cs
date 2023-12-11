using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Camion : Vehiculo
    {
        public int ToneladasDeCarga { get; set; }
        public static string Tipo = "Camion";
       

        public int getToneladaDeCarga()
        {
            return this.ToneladasDeCarga;
        }
        public void setToneladaDeCarga(int ToneladaDeCarga)
        {
            this.ToneladasDeCarga = ToneladasDeCarga;
        }

        public string DatosMostrar { get { return Tipo + " " + Marca +" "+ Modelo + " - Matricula: " + Matricula; } }
      
    }
}