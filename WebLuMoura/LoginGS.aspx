<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginGS.aspx.cs" Inherits="WebLuMoura.LoginGS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Login:
        <asp:TextBox ID="TextBox1" runat="server" />
        <br />
        Senha:
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" />
        <br />
        <asp:Button ID="BtnLogar" runat="server" OnClick="BtnLogar_Click" Text="Logar" />
        <asp:Label ID="LblResposta" runat="server" Text="" />
    </form>
</body>
</html>
