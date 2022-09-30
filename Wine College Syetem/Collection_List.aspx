<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Collection_List.aspx.cs" Inherits="Wine_Collection.Collection_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h3>Customer's wine list</h3>
        <asp:Table ID="tblWine" runat="server" CssClass="table">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>StorageDate</asp:TableHeaderCell>
                <asp:TableHeaderCell>CustomerID</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>CustomerType</asp:TableHeaderCell>
                <asp:TableHeaderCell>WineCode</asp:TableHeaderCell>
                <asp:TableHeaderCell>WineCategory</asp:TableHeaderCell>
                <asp:TableHeaderCell>WineBrand</asp:TableHeaderCell>
                <asp:TableHeaderCell>WineVarietal</asp:TableHeaderCell>
                
            </asp:TableHeaderRow>
        
        </asp:Table>

   
</asp:Content>
