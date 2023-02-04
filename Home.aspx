<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SocialMediaIO.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Portal społecznościowy</h1>
            <h2>Strona główna</h2><br />
            <h2><asp:Literal runat="server" ID="hello" /></h2><br />
            <asp:Button runat="server" Text="Wyloguj się" ID="SignOut" OnClick="SignOut_Click"></asp:Button><br />
            <h3>Opublikuj post:</h3><br />
            <asp:Label ID="Label1" runat="server" Text="Tytuł:"></asp:Label>
            <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Treść:"></asp:Label>
            <asp:TextBox  ID="taContent" runat="server" TextMode="MultiLine" cols="20" rows="5"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Opublikuj" OnClick="Button1_Click" /><br />
            <h3>Posty użytkowników:</h3><br />
            
            <div>
                <asp:Literal runat="server" ID="PostBox" ></asp:Literal>
            </div>
        </div>
    </form>
</body>
</html>
