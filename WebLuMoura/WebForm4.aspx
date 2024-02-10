<%@ Page Title="" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebLuMoura.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
	<style>
		/* Modificações para o pop-up */
		.modal-content.card {
			border: none;
			border-radius: 15px;
			box-shadow: 0px 0px 20px 0px rgba(0, 0, 0, 0.2);
		}

		.modal-header {
			background-color: #1c1610;
			/*Cor Botão Agendamento*/
			color: #F7F3E8;
			border-bottom: 1px solid #dee2e6;
			border-top-left-radius: 15px;
			border-top-right-radius: 15px;
			padding: 15px;
		}

		.modal-title {
			font-size: 24px;
		}

		.btn-close {
			color: #fff;
		}

		.modal-body {
			/* Adicione um pouco de espaço ao redor do conteúdo do modal */
			padding: 20px;
		}

		.cookieHeading {
			font-size: 18px;
			font-weight: 700;
			color: #333;
		}

		.buttonContainer {
			margin-top: 15px;
		}

		.modal-text {
			font-size: 16px;
			margin-bottom: 5px;
		}

		.btn-primary,
		.btn-secondary {
			border-radius: 10px;
			font-size: 16px;
			padding: 10px;
		}
		/*Botão Login*/
		.btn-primary {
			background-color: #1c1610;
			border-color: #1c1610;
		}
		/*Botão Cadastrar*/
		.btn-secondary {
			background-color: #1c1610;
			border-color: #1c1610;
		}

			/*Segunda cor, Sobreposição*/
			.btn-primary:hover,
			.btn-secondary:hover {
				background-color: #F7F3E8;
				border-color: #F7F3E8;
				color: black;
			}

		body {
			background: rgb(240,210,223);
			background: radial-gradient(circle, rgba(240,210,223,1) 0%, rgba(235,226,184,1) 100%);
			padding:20px;
			margin:0 auto;
		}
		/* Define o estilo para o botão "Agendar" */
		.btn-agendar {
			border: none;
			border-radius: 20px;
			background: linear-gradient(32deg,#03a9f4,#f441a5,#ffeb3b,#03a9f4);
			transition: all 1.5s ease;
			font-family: 'Ropa Sans', sans-serif;
			font-weight: bold;
			letter-spacing: 0.05rem;
			padding: 0;
			margin-left: 485px;
			margin-top: 75px;
		}

			.btn-agendar span {
				display: inline-block;
				padding: 15px 35px;
				font-size: 17px;
				border-radius: 20px;
				background: #ffffff10;
				backdrop-filter: blur(20px);
				transition: 0.4s ease-in-out;
				transition-property: color;
				height: 100%;
				width: 100%;
			}

				.btn-agendar span:hover {
					backdrop-filter: blur(0px);
					color: #ffffff;
				}

		.container {
			justify-content: center;
			margin-top: 75px;
			margin-left: 150px;
			margin: 0 auto;
			padding:20px;
		}
	</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div class="row justify-content-center">
			<!-- MEIO -->
			<div id="carouselExampleIndicators" class="carousel slide position-relative" data-bs-ride="carousel">
				<div class="carousel-indicators">
					<button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
					<button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
					<button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
				</div>

				<div class="carousel-inner">
					<div class="carousel-item active">
						<img src="https://scontent.xx.fbcdn.net/v/t1.15752-9/415162928_6604776566294666_4317691836808725937_n.png?_nc_cat=103&ccb=1-7&_nc_sid=510075&_nc_ohc=d06EHvdIcq0AX_W-n3w&_nc_ad=z-m&_nc_cid=0&_nc_ht=scontent.xx&oh=03_AdQCdbhXt1M4q5joC98-UPzgQqATog1w7Qo2R4j3oBE-BQ&oe=65DB1DFD" class="d-block w-100" alt="...">
					</div>
				</div>
				<div class="carousel-item">
					<img src="https://scontent.xx.fbcdn.net/v/t1.15752-9/416292665_1094203938288626_965904188917696200_n.png?stp=dst-png_p403x403&_nc_cat=103&ccb=1-7&_nc_sid=510075&_nc_ohc=sYOVgQlnOckAX91ggxA&_nc_ad=z-m&_nc_cid=0&_nc_ht=scontent.xx&oh=03_AdTu3O-vHZ5eZRQGPIzdOgGy-Dijw_MIsxBuIxUb7UQzlw&oe=65DB15FF" class="d-block w-100" alt="...">
				</div>
				<div class="carousel-item">
					<img src="https://scontent.xx.fbcdn.net/v/t1.15752-9/415347754_1456177521637243_1370878532983546627_n.png?_nc_cat=103&ccb=1-7&_nc_sid=510075&_nc_ohc=KK0D80ogqoQAX8rcBWM&_nc_ad=z-m&_nc_cid=0&_nc_ht=scontent.xx&oh=03_AdSY_adLAop4k3yS1eNpoR4mCXrLGKAa5_csGbpeXEYhzg&oe=65DB1736" class="d-block w-100" alt="...">
				</div>
			</div>

		</div>

		<!-- Botão Agendar -->
		<button class="btn-agendar">
			<span>
				<a href="#" class="cta" data-bs-toggle="modal" data-bs-target="#myModal"><span>AGENDAR</span>
			</span>
		</button>


		<!-- Fim do Botão Agendar -->
	</div>
	<!-- Fim do MEIO -->
	</div>
	<!-- Modal de Agendamento -->
	<div class="modal fade" id="myModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
		<div class="modal-dialog">
			<div class="modal-content card">
				<div class="modal-header">
					<h5 class="modal-title" id="exampleModalLabel">Agendamento</h5>
					<button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
				</div>
				<div class="modal-body">
					<!-- Adicione conteúdo do modal aqui -->
					<div class="buttonContainer">
						<a href="LoginUsuarioWEB.aspx" class="btn btn-primary btn-block">Login</a>
						<a href="Cadastro2.aspx" class="btn btn-secondary btn-block">Cadastrar</a>
					</div>
				</div>
			</div>
		</div>
	</div>


	<!-- Adicione os scripts do Bootstrap e do Popper.js -->
	<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</asp:Content>
