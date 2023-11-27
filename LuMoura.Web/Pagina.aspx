<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="LuMoura.Web.Pagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="row justify-content-center mt-5">
        <div class="col-md-4">
            <h2 class="text-center">
				<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="140px" />
				Login</h2>
            <div id="mensagemErro" class="alert alert-danger d-none" role="alert"></div>

            <form id="formLogin" class="needs-validation" novalidate>

                <div>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </div>

                <div>
                    <asp:Literal ID="resultadoLabel" runat="server"></asp:Literal>
                </div>

                <div class="mb-3">
                    <label for="txtUsuario" class="form-label">Usuário</label>
                    <input type="text" class="form-control" id="txtUsuario" required>
                    <div class="invalid-feedback">Por favor, preencha o usuário.</div>
                </div>
                <div class="mb-3">
                    <label for="txtSenha" class="form-label">Senha</label>
                    <input type="password" class="form-control" id="txtSenha" required>
                    <div class="invalid-feedback">Por favor, preencha a senha.</div>
                </div>
                <button type="button" class="btn btn-primary" id="btnEntrar">Entrar  </button>
                <i id="loadingIcon" class="fas fa-spinner fa-spin d-none"></i>
            </form>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script>
		// Adicione aqui o script JavaScript para manipulação da página, validação e AJAX

		$(document).ready(function () {
			$('#btnEntrar').click(function () {
				// Aqui você pode realizar a chamada AJAX para autenticação
				// Exemplo de chamada AJAX:
				$.ajax({
					type: 'POST',
					url: 'WebService.asmx/AutenticarUsuario', // Substitua pelo seu serviço web ou página que faz a autenticação
					data: {
						usuario: $('#txtUsuario').val(),
						senha: $('#txtSenha').val()
					},
					success: function (result) {
						// Processar a resposta do servidor
						if (result.d === true) {
							// Autenticação bem-sucedida, redirecionar ou fazer outras ações
							window.location.href = 'PaginaInicial.aspx';
						} else {
							// Exibir mensagem de erro
							$('#mensagemErro').text('Usuário ou senha inválidos.').removeClass('d-none');
						}
					},
					error: function () {
						// Tratar erro de requisição AJAX
						console.log('Erro na chamada AJAX.');
					},
					beforeSend: function () {
						// Mostrar ícone de carregamento
						$('#loadingIcon').removeClass('d-none');
					},
					complete: function () {
						// Esconder ícone de carregamento
						$('#loadingIcon').addClass('d-none');
					}
				});
			});
		});
	</script>

</asp:Content>
