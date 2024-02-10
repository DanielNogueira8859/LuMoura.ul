<%@ Page Title="" Language="C#" MasterPageFile="~/LuMoura.Master" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="WebLuMoura.Calendario" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Seção de conteúdo principal -->
	<div class="container">
		<div class="row">
			<!-- Calendário à Esquerda -->
			<div class="col-md-4">
				<asp:Calendar ID="Calendar1" runat="server" Height="400px" Width="300px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
			</div>

			<!-- TextBox no Centro Superior -->
			<div class="col-md-8">
				<asp:TextBox ID="TextBox1Nome" runat="server" CssClass="form-control mb-2"></asp:TextBox>
				<asp:TextBox ID="TextBox2Telefone" runat="server" CssClass="form-control mb-2"></asp:TextBox>
				<asp:TextBox ID="TextBox3Observacao" runat="server" CssClass="form-control mb-2" OnTextChanged="TextBox3Observacao_TextChanged" AutoPostBack="true" ></asp:TextBox>
				<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
				</asp:DropDownList>
				<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
					<Columns>
						
						<asp:BoundField DataField="Hora" HeaderText="Hora" />												
						<asp:TemplateField>
							<ItemTemplate>
								<asp:Button runat="server" CommandName="EnviarDados" CommandArgument='<%# Eval("Hora") %>' Text="Enviar Dados" />
							</ItemTemplate>
						</asp:TemplateField>
					</Columns>
				</asp:GridView>
				<div class="col-md-4">
					<asp:Button ID="BtnAgendar" runat="server" Text="Button" OnClick="BtnAgendar_Click" />
					<asp:Label ID="LabelPreco" runat="server" Text="Label"></asp:Label>
				</div>
				<div class="col-md-4">
					<asp:Label ID="LabelDuracao" runat="server" Text="Label"></asp:Label>
				</div>
			</div>

			<!-- GridView no Centro Inferior -->
			<div class="col-md-4">
			</div>

			<!-- DropdownList -->
			<div class="col-md-4">
			</div>
		</div>
	</div>

	<!-- Scripts do Bootstrap (necessário para funcionalidades específicas) -->
	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
		integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
		crossorigin="anonymous"></script>
	<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js"
		integrity="sha384-JN9CZofutdMhu7N2QmBsmw6TMSvg8kgpGfYFYGAS7ByXH4Q4uFquRdAaA4h4Ri0G"
		crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
		integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
		crossorigin="anonymous"></script>
</asp:Content>
