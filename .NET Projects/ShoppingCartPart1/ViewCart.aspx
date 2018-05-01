<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Table">
    Shopping cart details:
    &nbsp;&nbsp;
        <asp:GridView ID="CartItems" runat="server" CellPadding="4" GridLines="None" AutoGenerateSelectButton="True" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
            
        </asp:GridView>
        <br />
        <asp:Table ID="lineItems" runat="server" CssClass="CartTable">
    
        </asp:Table>
        <br />
        <asp:Button ID="CheckOutButton" runat="server" Text="Check Out" CssClass="DetailButton" OnClick="CheckOutButton_Click" />
        &nbsp;
        <asp:Button ID="ContinueShoppingButton" runat="server" Text="Continue Shopping" CssClass="DetailButton" OnClick="ContinueShoppingButton_Click" />
</div>
&nbsp;
</asp:Content>

