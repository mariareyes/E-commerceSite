<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdminMenu.Master" AutoEventWireup="true" CodeBehind="BadWords.aspx.cs" Inherits="Assignment2W2016.Admin.BadWords" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
    <h2>Bad Words: </h2>
       <asp:GridView ID="defaultgrid" AutoGenerateColumns="false" runat="server" Height="300px" Width="500px" AllowPaging="true" EnableViewState="true">
        <Columns>
	<asp:BoundField DataField="Word" />
     
  </Columns>
    </asp:GridView>
       <br />
    <asp:Label id="badWord" runat="server"></asp:Label>
    <asp:TextBox ID="badWordText" Width="100px" runat="server"></asp:TextBox>
    <asp:Button runat="server" ID="submit" Text="Submit" onClick="SubmitInfo"/>
    </div>
</asp:Content>
