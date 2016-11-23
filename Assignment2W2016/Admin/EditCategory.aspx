<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdminMenu.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="Assignment2W2016.Admin.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
           <asp:Label runat="server">Enter new name: </asp:Label><asp:TextBox runat="server" ID="newN"></asp:TextBox>
        <br />
        <br />
       <asp:Label runat="server">Category: </asp:Label><asp:DropDownList runat="server" ID="producti"   > </asp:DropDownList>
     <br />
<asp:Button runat="server" Text="Submit" OnClick="SelPro"/>

        
    </div>
</asp:Content>
