<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMenu.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Assignment2W2016.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="all">
        <asp:Button ID="addcart" runat="server" Text="Add to Cart" OnClick="addTC" />
        <br />
          <asp:GridView ID="defaultgrid" PageSize="5" AutoGenerateColumns="false" runat="server" AllowPaging="true" EnableViewState="true" BorderColor="Transparent">
        <Columns>
	    <asp:BoundField  DataField="Name" HeaderText="Description" />
     <asp:BoundField  DataField="ShortDescription" HeaderText="Description" />
  </Columns>
    </asp:GridView>
        <asp:Label runat="server" ID="not"></asp:Label>
           
    <asp:ScriptManager runat="Server" />
            <ajaxToolkit:TabContainer ID="tabs" runat="server">
                <ajaxToolkit:TabPanel id="pd" runat="server" HeaderText="Product description">
                    <ContentTemplate>
                        

                        <asp:Label runat="server" ID="meep"></asp:Label>
                        </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel id="co" runat="server" HeaderText="Comments/Rating">
                    <ContentTemplate>
                    <%--aqui van los comentarios--%>
                    <asp:GridView id="dgrid" AutoGenerateColumns="false" runat="server">
                        <Columns>
                            <asp:BoundField DataField="userName" HeaderText="User"  />
                            <asp:BoundField DataField="Date_co" HeaderText="Date"  />
                            <asp:BoundField DataField="Text_co" HeaderText="Comment"  />
                        </Columns>

                    </asp:GridView>
                       <br />
                        <br />
                        <asp:Label runat="server">Comment: </asp:Label>
                        <br />
                        <asp:TextBox id="commentBox" runat="server" Rows="5">Write Comment here...</asp:TextBox>
                        <br />
                    <asp:Button runat="server" Text="Submit" OnClick="Save_Comment"/>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                 </ajaxToolkit:TabContainer>
        </div>
</asp:Content>
