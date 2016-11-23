<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="Assignment2W2016.ThankYou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
        <br />
        <br />
        <br />
        <b>THANKS YOU FOR SHOPPING AT MEEPSHOP.</b>
        <br />
        <b>Your items will be delivered shortly</b>
        <br />
        <br />
       <asp:Button runat="server" Text="Return to Home" OnClick="returnDef"/>
         </div>
</asp:Content>
