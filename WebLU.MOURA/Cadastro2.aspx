<%@ Page Title="" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true" CodeBehind="Cadastro2.aspx.cs" Inherits="WebLuMoura.Cadastro2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p></p>
</div>
<div>
    <center>
        <h1>CADASTRO</h1>
    </center>
</div>
<div>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p></p>
</div>
<div >
   
    
    
    <asp:Label  ID="Label1" runat="server" Text="Nome:" ></asp:Label>
    <asp:TextBox  ID="TextNome" runat="server" Width="159px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="CPF:"></asp:Label>
    <asp:TextBox ID="TextCPF" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label3" runat="server" Text="Telefone:"></asp:Label>
    <asp:TextBox ID="TextTelefone" runat="server" ></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
    <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label5" runat="server" Text="Login:"></asp:Label>
    <asp:TextBox ID="TextLogin" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="Senha:"></asp:Label>
    <asp:TextBox ID="TextSenha" runat="server" ></asp:TextBox>
    <p></p> 
    <asp:Button ID="Button1" runat="server" Text="CADASTRAR" OnClick="Button1_Click" />

     

</div>
<div>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p></p>
</div>

</asp:Content>
