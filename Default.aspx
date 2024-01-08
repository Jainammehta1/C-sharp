<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" Text="click on these" OnClick="msg"/><br /><br />
    <asp:Button ID="Button2" runat="server" Text="click to reset" OnClick="msg_remove"/><br /><br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    <input id="Text1" type="text" runat="server" />

     <asp:Button ID="Button4" runat="server" Text="Button" OnClick="print_data"/><br /><br />
   
    <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
    <asp:Button ID="Button3" runat="server" Text="Button"/><br /><br />

    <asp:Label ID="Label2" runat="server" Text="Click"></asp:Label><br /><br />
    <asp:Label ID="Label3" runat="server" Text="Click here"></asp:Label><br /><br />

    Male<input id="Radio1" name="1"type="radio"/>
    Female<input id="Radio2"name="1" type="radio"/>
    <input id="File1" type="file" />
    Your Password<input id="Password1" type="password" />
    <img  src="image/samosa.png"/>
    <select id="Select1">
        <option>1</option>
        <option>2</option>
        <option>3</option>

    </select>
</asp:Content>
