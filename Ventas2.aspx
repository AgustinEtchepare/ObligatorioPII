<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas2.aspx.cs" Inherits="TestObligatorioP2.Ventas2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
    <asp:GridView ID="gvVentas" CssClass="table" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5" OnSelectedIndexChanged="gvVentas_SelectedIndexChanged"
        AutoGenerateColumns="false"
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
                    <asp:Label ID="txtCedulaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="FechaVenta">
                <ItemTemplate>
                    <asp:Label ID="lbl4" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Precio">
                <ItemTemplate>
                    <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

        </Columns>
        
    </asp:GridView>
</div>

    <div class="row">
        <div class="col-lg-12">
            <h3>Venta</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Clientes: " runat="server" ></asp:Label>
            <asp:DropDownList ID="cboCleintes" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Vehiculos: " runat="server" ></asp:Label>
           <asp:DropDownList ID="cboVehiculos" runat="server" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Vender" OnClick="btnGuardar_Click" />
        </div>
    </div>
     <div class="row">
        <div class="col-lg-5">
            <asp:Label ID="lblPrecioSimbolo" runat="server" Visible="false" CssClass="form-control" ForeColor ="Red">$ </asp:Label>
            <asp:Label ID="lblPrecio" runat="server" Visible="false" CssClass="form-control" ForeColor ="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
