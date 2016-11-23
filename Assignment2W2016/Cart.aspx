<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Assignment2W2016.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
    <asp:GridView ID="defaultgrid"  AutoGenerateColumns="false" runat="server" onrowcommand="CustomersGridView_RowCommand">
        <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name of Product"  />
   
	<asp:BoundField  DataField="RegularPrice" HeaderText="Regular Price"/>
     <asp:BoundField  DataField="SalePrice" HeaderText="Sale Price" />
     <asp:BoundField  DataField="ImageFromProduct" HeaderText="Image of Product" />
     <asp:BoundField  DataField="ShortDescription" HeaderText="Description" />
       <asp:ButtonField ButtonType="Button" Text="Buy Now" CommandName="BuyNow" />
            </Columns>
    </asp:GridView>
        </div>
</asp:Content>
