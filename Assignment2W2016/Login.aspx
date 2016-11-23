<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMenu.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment2W2016.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="divi">
        <asp:Label runat="server">Username:  </asp:Label><asp:TextBox runat="server" ID="username"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">Password: </asp:Label><asp:TextBox runat="server" ID="password"></asp:TextBox>
        <br />
         <asp:Button runat="server" Text="Submit" OnClick="Logme"/>
        <br />
        <asp:Label runat="server" ID="notlog"></asp:Label>
    </div>
</asp:Content>
