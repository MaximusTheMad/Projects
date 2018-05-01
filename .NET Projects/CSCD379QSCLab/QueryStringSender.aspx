<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringSender.aspx.cs" Inherits="QueryStringSender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 164px;
        }
        #cmdGo {
            width: 168px;
        }
    </style>
</head>
<body style="height: 283px">
    <form id="form1" runat="server">
    <div>
    <p>This is the Query String Sender Page</p>
        <p>
            <asp:ListBox ID="lstItems" runat="server" Width="237px"></asp:ListBox>
        </p>
        <p>
            <asp:CheckBox ID="chkDetails" runat="server" Text="Show Full Details" />
        </p>
    </div>
        <p>
            <asp:Button ID="cmdGO" runat="server" OnClick="cmdGo_Click" Text="View Information" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
