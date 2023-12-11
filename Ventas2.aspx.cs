using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Ventas2 : System.Web.UI.Page
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
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataBind();

                gvVentas.DataSource = BaseDeDatos.listaVentas;
                gvVentas.DataBind();

                cboCleintes.DataSource = BaseDeDatos.listaClientes;
                cboCleintes.DataTextField = "DatosMostrar";
                cboCleintes.DataValueField = "Cedula";
                cboCleintes.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.setCedula(cboCleintes.SelectedItem.Value);
            venta.setMatricula(cboVehiculos.SelectedItem.Value);
            venta.setFechaVenta(DateTime.Now);
            venta.setPrecio(Convert.ToInt32(lblPrecio.Text));

            venta.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);


            BaseDeDatos.listaVentas.Add(venta);

            Response.Write("<script>alert('Venta ingresada correctamente')</script>");

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


            //string Cedula = cboCleintes.SelectedItem.Value;

            //string Matricula = cboVehiculos.SelectedValue;
            gvVentas.DataSource = BaseDeDatos.listaVentas;
            gvVentas.DataBind();

        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.Matricula == Matricula)
                {
                    lblPrecio.Text = vehiculo.PrecioVenta.ToString();
                    lblPrecio.Visible = true;
                    lblPrecioSimbolo.Visible = true;
                }
            }
        }
        protected void gvVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}