<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquileres.aspx.cs" Inherits="TestObligatorioP2.Alquileres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Alquiler</h3>
        </div>
        <div class="row">
            <asp:GridView ID="gvAlquileres" CssClass="table" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5" OnSelectedIndexChanged="gvAlquileres_SelectedIndexChanged"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvAlquileres_RowCancelingEdit"
                OnRowDeleting="gvAlquileres_RowDeleting"
                OnRowEditing="gvAlquileres_RowEditing"
                OnRowUpdating="gvAlquileres_RowUpdating"
                DataKeyNames="Matricula">
                <Columns>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cedula">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="txtMarcaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="FechaAlquiler">
                        <ItemTemplate>
                            <asp:Label ID="lbl4" runat="server" Text='<%# Bind("FechaAlquiler") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias">
                        <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# Bind("Dias") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDiasGrid" runat="server" Text='<%# Bind("Dias") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Fecha Devolucion">
                        <ItemTemplate>
                            <asp:Label ID="lbl85" runat="server" Text='<%# Bind("FechaDevolucion") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaDevolucion" runat="server" Text='<%# Bind("FechaDevolucion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Devuelto">
                        <ItemTemplate>
                            <asp:CheckBox ID="lbl9" runat="server" Checked='<%# Bind("AutoDevuelto") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkDevueltoGrid" runat="server" Checked='<%# Bind("AutoDevuelto") %>'></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:Label ID="lbl10" runat="server" Text='<%# Bind("Estado") %>' ForeColor="Red" Font-Bold="true"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>
                
            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Clientes: " runat="server"></asp:Label>
            <asp:DropDownList ID="cboClientes" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Vehiculos: " runat="server"></asp:Label>
            <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Fecha:
            <asp:TextBox ID="txtFechaAl" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            Dias:
            <asp:TextBox ID="txtDias" runat="server" TextMode="Number" CssClass="form-control" OnTextChanged="txtDias_TextChanged" AutoPostBack="true"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Alquilar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label ID="lblPrecioSimbolo" runat="server" Visible="false" CssClass="form-control" ForeColor="Red">$ </asp:Label>
            <asp:Label ID="lblPrecio" runat="server" Visible="false" CssClass="form-control" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
