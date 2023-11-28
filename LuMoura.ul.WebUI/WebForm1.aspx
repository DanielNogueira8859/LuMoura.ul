<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LuMoura.ul.WebUI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #loader {
            border: 8px solid #f3f3f3;
            border-top: 8px solid #3498db;
            border-radius: 50%;
            width: 50px;
            height: 50px;
            animation: spin 1s linear infinite;
            display: none; /* Inicialmente oculto */
            position: absolute;
            top: 50%;
            left: 50%;
            margin-top: -25px; /* Metade da altura */
            margin-left: -25px; /* Metade da largura */
            z-index: 1000; /* Certifica-se de que está acima de outros elementos */
            background-color: white;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        #mensagem {
            display: none; /* Inicialmente oculto */
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            padding: 20px;
            background-color: #4CAF50;
            color: white;
            font-size: 18px;
            z-index: 1001; /* Um nível acima do loader */
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="container-fluid p-5 bg-primary text-white text-center">
        <h1>Ficha de Cadastro</h1>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <!-- Adiciona o loader -->
            <div id="loader"></div>

            <!-- Adiciona a mensagem -->
            <div id="mensagem">CADASTRO SALVO</div>

            Nome:
            <asp:TextBox ID="TxtNome" runat="server" OnTextChanged="TxtNome_TextChanged" />
            &nbsp;Sobrenome:
            <asp:TextBox ID="TxtSobreNome" runat="server" />
            &nbsp;Endereço:
            <asp:TextBox ID="TxtBox1" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtBox1" ErrorMessage="Ops.. Enderço em branco!!!" ForeColor="White"></asp:RequiredFieldValidator>
            <br />

            <br />
            Senha:
            <asp:TextBox ID="TxtSenha" runat="server" />
            &nbsp;Confirmar:
            <asp:TextBox ID="TextConfirmar" runat="server" />
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtSenha" ControlToValidate="TextConfirmar" ErrorMessage="Dados Não Confere" Font-Bold="True" ForeColor="White"></asp:CompareValidator>

            <br />
            <br />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" />
            </div>

            <asp:Button ID="BtnCadastra" runat="server" class="btn btn-outline-primary" OnClientClick="showLoaderAndMessage()" OnClick="BtnCadastra_Click" Text="Cadastrar" />
        </ContentTemplate>
    </asp:UpdatePanel>

    <script>
        function showLoaderAndMessage() {
            // Exibe o loader
            document.getElementById('loader').style.display = 'block';

            // Aguarda 5 segundos antes de exibir a mensagem e redirecionar
            setTimeout(function () {
                // Oculta o loader
                document.getElementById('loader').style.display = 'none';

                // Exibe a mensagem
                document.getElementById('mensagem').style.display = 'block';

                // Aguarda mais 5 segundos antes de redirecionar
                setTimeout(function () {
                    // Oculta a mensagem
                    document.getElementById('mensagem').style.display = 'none';

                    // Redireciona para outra página
                    window.location.href = 'outra_pagina.html';
              
                }, 5000);
            }, 5000);
        }
    </script>
</asp:Content>
