<%@ Page Title="" Language="C#" MasterPageFile="~/Navigation.Master" AutoEventWireup="true" CodeBehind="Add_Wine.aspx.cs" Inherits="Wine_Collection.Add_Wine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Select Wines</h3>

    <div class="selectWine">
        <asp:Label ID="customerName" runat="server" Text="Customer: "></asp:Label>&nbsp;
            <asp:DropDownList ID="CustomerList" runat="server" Width="250px" Height="25px" OnSelectedIndexChanged="Change_Customer" AutoPostBack="true">
                <asp:ListItem Value="0">Select ...</asp:ListItem>
            </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="CustomerList"
                InitialValue="0" Display="Dynamic" CssClass="required-field" ForeColor="Red">Must select one</asp:RequiredFieldValidator>
           
        <%--<asp:Panel runat="server" ID="pnlSelection">--%>
            <br />
           
            

            <h4>Following Wines are currently available for selected customer </h4>
            <asp:Label ID="cName" runat="server"></asp:Label>

            <asp:RequiredFieldValidator runat="server" ControlToValidate="RadioButtonList1"
                selected=false Display="Dynamic" CssClass="required-field" ForeColor="Red">Must select one category</asp:RequiredFieldValidator>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"  AutoPostBack="true" OnSelectedIndexChanged ="RadioButtonSelectedIndexChanged">
                <asp:ListItem ID="r1" Text="Red Wine" selected = false></asp:ListItem>
                <asp:ListItem ID="r2" Text="White Wine" selected = false></asp:ListItem>
                <asp:ListItem ID="r3" Text="Rose Wine" selected = false></asp:ListItem>
            </asp:RadioButtonList>
            

            <asp:Label runat="server" ID="secceedMsg" CssClass="alert-danger" ForeColor="Blue" />
            <asp:Label runat="server" ID="ErrorMsg" CssClass="alert-danger" ForeColor="Red" />
            <br />
            
            <asp:CheckBoxList ID="chklst" runat="server" />

            <br />
            <br />
            <asp:Button CssClass="button-9" ID="save" Text="Save" runat="server" OnClick="save_Click" />
            <br />
            <br />
        <%--</asp:Panel>--%>
               
    </div>

    <script>

    </script>

</asp:Content>


