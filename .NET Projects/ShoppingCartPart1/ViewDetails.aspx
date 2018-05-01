<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewDetails.aspx.cs" Inherits="ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <br />
    <asp:Label ID="QuantityOrderedLabel" runat="server" Text="Quantity To Order:" Font-Size="32px"></asp:Label>

    <asp:DropDownList ID="QuantityOrdered" runat="server" BackColor="#CC3300" ForeColor="White" Height="4em" Width="5em">
        <asp:ListItem Selected="True">1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button runat="server" Text="Add To Cart" ID="AddToCart" CssClass="DetailsButton" Font-Bold="True" OnClick="AddToCart_Click"/>
    <asp:Button ID="ViewCartButton" runat="server" Text="View Cart" CssClass="DetailsButton" Font-Bold="True" OnClick="ViewCartButton_Click" />
    </asp:Content>

