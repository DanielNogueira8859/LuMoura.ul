<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LuMoura.Web.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<!-- Link para o Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
   

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<header class="bg-dark text-white text-center py-3">
        <h1>Meu Cabeçalho</h1>
    </header>

    

    <!-- Conteúdo da Página -->
    <div class="container mt-3">
        <h2>Conteúdo da Páginassa</h2>
        <p>Seu conteúdo vai aqui.</p>

        <asp:Button ID ="btn" Text="enviar" runat="server" OnClick="BtnEnviar_Click" CausesValidation="False" />
        <asp:TextBox runat="server" ID="TexNome" />
    	
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
       
 
    	
        
		
    
    



    <!-- Rodapé Bootstrap -->
    <footer class="bg-dark text-white text-center py-3 fixed-bottom">
        <p>&copy; 2023 Meu Rodapé</p>
    </footer>

    <!-- Inclua o JS do Bootstrap (opcional, mas necessário para alguns recursos) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>

</div>
</asp:Content>