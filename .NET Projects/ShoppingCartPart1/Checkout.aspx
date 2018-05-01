<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Order Summary:" Font-Bold="true" Font-Size="24px"></asp:Label>
       <br />
    <br />
    <asp:Label ID="OrdersLabel" runat="server" Text="Items:"></asp:Label>
    <br />
     <asp:Label ID="QuantityLabel" runat="server" Text="Quantity:"></asp:Label>
    <br />
    <asp:Label ID="WeightLabel" runat="server" Text="Weight:"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="ItemTotalLabel" runat="server" Text="Item Total:" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="ItemTotal" runat="server" Text="Label"></asp:Label>
    <br />
     <asp:Label ID="ShippingLabel" runat="server" Text="Shipping Cost:" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp; <asp:Label ID="ShippingCost" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="TotalCostLabel" runat="server" Text="Final Cost:" Font-Bold="true" Font-Size="20px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="TotalCost" runat="server" Text="Label" Font-Size="20px"></asp:Label>
    <br />
    <br />
    <br />
    <div id="ShippingInfo">
    <asp:Label ID="Label2" runat="server" Text="Shipping Information:" Font-Bold="true" Font-Size="24px" CssClass="ShippingDetailLabel"></asp:Label>
    <br />
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="NameBox"></asp:RequiredFieldValidator><asp:Label ID="Label3" runat="server" Text="Name:" CssClass="ShippingDetailLabel"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NameBox" runat="server" CssClass="ShippingDetail" Width="311px" />
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="StreetBox"/><asp:Label ID="Label4" runat="server" Text="Street:" CssClass="ShippingDetailLabel"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="StreetBox" runat="server"  CssClass="ShippingDetail" Width="315px" />
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="CityBox"/><asp:Label ID="Label5" runat="server" Text="City:" CssClass="ShippingDetailLabel"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="CityBox" runat="server" CssClass="ShippingDetail" Width="310px"/>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="StateBox"/><asp:Label ID="Label6" runat="server" Text="State:" CssClass="ShippingDetailLabel"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;
    <asp:TextBox ID="StateBox" runat="server" CssClass="ShippingDetail" Width="313px"/>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="ZipBox"/><asp:Label ID="Label7" runat="server" Text="ZIP:" CssClass="ShippingDetailLabel"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;
    <asp:TextBox ID="ZipBox" runat="server" CssClass="ShippingDetail" Width="310px"/>
    <br />
   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="#CC3300" ControlToValidate="EmailBox"/> <asp:Label ID="Label8" runat="server" Text="E-mail Address:" CssClass="ShippingDetailLabel"></asp:Label>
    <asp:TextBox ID="EmailBox" runat="server" CssClass="ShippingDetail" Width="307px"/>&nbsp;&nbsp;&nbsp; 
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" Font-Bold="True" BackColor="Black" ForeColor="White" OnClick="Button1_Click" />

        <asp:CustomValidator runat="server" id="cusCustom" controltovalidate="EmailBox" onservervalidate="cusCustom_ServerValidate" errormessage="Email Address does not contain '@' or '.'" />
    </div>
    
</asp:Content>

