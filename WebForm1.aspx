<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.signin.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserNameLabel" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </div>
        <div>
            <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

