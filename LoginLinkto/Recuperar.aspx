<%@ Page Title="" Language="C#" MasterPageFile="~/Recuperar.Master" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="LoginLinkto.Recuperar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPagina" runat="server">
 
    <ContentTemplate>    
							<div class="form-group">
								 <asp:TextBox class="form-control" type="email" placeholder="email" ID="txtRecuperar" runat="server"></asp:TextBox>
							</div>
                            
								 
            
           
        <asp:Button ID="btnRecuperar" runat="server" class="btn btn-primary" Text="Recuperar Su contraseña" OnClick="btnRecuperar_Click" />
        <div></div>
        <div></div>
							<asp:Label ID="enviado" runat="server" Text=""></asp:Label>
                                    
                       

                            
                                

         </ContentTemplate>






</asp:Content>

 
