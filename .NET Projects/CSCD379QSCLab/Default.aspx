<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="CookieExampleLink" runat="server" OnClick="CookieExampleLink_Click">Cookie Example</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="QueryStringLink" runat="server" OnClick="QueryStringLink_Click">QueryStringLink</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
