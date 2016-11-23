<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdminMenu.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Assignment2W2016.Admin.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
        <asp:ScriptManager runat="server"/>
    <asp:Label runat="server">Name of Product: </asp:Label><asp:TextBox runat="server" ID="nameNew"> </asp:TextBox>
    <br />
    <br />
    <asp:Label runat="server">Regular Price: </asp:Label><asp:TextBox runat="server" ID="regularP"></asp:TextBox>
    <br />
    <br />
    <asp:Label runat="server">Sale Price: </asp:Label><asp:TextBox runat="server" ID="SaleP"></asp:TextBox>
    <br />
    <br />
    <asp:Label runat="server">Image: </asp:Label><asp:FileUpload ID="fileUpload" runat="server"/>
     <br />
    <br />
    <asp:Label runat="server">Short Description: </asp:Label><asp:TextBox runat="server" ID="description"></asp:TextBox>
    
    <br />
    <br />
     
       <asp:Label runat="server">On Sale: </asp:Label>
     <asp:DropDownList runat="server" ID="yesno">  
        <asp:ListItem  Text="yes"/>
             <asp:ListItem Text="no"/>
  
     
     </asp:DropDownList>
    <br />
    <br />
    <asp:Label runat="server">Category: </asp:Label><asp:DropDownList runat="server" ID="categoryo"   > </asp:DropDownList>
        <br />
    <br />
         <asp:Label runat="server">Long Description: </asp:Label>
        <asp:Panel ID="container123" runat="server">
            <ajaxToolkit:HtmlEditorExtender runat="server" TargetControlID="Lodesc" EnableSanitization="false" />
            <asp:TextBox ID="Lodesc" TextMode="MultiLine" Columns="60" Rows="8" runat="server" />             
        </asp:Panel>

        <asp:Button runat="server" Text="Submit" OnClick="MenuItemClick"/>
        </div>
</asp:Content>
