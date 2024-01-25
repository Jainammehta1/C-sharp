<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.signin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE html>
    <head runat="server">
        <title>login</title>
        <style>
            h1{
                text-align:center;
            }
            .div{
                margin:80px 480px;
                padding:20px;
                border:1px solid;
                text-align:center;
                align-items:center;
            }
            .txt{
                width:300px;
                height:30px;
                text-align:center;
               
            }
            .btn{
                height:40px;
                width:300px;
                margin-top:10px;
                text-align:center;
            }
        </style>
        </head>
        <body>
            <form id="form1" runat="server">
                <h1>LOG IN PAGE</h1>
                <div>USERNAME:<br />
                    <asp:TextBox CssClass="txt" id="txtuser" runat="server" /><br />
                    Password:<br />
                    <asp:TextBox CssClass="txt" id="txtpass" runat="server" /><br />
                    <asp:Button CssClass="btn" ID="sbt" Text="SUBMIT" runat="server" />
                </div>
                </form>
        </body>
    
</html>
