using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CIValidator validator = new CIValidator();

            if (validator.Validate(txtCedula.Text))
            {
                string Cedula = txtCedula.Text;

                Cliente cliente1 = new Cliente();
                cliente1.setCedula(txtCedula.Text);
                cliente1.setNombre(txtNombre.Text);
                cliente1.setApellido(txtApellido.Text);
                cliente1.setDireccion(txtDireccion.Text);

                BaseDeDatos.listaClientes.Add(cliente1);

                gvClientes.DataSource = BaseDeDatos.listaClientes;
                gvClientes.DataBind();

                Response.Write("<script>alert('Cliente ingresado correctamente')</script>");


            }
            else
            {
                Response.Write("<script>alert('Debe ingresar una cedula correcta')</script>");
            }
        }

        protected void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvClientes_RowCancelingEdit(object sender, EventArgs e)
        {
            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvClientes.EditIndex = e.NewEditIndex;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvClientes.Rows[e.RowIndex];
            string cedula = gvClientes.DataKeys[e.RowIndex].Values[0].ToString();

            string nombreE = (filaSeleccionada.FindControl("txtNombreGrid") as TextBox).Text;
            string apellidoE = (filaSeleccionada.FindControl("txtApellidoGrid") as TextBox).Text;
            string direccionE = (filaSeleccionada.FindControl("txtDireccionGrid") as TextBox).Text;

            foreach (var cliente in BaseDeDatos.listaClientes)
            {
                if (cliente.Cedula == cedula)
                {
                    cliente.Nombre = nombreE;
                    cliente.Apellido = apellidoE;
                    cliente.Direccion = direccionE;


                }
            }

            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();
        }
    }
}
