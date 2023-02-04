<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rejestracja.aspx.cs" Inherits="SocialMediaIO.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Portal społecznościowy</h1>
            <h2>Rejestracja</h2>
            <asp:Label ID="Label1" runat="server" Text="Nazwa użytkownika:"></asp:Label><br />
            <asp:TextBox runat="server"  ID="UserName"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Hasło:"></asp:Label><br />
            <asp:TextBox runat="server" ID="PassWord"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Zarejestruj się" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Posiadam Konto" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
