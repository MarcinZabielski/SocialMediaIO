<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="SocialMediaIO.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h1>Portal społecznościowy</h1>
            <h2>Logowanie</h2>
            <asp:Label ID="Label1" runat="server" Text="Użytkownik:"></asp:Label><br />
            <asp:TextBox runat="server" ID="UserName"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Hasło:"></asp:Label><br />
            <asp:TextBox runat="server" ID="PassWord"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Zaloguj się" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Nie mam konta" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
