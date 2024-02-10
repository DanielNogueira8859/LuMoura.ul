<%@ Page Title="" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true" CodeBehind="Cadastro2.aspx.cs" Inherits="WebLuMoura.Cadastro2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style>
		.form {
	        display: flex;
	        flex-direction: column;
	        gap: 10px;
	        max-width: 350px;
	        background-color: #fff;
	        padding: 20px;
	        border-radius: 20px;
	        justify-content: center;
	        border: solid gray;
	        margin-top: 150px;
		    box-shadow: 5px 5px 10px rgba(0, 0, 0, 0.3);
			padding:20px;
			margin:0 auto;

 
	    }
 
 
	    .meio {
	        margin:0 auto;
	    }


		.input {
			align-content: center;
			margin: 10px;
			float: right;
			border-radius: 5.5px;
		}


		.title {
			font-size: 28px;
			color: royalblue;
			font-weight: 600;
			letter-spacing: -1px;
			position: relative;
			display: flex;
			align-items: center;
			padding-left: 30px;
		}


			.title::before, .title::after {
				position: absolute;
				content: "";
				height: 16px;
				width: 16px;
				border-radius: 50%;
				left: 0px;
				background-color: royalblue;
			}


			.title::before {
				width: 18px;
				height: 18px;
				background-color: royalblue;
			}


			.title::after {
				width: 18px;
				height: 18px;
				animation: pulse 1s linear infinite;
			}


		.message, .signin {
			color: rgba(88, 87, 87, 0.822);
			font-size: 14px;
		}


		.signin {
			text-align: center;
		}


			.signin a {
				color: royalblue;
			}


				.signin a:hover {
					text-decoration: underline royalblue;
				}


		/////////


		.form label {
			position: relative;
			width: 100%; /* Adicionado para ocupar 100% da largura */
		}


		.form label .input {
			width: calc(100% - 20px); /* Ajuste para levar em conta o padding da label */
			padding: 10px;
			outline: 0;
			border: 1px solid rgba(105, 105, 105, 0.397);
			border-radius: 10px;
			box-sizing: border-box; /* Garante que a largura inclui o padding e a borda */
		}


			.form label .input + span {
				position: absolute;
				left: 10px;
				top: 15px;
				color: grey;
				font-size: 0.9em;
				cursor: text;
				transition: 0.3s ease;
			}


			.form label .input:placeholder-shown + span {
				top: 15px;
				font-size: 0.9em;
			}


			.form label .input:focus + span, .form label .input:valid + span {
				top: 30px;
				font-size: 0.7em;
				font-weight: 600;
			}


			.form label .input:valid + span {
				color: green;
			}



		.submit {
			border: none;
			outline: none;
			background-color: royalblue;
			padding: 10px;
			border-radius: 10px;
			color: #fff;
			font-size: 16px;
		}



			.submit:hover {
				background-color: rgb(56, 90, 194);
			}


		@keyframes pulse {
			from {
				transform: scale(0.9);
				opacity: 1;
			}


			to {
				transform: scale(1.8);
				opacity: 0;
			}
		}
	</style>
	<script>
		// JavaScript para formatar o telefone e o CPF no lado do cliente
		function formatPhoneNumber(input) {
			var phoneNumber = input.value.replace(/\D/g, '');
			var formattedPhoneNumber = phoneNumber.replace(/(\d{2})(\d{5})(\d{4})/, '($1) $2-$3');
			input.value = formattedPhoneNumber;
		}

		function formatCPF(input) {
			var cpf = input.value.replace(/\D/g, '');
			var formattedCPF = cpf.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
			input.value = formattedCPF;
		}
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<div class="central">
		<div class="meio">
			<div class="form">
				<asp:Label runat="server" CssClass="title">Cadastro</asp:Label>


				<asp:Label runat="server" CssClass="message">Preencha os campos abaixo para se cadastrar.</asp:Label>


				<asp:Label runat="server">
					<span>Nome</span>
					<asp:TextBox runat="server" ID="TextNome" placeholder="" CssClass="input" required></asp:TextBox>
				</asp:Label>


				<asp:Label runat="server">
					<span>CPF</span>
					<asp:TextBox runat="server" ID="TextCPF" placeholder="" CssClass="input" oninput="formatCPF(this)" required></asp:TextBox>
				</asp:Label>


				<asp:Label runat="server">
					<span>Telefone</span>
					<asp:TextBox runat="server" ID="TextTelefone" placeholder="" CssClass="input" oninput="formatPhoneNumber(this)" required></asp:TextBox>
				</asp:Label>


				<asp:Label runat="server">
					<span>Email</span>
					<asp:TextBox runat="server" ID="TextEmail" placeholder="" CssClass="input" required></asp:TextBox>
				</asp:Label>


				<asp:Label runat="server">
					<span>Login</span>
					<asp:TextBox runat="server" ID="TextLogin" placeholder="" CssClass="input" required></asp:TextBox>
				</asp:Label>


				<asp:Label runat="server">
					<span>Senha</span>
					<asp:TextBox runat="server" ID="TextSenha" placeholder="" CssClass="input" required></asp:TextBox>
				</asp:Label>

				<asp:Button runat="server" id="Button1" cssclass="submit" text="Cadastrar" onclick="Button1_Click" data-bs-toggle="modal" data-bs-target="#myModal" >
					</asp:Button>				

<asp:Label ID="ErrorMessageLabel" runat="server"  class="label" Visible="false"></asp:Label>


				<asp:Label runat="server" CssClass="signin">Já tem uma conta? <a href="LoginUsuarioWeb.aspx">Login</a></asp:Label>
			</div>
		</div>
	</div>


	


	<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
		

</asp:Content>