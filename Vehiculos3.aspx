<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos3.aspx.cs" Inherits="TestObligatorioP2.Vehiculos3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Catalogo de Vehiculos</h3>
        </div>

        <p>Seleccione el tipo del vehiculo</p>
        <div class="row">
            <div class="col-lg-5">
                <asp:RadioButtonList ID="rblTipoVehiculo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblTipoVehiculo_SelectedIndexChanged">
                    <asp:ListItem Value="Moto" Selected="True">Moto</asp:ListItem>
                    <asp:ListItem Value="Auto">Auto</asp:ListItem>
                    <asp:ListItem Value="Camion">Camion</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" Text="" placeholder="Matricula del vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Text="" placeholder="Marca del vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Text="" placeholder="Modelo del vehiculo"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtPrecioVenta" runat="server" CssClass="form-control" placeholder="Precio de Venta del Vehiculo"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtPrecioAlquiler" runat="server" CssClass="form-control" placeholder="Precio de Alquiler del Vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:Label Text="Vehiculo disponible?: " runat="server"></asp:Label>
                <asp:CheckBox ID="CheckBoxActivo" runat="server" CssClass="form-control" AutoPostBack="false" Width="40px"></asp:CheckBox>
            </div>
        </div>


        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtimagen1" TextMode="Url" runat="server" CssClass="form-control" placeholder="imagen1 del Vehiculo"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtimagen1" runat="server" ErrorMessage="debe ingresar una imagen" ValidationGroup="Guardar"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtimagen2" TextMode="Url" runat="server" CssClass="form-control" placeholder="imagen2 del Vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtimagen3" TextMode="Url" runat="server" CssClass="form-control" placeholder="imagen3 del Vehiculo"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtCilindrada" runat="server" TextMode="Number" CssClass="form-control" Text="" placeholder="Cilindradas del vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtCantPasajeros" Visible="false" TextMode="Number" runat="server" CssClass="form-control" Text="" placeholder="Cantidad de Pasajeros del vehiculo"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:TextBox ID="txtToneladasDeCarga" runat="server" TextMode="Number" Visible="false" CssClass="form-control" Text="" placeholder="Toneladas del vehiculo"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-5">
                <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
        </div>


        <div class="row">
            <div class="col-lg-8">
                <asp:GridView ID="gvVehiculos" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5"
                    OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                    OnRowDeleting="gvVehiculos_RowDeleting"
                    DataKeyNames="Matricula"
                    AutoGenerateColumns="false"
                    OnRowEditing="gvVehiculos_RowEditing"
                    OnRowUpdating="gvVehiculos_RowUpdating">

                    <Columns>
                        <asp:TemplateField HeaderText="Matricula">
                            <ItemTemplate>
                                <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:Label ID="txtMatriculaGrid" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Marca">
                            <ItemTemplate>
                                <asp:Label ID="lblMarca" runat="server" Text='<%# Bind("Marca") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtMarcaGrid" runat="server" Text='<%# Bind("Marca") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Modelo">
                            <ItemTemplate>
                                <asp:Label ID="lblModelo" runat="server" Text='<%# Bind("Modelo") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtModeloGrid" runat="server" Text='<%# Bind("Modelo") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CampoEspecial">
                            <ItemTemplate>
                                <asp:Label ID="lblCampoEspecial" runat="server" Text='<%# Bind("CampoEspecial") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Imagen1">
                            <ItemTemplate>
                                <asp:Image ID="lbl41" runat="server" ImageUrl='<%# Bind("Imagen1") %>' Width="200"></asp:Image>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtImagen1Grid" runat="server" Text='<%# Bind("Imagen1") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Imagen2">
                            <ItemTemplate>
                                <asp:Image ID="lbl42" runat="server" ImageUrl='<%# Bind("Imagen2") %>' Width="200"></asp:Image>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtImagen2Grid" runat="server" Text='<%# Bind("Imagen2") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Imagen3">
                            <ItemTemplate>
                                <asp:Image ID="lbl43" runat="server" ImageUrl='<%# Bind("Imagen3") %>' Width="200"></asp:Image>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtImagen3Grid" runat="server" Text='<%# Bind("Imagen3") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>

                        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                    </Columns>


                </asp:GridView>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:DataGrid ID="dgVehiculos" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5">
            </asp:DataGrid>
        </div>
    </div>
</asp:Content>
