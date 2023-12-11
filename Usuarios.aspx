<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TestObligatorioP2.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Usuarios</h3>
        </div>
        <div class="row">
            <asp:GridView ID="gvUsuarios" CssClass="table" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvUsuarios_RowCancelingEdit"
                OnRowDeleting="gvUsuarios_RowDeleting"
                OnRowEditing="gvUsuarios_RowEditing"
                OnRowUpdating="gvUsuarios_RowUpdating"
                DataKeyNames="NombreUsuario">
                <Columns>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblNombreGrid" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ver Clientes">
                        <ItemTemplate>
                            <asp:CheckBox ID="lblVerClientes" runat="server" Checked='<%# Bind("VerClientes") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerClientesGrid" runat="server" Checked='<%# Bind("VerClientes") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ver Vehiculos">
                        <ItemTemplate>
                            <asp:CheckBox ID="lblVerVehiculos" runat="server" Checked='<%# Bind("VerVehiculos") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerVehiculosGrid" runat="server" Checked='<%# Bind("VerVehiculos") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ver Ventas">
                        <ItemTemplate>
                            <asp:CheckBox ID="lblVerVentas" runat="server" Checked='<%# Bind("VerVentas") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerVentasGrid" runat="server" Checked='<%# Bind("VerVentas") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ver Alquileres">
                        <ItemTemplate>
                            <asp:CheckBox ID="lblVerAlquileres" runat="server" Checked='<%# Bind("VerAlquileres") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerAlquileresGrid" runat="server" Checked='<%# Bind("VerAlquileres") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ver Usuarios">
                        <ItemTemplate>
                            <asp:CheckBox ID="lblVerUsuarios" runat="server" Checked='<%# Bind("VerUsuarios") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerUsuariosGrid" runat="server" Checked='<%# Bind("VerUsuarios") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>

            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Contraseña:
        
            <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" OnTextChanged="txtContrasena_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Ver Clientes: " runat="server" Width="100px"></asp:Label>
            <asp:CheckBox ID="CheckBoxClientes" runat="server" CssClass="form-control" Width="40px"></asp:CheckBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Ver Vehiculos: " runat="server" Width="100px"></asp:Label>
            <asp:CheckBox ID="CheckBoxVehiculos" runat="server" CssClass="form-control" Width="40px"></asp:CheckBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Ver Ventas: " runat="server" Width="100px"></asp:Label>
            <asp:CheckBox ID="CheckBoxVentas" runat="server" CssClass="form-control" Width="40px"></asp:CheckBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Ver Alquileres: " runat="server" Width="100px"></asp:Label>
            <asp:CheckBox ID="CheckBoxAlquileres" runat="server" CssClass="form-control" Width="40px"></asp:CheckBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Ver Usuarios: " runat="server" Width="100px"></asp:Label>
            <asp:CheckBox ID="CheckBoxUsuarios" runat="server" CssClass="form-control" Width="40px"></asp:CheckBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Agregar Usuario" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
