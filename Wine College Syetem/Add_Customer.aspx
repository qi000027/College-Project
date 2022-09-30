<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Add_Customer.aspx.cs" Inherits="Wine_Collection.Add_Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h3>Add Customer</h3> 
    <br />     
    <div class="row">
        <div class="col-md-6">            
            <asp:Label ID="Label1" runat="server" Text="Customer Name:  "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="customerName" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredCustomerName" runat="server" Display="Dynamic"
                ControlToValidate="customerName" EnableClientScript="true" CssClass="required-field" ForeColor="Red">Required</asp:RequiredFieldValidator>

            <br />

            <br />
            <asp:Label ID="Label2" runat="server" Text="Membership Level:   " ></asp:Label>&nbsp;
            <asp:DropDownList ID="customerType" runat="server" CssClass="form-control">
                <asp:ListItem Selected="True" Value="0">Select</asp:ListItem>
                <asp:ListItem Value="GoldCard">Gold Card</asp:ListItem>
                <asp:ListItem Value="PlatinumCard">Platinum Card</asp:ListItem>
                <asp:ListItem Value="DiamondCard">Diamond Card</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="requiredLevel" runat="server" ControlToValidate="customerType"
                InitialValue="0" Display="Dynamic" CssClass="required-field" ForeColor="Red">Must select one</asp:RequiredFieldValidator>

            <br />
            <br />
            <br />

            <asp:Button ID="addButton" runat="server" OnClick="add_Click" Text="Add" CssClass="button-9" />

            <br />
            &nbsp;
            <asp:Table ID="tblCustomers" runat="server" CssClass="table">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Customer ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                
                </asp:TableHeaderRow>
            
                
            </asp:Table>
        </div>
    </div>
</asp:Content>
