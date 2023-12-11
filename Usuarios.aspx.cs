using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
                Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
                Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
                Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
                Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

                gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
                gvUsuarios.DataBind();
            }
        }


        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.setNombreUsuario(txtNombre.Text);
            usuario.setContrasena(txtContrasena.Text);
            usuario.setVerAlquileres(CheckBoxAlquileres.Checked);
            usuario.setVerUsuarios(CheckBoxUsuarios.Checked);
            usuario.setVerClientes(CheckBoxClientes.Checked);
            usuario.setVerVentas(CheckBoxVentas.Checked);
            usuario.setVerVehiculos(CheckBoxVehiculos.Checked);



            // Agregar el usuario a la lista
            BaseDeDatos.listaUsuarios.Add(usuario);
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();

         
            Response.Write("Usuario agregado correctamente");

        }





        protected void gvUsuarios_RowCancelingEdit(object sender, EventArgs e)
        {
            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string nombreUsuario = this.gvUsuarios.DataKeys[e.RowIndex].Values[0].ToString();

            foreach (var usuario in BaseDeDatos.listaUsuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    BaseDeDatos.listaUsuarios.Remove(usuario);
                    break;
                }
            }

            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvUsuarios.EditIndex = e.NewEditIndex;
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvUsuarios.Rows[e.RowIndex];
            string nombreUsuario = this.gvUsuarios.DataKeys[e.RowIndex].Values[0].ToString();

            bool verVentasE = (filaSeleccionada.FindControl("chkVerVentasGrid") as CheckBox).Checked;
            bool verAlquileresE = (filaSeleccionada.FindControl("chkVerAlquileresGrid") as CheckBox).Checked;
            bool verUsuariosE = (filaSeleccionada.FindControl("chkVerUsuariosGrid") as CheckBox).Checked;
            bool verVehiculosE = (filaSeleccionada.FindControl("chkVerVehiculosGrid") as CheckBox).Checked;
            bool verClientesE = (filaSeleccionada.FindControl("chkVerClientesGrid") as CheckBox).Checked;

            foreach (var user in BaseDeDatos.listaUsuarios)
            {
                if (user.NombreUsuario == nombreUsuario)
                {
                    user.VerClientes = verClientesE;
                    user.VerUsuarios = verUsuariosE;
                    user.VerAlquileres = verAlquileresE;
                    user.VerVentas = verVentasE;
                    user.VerVehiculos = verVehiculosE;

                }
            }

            this.gvUsuarios.EditIndex = -1;
            this.gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            this.gvUsuarios.DataBind();



        }
    }
}