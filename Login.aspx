<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestObligatorioP2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Login</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtUsuario"  runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtContrasena" TextMode="Password" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Ingresar" OnClick="btnGuardar_Click" />
        </div>
    </div>
     <div class="row">
        <div class="col-lg-5">
            <asp:Label ID="lblError" runat="server" Visible="false" CssClass="form-control" ForeColor ="Red">Usuario y/o contraseña incorrectos</asp:Label>
        </div>
    </div>
</asp:Content>
