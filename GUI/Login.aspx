<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUI2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <div class="form-group">
            <label>Usuario</label>
             <asp:TextBox runat="server" Text="" Id="txtUser" CssClass="form-control" />
         
        </div>
         <div class="form-group">
            <label>Password</label>
            <asp:TextBox   runat="server"   Text  ="" Id="txtPass" CssClass="form-control" />            
        </div>


        <asp:Button runat="server" CssClass="btn btn-primary btn-lg" Text="Ingresar" id="btnIngresar" OnClick="btnIngresar_Click"/>
        <asp:Button runat="server" CssClass="btn btn-warning btn-lg" Text="Volver" id="btnVolver" OnClick="btnVolver_Click"/>
      

    </div>

</asp:Content>
