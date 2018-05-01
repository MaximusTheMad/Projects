<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="http://web.ewu.edu/univrelations/start/logos/downloadImage.php?filename=jpeg/logo_uh_color.jpg" Height="172px" Width="100%" />
        <br />
    </p>
    <p>
        &nbsp;</p>
    </div>
    <div>
        <asp:Label ID="lblStatus" runat="server">Customer Number is not valid</asp:Label>
        <asp:Label ID="lblStatus2" runat="server">Customer Number is not valid</asp:Label>
    </div>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cross Page Post</asp:LinkButton>
       </p>
    </form>
</body>
</html>
