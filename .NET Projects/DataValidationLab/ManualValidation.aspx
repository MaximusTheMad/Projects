<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManualValidation.aspx.cs" Inherits="ManualValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Please enter a number whose individual digits add up to a number that ends in a 0"></asp:Label>
        <br />
        <asp:TextBox ID="NumberTextField" runat="server"></asp:TextBox>
        
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="This value is not valid" Type="Integer" ControlToValidate="NumberTextField" EnableClientScript="False" CultureInvariantValues="False" Display="None" MinimumValue="0" MaximumValue="2147483647"></asp:RangeValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CausesValidation="False" OnClick="Button1_Click" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dashed" ForeColor="Red"/>
    </div>
    </form>
</body>
</html>
