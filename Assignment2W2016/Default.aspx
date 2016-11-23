<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMenu.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment2W2016.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="all">

    <asp:GridView ID="defaultgrid" PageSize="5" AutoGenerateColumns="false" runat="server" AllowPaging="true" EnableViewState="true" >
        <Columns>
	<asp:BoundField DataField="Name" HeaderText="Name of Product" />
   
	<asp:BoundField  DataField="RegularPrice" HeaderText="Regular Price"/>
     <asp:BoundField  DataField="SalePrice" HeaderText="Sale Price" />
  
     <asp:BoundField  DataField="ShortDescription" HeaderText="Description" />
             <asp:TemplateField HeaderText="Image" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <asp:Image ID="image" runat="server" ImageUrl='<%# "~/GetFileHandler.ashx?fileid=" + Eval("Id") %>' Width="300" />
                </ItemTemplate>
            </asp:TemplateField>
  </Columns>
    </asp:GridView>
      </div>
</asp:Content>
