<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdminMenu.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Assignment2W2016.Admin.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
     <asp:Label runat="server">Product: </asp:Label><asp:DropDownList runat="server" ID="producti"   >  </asp:DropDownList>
        <br />
        <asp:Button runat="server" Text="Submit" OnClick="SelPro"/>


        <br />
    <br />
    <br />
        <h2>Product Selected to Edit:</h2>
        <br />
     <asp:Label runat="server">Category: </asp:Label><asp:DropDownList runat="server" ID="categoryo"   > </asp:DropDownList>
        <br />
        <br />
        <asp:Label runat="server">Name: </asp:Label><asp:TextBox runat="server" ID="name"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">Short Descpription </asp:Label><asp:TextBox runat="server" ID="shortD"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">Long Description </asp:Label><asp:TextBox ID="Lodesc" TextMode="MultiLine" Columns="60" Rows="8" runat="server" /> 
        <br />
    <br />
    <asp:Label runat="server">Regular Price: </asp:Label><asp:TextBox runat="server" ID="regularP"></asp:TextBox>
    <br />
    <br />
    <asp:Label runat="server">Sale Price: </asp:Label><asp:TextBox runat="server" ID="SaleP"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server">On Sale: </asp:Label>
     <asp:DropDownList runat="server" ID="yesno">  
        <asp:ListItem  Text="yes"/>
             <asp:ListItem Text="no"/>
  
     
     </asp:DropDownList>
        <br />
    <br />
    <asp:Label runat="server">Image: </asp:Label><asp:FileUpload ID="fileUpload" runat="server"/>
        <br />
        <br />
                <asp:Button runat="server" Text="Submit" OnClick="newInfoSub"/>
</div>
</asp:Content>
