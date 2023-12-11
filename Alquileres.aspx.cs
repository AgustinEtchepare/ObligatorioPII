using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Alquileres : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

            if (!Page.IsPostBack)
            {
                cboVehiculos.DataSource = BaseDeDatos.listadoVehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                gvAlquileres.DataBind();

                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "Cedula";
                cboClientes.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.setCedula(cboClientes.SelectedItem.Value);
            alquiler.setMatricula(cboVehiculos.SelectedItem.Value);
            alquiler.setFechaAlquiler(DateTime.Now);
            alquiler.setPrecio(Convert.ToInt32(lblPrecio.Text));
            alquiler.setDias(Convert.ToInt32(txtDias.Text));
            alquiler.setFechaDevolucion(alquiler.getFechaAlquiler().AddDays(alquiler.getDias()));

            alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);


            BaseDeDatos.listaAlquileres.Add(alquiler);

            foreach (var Vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (Vehiculo.Matricula == cboVehiculos.SelectedItem.Value)
                {
                    Vehiculo.Activo = false;
                    break;
                }
            }
            cboVehiculos.DataSource = BaseDeDatos.listadoVehiculosActivos();
            cboVehiculos.DataTextField = "Matricula";
            cboVehiculos.DataBind();

            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();

            Response.Write("<script>alert('Alquiler ingresado correctamente')</script>");
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDias.Text))
            {
                string Matricula = cboVehiculos.SelectedItem.Value;

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        lblPrecio.Text = (vehiculo.PrecioAlquilerDia * Convert.ToInt32(txtDias.Text)).ToString();
                        lblPrecio.Visible = true;
                        lblPrecioSimbolo.Visible = true;
                    }
                }
            }
        }

        protected void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDias.Text))
            {
                string Matricula = cboVehiculos.SelectedItem.Value;

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.Matricula == Matricula)
                    {
                        lblPrecio.Text = (vehiculo.PrecioAlquilerDia * Convert.ToInt32(txtDias.Text)).ToString();
                        lblPrecio.Visible = true;
                        lblPrecioSimbolo.Visible = true;
                    }
                }
            }
        }

        protected void gvAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvAlquileres_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            string matricula = this.gvAlquileres.DataKeys[e.RowIndex].Values[0].ToString();

            foreach (var alquiler in BaseDeDatos.listaAlquileres)
            {
                if (alquiler.Matricula == matricula)
                {
                    BaseDeDatos.listaAlquileres.Remove(alquiler);
                    break;
                }
            }

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();

        }

        protected void gvAlquileres_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = e.NewEditIndex;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvAlquileres.Rows[e.RowIndex];
            string matricula = this.gvAlquileres.DataKeys[e.RowIndex].Values[0].ToString();

            bool devuelto = (filaSeleccionada.FindControl("chkDevueltoGrid") as CheckBox).Checked;

            foreach (var alquiler in BaseDeDatos.listaAlquileres)
            {
                if (alquiler.Matricula == matricula)
                {
                    alquiler.AutoDevuelto = devuelto;
                }
            }

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();


        }
    }
}
