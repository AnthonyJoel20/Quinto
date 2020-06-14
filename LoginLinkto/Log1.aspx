<%@ Page Title="" Language="C#" MasterPageFile="~/Login1.Master" AutoEventWireup="true" CodeBehind="Log1.aspx.cs" Inherits="LoginLinkto.Log1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 286px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPagina" runat="server">
 
    <ContentTemplate>
        <div class="form-group">
								<asp:TextBox class="form-control" type="text" placeholder="Usuario" ID="txtUsuario" runat="server" ></asp:TextBox>
							</div>
							<div class="form-group">
								 <asp:TextBox class="form-control" type="password" placeholder="Password" ID="txtClave" runat="server"></asp:TextBox>
							</div>
							<div class="checkbox">
								
                                <asp:Button ID="btnIngresar" runat="server" class="btn btn-primary" Text="Ingresar" OnClick="Button1_Click" />
                                <div></div>
                               <div></div>
                            <asp:LinkButton ID="btnRecuperar" runat="server"  Text="Recuperar Contraseña" OnClick="Button2_Click" />
                                <div></div>
                                <div></div>
                                <div></div>
                               <td>Intentos</td>
                               <asp:Label ID="lbl_contador" runat="server" Text=""></asp:Label>
                                <td></td>
                                <td></td>
                                <td></td>
                                <div>
                               <asp:Label ID="alerta" runat="server" Text=""></asp:Label>
                                    <div>
                                        

							</div>
                       

                            
                                

         </ContentTemplate>






</asp:Content>

 
