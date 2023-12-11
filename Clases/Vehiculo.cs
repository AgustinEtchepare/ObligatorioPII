using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public abstract class Vehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int PrecioVenta { get; set; }

        public int PrecioAlquilerDia { get; set; }
        public bool Activo { get; set; }



        public string getMatricula()
        {
            return Matricula;
        }
        public string getMarca()
        {
            return Marca;
        }
        public string getModelo()
        {
            return Modelo;
        }
        public int getPrecioVenta()
        { return PrecioVenta; }
        
        public int getPrecioAlquilerDia()
        {
            return PrecioAlquilerDia;
        }
        public bool getActivo()
        {
            return Activo;
        }
        public void setMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public void setModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public void setPrecioVenta(int PrecioVenta)
        {
            this.PrecioVenta = PrecioVenta;
        }
        public void setPrecioAlquilerDia(int PrecioAlquilerDia)
        {
            this.PrecioAlquilerDia = PrecioAlquilerDia;
        }
        public void setActivo(bool Activo)
        {
            this.Activo = Activo;
        }
        public string CampoEspecial { get; set; }

        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string Imagen3 { get; set; }

        public string getCampoEspecial()
        {
            return this.CampoEspecial;
        }
        public void setCampoEspecial(string CampoEspecial)
        {
            this.CampoEspecial = CampoEspecial;
        }
        //CampoEspecial creado, pero falta logica para que se muestre en GridVehiculos

    }
}