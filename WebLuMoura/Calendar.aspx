<%@ Page Title="Caledar" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true"
	CodeBehind="Calendar.aspx.cs" Inherits="WebLuMoura.Calendar" %>



<asp:Content Language="C#" ID="Content1" ContentPlaceHolderID="head" runat="server">



	<!-- Conteúdo do cabeçalho, incluindo metatags e links para CSS -->

	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<title>Calendário</title>

	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Rounded:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200" />


	<style>
		@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap');

		.custom-button2 {
			width: 100%;
			background-color: #d2b48c;
			color: #fff;
			border: none;
			padding: 2px;
			border-radius: 10px;
			font-size: 1.2rem;
			cursor: pointer;
			transition: background-color 0.3s ease;
		}

			.custom-button2:hover {
				background-color: #A88E66;
			}

		}

		* {
			margin: 0;
			padding: 0;
			box-sizing: border-box;
			font-family: 'Poppins', sans-serif;
		}

		body {
			font-family: 'Arial', sans-serif;
			background-color: #f2f2f2;
			margin: 0;
			padding: 0;
			box-sizing: border-box;
		}

			body header,
			body footer {
				width: 100%;
				max-width: 100%;
				overflow-x: hidden;
				background-color: #F7F3E8;
				padding: 0; /* Remova o padding para garantir que não haja espaço extra */
				box-sizing: border-box;
			}

		.container-fluid {
			display: flex;
			flex-wrap: wrap;
			justify-content: space-between;
			max-width: 1200px;
			width: 100%;
			margin: 20px auto;
		}

		.wrapper {
			display: flex;
			flex-wrap: wrap;
			width: 100%;
			justify-content: center; /* Centraliza os elementos */
		}

		.calendar-wrapper,
		.textbox-wrapper {
			width: calc(50% - 10px); /* 50% width for each, considering 10px margin */
			background: #fff;
			border-radius: 10px;
			box-shadow: 0 15px 40px rgba(0, 0, 0, 0.12);
			margin-bottom: 20px;
		}

		/* Adicionando uma nova classe para centralizar o calendário */
		.calendar-center {
			display: flex;
			justify-content: center;
			align-items: center;
		}

		.textbox-wrapper {
			padding: 20px;
		}

			.textbox-wrapper label {
				font-size: 1rem;
				font-weight: 500;
				margin-bottom: 10px;
			}

			.textbox-wrapper input,
			.textbox-wrapper select {
				width: 100%;
				padding: 10px;
				margin-bottom: 15px;
				border: 1px solid #ddd;
				border-radius: 5px;
			}

		header .icons span {
			height: 38px;
			width: 38px;
			margin: 0 1px;
			cursor: pointer;
			color: #878787;
			text-align: center;
			line-height: 38px;
			font-size: 1.9rem;
			user-select: none;
			border-radius: 50%;
		}

			header .icons span:last-child {
				margin-right: -10px;
			}

			header .icons span:hover {
				background: #f2f2f2;
			}

		header .current-date {
			font-size: 1.45rem;
			font-weight: 500;
		}

		.calendar {
			padding: 50px;
		}

			.calendar ul {
				display: flex;
				flex-wrap: wrap;
				list-style: none;
				text-align: center;
			}

			.calendar li {
				background: #D2B48C;
				width: calc(100% / 7);
				font-size: 1.2rem;
			}

			.calendar .weeks li {
				font-weight: 500;
				cursor: default;
			}

			.calendar .days li {
				z-index: 1;
				cursor: pointer;
				position: relative;
				margin-top: 30px;
			}

		.days li.inactive,
		.days li.active {
			background: #D2B48C;
		}

			.days li.active::before {
				background: #D2B48C;
			}

		.days li:not(.active):hover::before {
			background: #D2B48C;
		}

		table {
			border-spacing: 1;
			border-collapse: collapse;
			background: white;
			border-radius: 6px;
			overflow: hidden;
			max-width: 800px;
			width: 96%;
			margin: 0 auto;
			position: relative;
			border: 2px solid black;
		}

		td,
		th {
			padding: 8px;
			border: solid 1px;
		}

		thead tr {
			text-align: center;
			width: 100%;
			height: 40px;
			background: #D2B48C;
			font-size: 16px;
			border: solid 1px;
		}

		.cadastro-wrapper {
			display: flex;
			justify-content: center;
			margin-top: 20px;
			width: 100%;
		}

		.custom-button1 {
			width: 100%;
			background-color: #d2b48c;
			color: #fff;
			border: none;
			padding: 20px;
			border-radius: 10px;
			font-size: 1.2rem;
			cursor: pointer;
			transition: background-color 0.3s ease;
		}

		custom-button1 {
			background-color: #A88E66;
		}




		@media screen and (max-width: 780px) {
			.calendar li {
				font-size: 0.8rem;
			}

			.calendar-wrapper,
			.textbox-wrapper {
				width: 100%;
				max-width: 100%;
				margin-right: 0;
				margin-bottom: 20px;
			}
		}

		.loader {
			width: 48px;
			height: 48px;
			margin: auto;
			position: relative;
		}

			.loader:before {
				content: '';
				width: 48px;
				height: 5px;
				background: #f0808050;
				position: absolute;
				top: 60px;
				left: 0;
				border-radius: 50%;
				animation: shadow324 0.5s linear infinite;
			}

			.loader:after {
				content: '';
				width: 100%;
				height: 100%;
				background: #f08080;
				position: absolute;
				top: 0;
				left: 0;
				border-radius: 4px;
				animation: jump7456 0.5s linear infinite;
			}

		@keyframes jump7456 {
			15% {
				border-bottom-right-radius: 3px;
			}

			25% {
				transform: translateY(9px) rotate(22.5deg);
			}

			50% {
				transform: translateY(18px) scale(1, .9) rotate(45deg);
				border-bottom-right-radius: 40px;
			}

			75% {
				transform: translateY(9px) rotate(67.5deg);
			}

			100% {
				transform: translateY(0) rotate(90deg);
			}
		}

		@keyframes shadow324 {

			0%, 100% {
				transform: scale(1, 1);
			}

			50% {
				transform: scale(1.2, 1);
			}
		}

		.textbox1 {
			justify-content: space-between;
			align-items: center;
		}

			.textbox1 label {
				margin-right: 100px;
				 color: #555; /* Cor do texto */
 font-size: 16px; /* Tamanho da fonte */
			}


   


.textbox1 .highlight-label {
    color: #e44d26; /* Cor de destaque, pode ser ajustada conforme necessário */
}

	</style>



</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True"></asp:ScriptManager>

	<asp:UpdatePanel ID="updatePanel" runat="server">
		<contenttemplate>

			<div class="container-fluid">
				<div class="textbox-wrapper">
					<div class="textbox">
						<asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
						<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
					</div>
					<div class="textbox">
						<asp:Label ID="lblTelefone" runat="server" Text="Telefone:"></asp:Label>
						<asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
					</div>
					<div class="textbox">
						<asp:Label ID="lblDescricao" runat="server" Text="Observação:"></asp:Label>
						<asp:TextBox ID="txtDescricao" runat="server" OnTextChanged="txtDescricao_TextChanged"></asp:TextBox>
					</div>
					<div class="textbox">
						<asp:Label ID="lblServicos" runat="server" Text="Serviços:"></asp:Label>
						<asp:DropDownList ID="ddlServicos" runat="server" AutoPostBack="true" CssClass="custom-dropdown" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
							<asp:ListItem Text="Selecione um serviço" />
						</asp:DropDownList>
					</div>
					<div class="textbox1">
						<asp:Label ID="Label1" runat="server" Text="Selecione Uma Data:       "></asp:Label>					
					</div>
					<br />
										

					<div class="textbox1">
					<asp:Label ID="Label2" runat="server" Text="Secione Um Horario:       "></asp:Label>
					</div>
										
					<br />

					<div class="textbox1">
						<asp:Label ID="lblLabel3" runat="server" Text="Preço:        "></asp:Label>

					</div>
										
					<br />

					<div class="textbox1">
						<asp:Label ID="lblLabel4" runat="server" Text="Daração:      "></asp:Label>

					</div>
				</div>

				<div class="calendar-wrapper">
					<div class="wrapper">
						<div class="calendar">
							<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Font-Overline="False" Font-Size="20px" BackColor="Black" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black">
								<dayheaderstyle backcolor="White" bordercolor="White" forecolor="Black" />
								<daystyle backcolor="White" bordercolor="White" forecolor="Black" />
								<nextprevstyle bordercolor="White" />
								<othermonthdaystyle backcolor="White" bordercolor="White" borderstyle="Solid" />
								<selecteddaystyle backcolor="Tan" bordercolor="Black" />
								<selectorstyle bordercolor="Black" forecolor="White" />
								<titlestyle backcolor="Tan" bordercolor="White" />
								<todaydaystyle backcolor="White" bordercolor="White" />
								<weekenddaystyle bordercolor="White" />
							</asp:Calendar>

							<asp:Label ID="lblSemHorarios" runat="server" Text="Sem horários disponíveis para esta data." Visible="false"></asp:Label>
							<asp:Label ID="lblSelecionarHorario" runat="server" Text="Selecione um horário." Visible="True"></asp:Label>


							<asp:Repeater ID="rptHorarios" runat="server" OnItemCommand="rptHorarios_ItemCommand">
								<headertemplate>
									<table id="horarios-table">
										<thead>
											<tr>
												<th>Hora</th>
												<th>Escolher</th>
											</tr>
										</thead>
										<tbody class="widfi">
								</headertemplate>
								<itemtemplate>
									<tr>
										<td><%# Eval("Hora") %></td>
										<td>
											<asp:Button runat="server" CssClass="custom-button2" CommandName="EnviarDados" CommandArgument='<%# Eval("HorarioID") %>' Text="Selecionar" />
										</td>
									</tr>
								</itemtemplate>
								<footertemplate>
									</tbody>
        </table>
								</footertemplate>
							</asp:Repeater>
						</div>
					</div>
				</div>


			</div>



			<div class="cadastro-wrapper text-center">
				<asp:Button id="btnCadastrar" class="custom-button1" runat="server" Text="Agendar Agora!" OnClick="BtnAgendar_Click" />

			</div>
			<script type="text/javascript">
				function reloadPageAfterAlert() {
					location.reload();
				}
			</script>

			<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
			<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

		</contenttemplate>


	</asp:UpdatePanel>

	<asp:UpdateProgress ID="updateProgress" runat="server" AssociatedUpdatePanelID="updatePanel" DisplayAfter="0">
		<progresstemplate>
			<div id="loadingOverlay" style="position: fixed; top: 0; left: 0; width: 100%; height: 100%; background: rgba(255, 255, 255, 0.8); text-align: center; padding-top: 20%;">
				<div class="loader"></div>
			</div>
		</progresstemplate>
	</asp:UpdateProgress>

</asp:Content>
