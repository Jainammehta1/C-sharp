<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test_Data._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
               
    <asp:Button ID="loadDataButton" runat="server" Text="Load Data" OnClick="loadDataButton_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView> 

         </section>
 
       
<form id="myForm" method="post">
    <div>
        <label forname">Name:</label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="email">Email:</label>
        <asp:TextBox ID="email" runat="server" TextMode="Email" Required="true"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="myFormSubmit" />
    </div>
</form>
<div id="message">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</div>
        
 

         

    </main>

</asp:Content>
