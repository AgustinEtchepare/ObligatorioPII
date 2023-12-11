<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TestObligatorioP2.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Clientes</h3>
        </div>
        <div class="row">
            <asp:GridView ID="gvClientes" CssClass="table" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5" OnSelectedIndexChanged="gvClientes_SelectedIndexChanged"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvClientes_RowCancelingEdit"
                OnRowDeleting="gvClientes_RowDeleting"
                OnRowEditing="gvClientes_RowEditing"
                OnRowUpdating="gvClientes_RowUpdating"
                DataKeyNames="Cedula">
                <Columns>
                    <asp:TemplateField HeaderText="Cedula">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblCedulaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreGrid" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellidoGrid" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Direccion">
                        <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDireccionGrid" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>

            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Cédula:
            <asp:TextBox ID="txtCedula" PlaceHolder="Ingrese cédula sin puntos ni guiones" runat="server" CssClass="form-control" OnTextChanged="txtCedula_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Apellido:
         <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Direccion:
         <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Agregar Cliente" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
