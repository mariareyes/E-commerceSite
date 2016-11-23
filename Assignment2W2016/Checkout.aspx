<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Assignment2W2016.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divi">
        <asp:Label runat="server">Name:  </asp:Label><asp:TextBox runat="server" ID="name"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">Credit Card Number: </asp:Label><asp:TextBox runat="server" ID="creditcard"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">Expiry Date: </asp:Label><asp:TextBox runat="server" ID="expirydate"></asp:TextBox>
        <br />
         <asp:Button runat="server" Text="Complete Transaction" OnClick="comtra"/>
        <br />
       <asp:Button runat="server" Text="Cancel" OnClick="returnDef"/>
    </div>
</asp:Content>
