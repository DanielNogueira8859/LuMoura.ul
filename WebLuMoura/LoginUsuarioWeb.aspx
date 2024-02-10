<%@ Page Title="" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true" CodeBehind="LoginUsuarioWeb.aspx.cs" Inherits="WebLuMoura.LoginUsuarioWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            background-color: #F7F3E8; /* Cor de fundo para toda a página */
            margin: 0 auto;
        }
 
        .login {
            color: #302F2E; /* Cor do texto "Log in" */
            text-transform: uppercase;
            letter-spacing: 2px;
            display: block;
            font-weight: bold;
            font-size: x-large;
            font-family: 'Sofia Sans Semi Condensed', sans-serif;
        }
 
        .card {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 350px;
            width: 50%;
            flex-direction: column;
            gap: 35px;
            background: #F7F3E8; /* Cor de fundo para o card */
           box-shadow: 5px 5px 10px rgba(0, 0, 0, 0.3);
            border-radius: 8px;
            margin: auto;
            margin-top: 10vh;
            margin: 0 auto;
            margin-top:70px;

        }
 
        .inputBox {
            position: relative;
            width: 90%;
            margin-bottom: 20px;
        }
 
        .inputBox input {
            width:100%;
            padding: 15px;
            outline: none;
            border: none;
            color: black; /* Cor do texto nas caixas de entrada */
            font-size: 1em;
            background: white;
            border-left: 2px solid  #713600; /* Cor da borda da esquerda nas caixas de entrada */
            border-bottom: 2px solid  #713600;
            border-top: 2px solid  #713600;
            border-right: 2px solid  #713600;/* Cor da borda inferior nas caixas de entrada */
            transition: 0.1s;
            border: 8px;
            margin: 0;
        }
 
        .inputBox span {
            margin-top: 5px;
            position: absolute;
            left: 0;
            transform: translateY(-4px);
            margin-left: 10px;
            padding: 10px;
            pointer-events: none;
            font-size: 16px;
            color: black; /* Cor do texto nas etiquetas */
            text-transform: uppercase;
            transition: 0.5s;
            letter-spacing: 3px;
            border-radius: 8px;
        }
 
        .inputBox input:valid~span,
        .inputBox input:focus~span {
            transform: translateX(113px) translateY(-15px);
            font-size: 0.8em;
            padding: 5px 10px;
            background:black; /* Cor de fundo quando as caixas de entrada têm foco ou são válidas */
            letter-spacing: 0.2em;
            color: white; /* Cor do texto quando as caixas de entrada têm foco ou são válidas */
            border: 2px;
        }
 
        .inputBox input:valid,
        .inputBox input:focus {
            border: 2px solid white; /* Cor da borda quando as caixas de entrada têm foco ou são válidas */
            border-radius: 8px;
        }
 
        .enter {
            height: 45px;
            width: 90%;
            border-radius: 5px;
            border: 2px solid #713600; /* Cor da borda do botão */
            cursor: pointer;
            background-color: #713600;
            transition: 0.5s;
            text-transform: uppercase;
            font-size: 16px;
            letter-spacing: 2px;
            margin-bottom: 1em;
            color: white; /* Cor do texto do botão */
            font-family: 'Sofia Sans Semi Condensed', sans-serif;
        }
 
        .enter:hover {
            background-color: #713600; /* Cor de fundo do botão ao passar o mouse */
            color: #F7F3E8; /* Cor do texto do botão ao passar o mouse */
            font-family: 'Sofia Sans Semi Condensed', sans-serif;
        }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card">
            <a class="login">Entrar</a>
            <div class="inputBox">
                <asp:TextBox ID="TextLogin" runat="server" type="text" CssClass="form-control" required="required"></asp:TextBox>
                <span class="user">Login</span>
            </div>

            <div class="inputBox">
                <asp:TextBox ID="TextSenha" runat="server" type="password" CssClass="form-control" required="required"></asp:TextBox>
                <span>Password</span>
            </div>

            <asp:Button ID="Button1" runat="server" Text="Enter" CssClass="enter" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
