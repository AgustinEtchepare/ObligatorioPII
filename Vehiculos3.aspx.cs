using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Vehiculos3 : System.Web.UI.Page
    {  
        //Falta logica para que campo especial se muestre en el grid
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();
        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.Matricula == matricula)
                {
                    BaseDeDatos.listaVehiculos.Remove(vehiculo);
                    break;
                }
            }

            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvVehiculos.Rows[e.RowIndex];
            string matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

            string marca = (filaSeleccionada.FindControl("txtMarcaGrid") as TextBox).Text;
            string modelo = (filaSeleccionada.FindControl("txtModeloGrid") as TextBox).Text;

            string imagen1 = (filaSeleccionada.FindControl("txtImagen1Grid") as TextBox).Text;
            string imagen2 = (filaSeleccionada.FindControl("txtImagen2Grid") as TextBox).Text;
            string imagen3 = (filaSeleccionada.FindControl("txtImagen3Grid") as TextBox).Text;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.Matricula == matricula)
                {
                    vehiculo.Marca = marca;
                    vehiculo.Modelo = modelo;
                    vehiculo.Imagen1 = imagen1;
                    vehiculo.Imagen2 = imagen2;
                    vehiculo.Imagen3 = imagen3;
                }
            }

            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = e.NewEditIndex;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtimagen1.Text) || string.IsNullOrEmpty(txtimagen2.Text) || string.IsNullOrEmpty(txtimagen3.Text))
            {
                Response.Write("<script>alert('debe agregar 3 imagenes obligatoriamente')</script>");
            }
            else
            {

                if (rblTipoVehiculo.SelectedItem.Value == "Moto")
                {
                    Moto vehiculo = new Moto();
                    vehiculo.Matricula = txtMatricula.Text;
                    vehiculo.Marca = txtMarca.Text;
                    vehiculo.Modelo = txtModelo.Text;
                    vehiculo.Imagen1 = txtimagen1.Text;
                    vehiculo.Imagen2 = txtimagen2.Text;
                    vehiculo.Imagen3 = txtimagen3.Text;
                    vehiculo.Cilindrada = Convert.ToInt32(txtCilindrada.Text);
                    BaseDeDatos.listaVehiculos.Add(vehiculo);
                }
                if (rblTipoVehiculo.SelectedItem.Value == "Auto")
                {
                    Auto vehiculo = new Auto();
                    vehiculo.Matricula = txtMatricula.Text;
                    vehiculo.Marca = txtMarca.Text;
                    vehiculo.Modelo = txtModelo.Text;
                    vehiculo.Imagen1 = txtimagen1.Text;
                    vehiculo.Imagen2 = txtimagen2.Text;
                    vehiculo.Imagen3 = txtimagen3.Text;
                    vehiculo.CantidadPasajeros = Convert.ToInt32(txtCantPasajeros.Text);
                    BaseDeDatos.listaVehiculos.Add(vehiculo);
                }
                if (rblTipoVehiculo.SelectedItem.Value == "Camion")
                {
                    Camion vehiculo = new Camion();
                    vehiculo.Matricula = txtMatricula.Text;
                    vehiculo.Marca = txtMarca.Text;
                    vehiculo.Modelo = txtModelo.Text;
                    vehiculo.Imagen1 = txtimagen1.Text;
                    vehiculo.Imagen2 = txtimagen2.Text;
                    vehiculo.Imagen3 = txtimagen3.Text;
                    vehiculo.ToneladasDeCarga = Convert.ToInt32(txtToneladasDeCarga.Text);
                    BaseDeDatos.listaVehiculos.Add(vehiculo);
                }





                this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
                this.gvVehiculos.DataBind();
            }


        }

        protected void rblTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblTipoVehiculo.SelectedItem.Value == "Moto")
            {
                txtCilindrada.Visible = true;
                txtCantPasajeros.Visible = false;
                txtToneladasDeCarga.Visible = false;
            }
            if (rblTipoVehiculo.SelectedItem.Value == "Auto")
            {
                txtCilindrada.Visible = false;
                txtCantPasajeros.Visible = true;
                txtToneladasDeCarga.Visible = false;
            }
            if (rblTipoVehiculo.SelectedItem.Value == "Camion")
            {
                txtCilindrada.Visible = false;
                txtCantPasajeros.Visible = false;
                txtToneladasDeCarga.Visible = true;
            }
        }
    }
}
