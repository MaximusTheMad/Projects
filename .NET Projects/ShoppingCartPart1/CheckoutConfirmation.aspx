<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CheckoutConfirmation.aspx.cs" Inherits="CheckoutConfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="OrderComp">
    <asp:Label ID="OrderCompLabel" runat="server" Text=" has been processed. " Font-Bold="True" Font-Size="40px"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="An e-mail has been sent to confirm the order" Font-Bold="True" Font-Size="40px"></asp:Label>
    </div>
</asp:Content>

