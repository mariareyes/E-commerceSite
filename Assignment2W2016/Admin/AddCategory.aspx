<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdminMenu.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="Assignment2W2016.Admin.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
    <asp:Label runat="server">Name of Category: </asp:Label><asp:TextBox runat="server" ID="nameNew"> </asp:TextBox>
    <br />
        <asp:Button runat="server" Text="Sumbit" OnClick="NewCAT" />
        </div>
</asp:Content>
