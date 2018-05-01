<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>

    <link rel="stylesheet" href="StyleSheet.css" />
 </head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="http://media.corporate-ir.net/media_files/IROL/17/176060/img/logos/amazon_logo_RGB.jpg" Height="172px" Width="100%" />
        <br />
    </p>
    <p>
        &nbsp;</p>
    </div>
    <div>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
        <asp:Label ID="lblStatus2" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
