<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringRecipient.aspx.cs" Inherits="QueryStringRecipient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFF99; font-family: 'Times New Roman', Times, serif; font-size: 24px">
    <div>
    <p>This is the Query String Recipient Page</p>
        <p>
            <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </div>
        <asp:Button ID="traceButton" runat="server" OnClick="traceButton_Click" Text="Get Trace" />
    </form>
</body>
</html>
