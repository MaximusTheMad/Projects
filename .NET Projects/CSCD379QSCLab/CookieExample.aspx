<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieExample.aspx.cs" Inherits="CookieExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 143px">
    
        <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="24pt" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name:  "></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="220px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdStore" runat="server" BackColor="#66FF33" Font-Bold="True" Font-Overline="False" Font-Size="16pt" OnClick="cmdStore_Click" Text="Create Cookie" Width="149px" />
    
    </div>
    </form>
</body>
</html>
