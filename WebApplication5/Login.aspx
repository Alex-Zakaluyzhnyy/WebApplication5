<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="Пожалуйста, войдите в систему"></asp:Label>
            </div>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Логин"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Пароль"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Вход" Width="92px" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Нажмите здесь для получения списка продуктов"></asp:Label>
            <asp:Button ID="Button2" runat="server" Height="25px" OnClick="Button2_Click" Text="Перейти на сайт" Width="155px" />
        </p>
    </form>
</body>
</html>
