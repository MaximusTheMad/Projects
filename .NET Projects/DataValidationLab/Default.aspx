 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Number must be between 1 and 10" ControlToValidate="NumberBox" Type="Integer" MinimumValue="1" MaximumValue="10" ForeColor="#CC3300" Visible="True" Display="None">*</asp:RangeValidator>
        <asp:Label ID="NumberLabel" runat="server" Text="Please enter a number between 1 and 10:"></asp:Label>
        <br />
        <input id="NumberBox" runat="server" type="text" />
        
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please enter a phrase"></asp:Label>
        <br />
        <input id="PasswordBox" runat="server" type="text"/>
        <br />
        <asp:Label ID="PasswordLabel2" runat="server" Text="Please enter the phrase again"></asp:Label>
        <br />
        <input id="PasswordBox2" runat="server" type="text"/>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Phrase must be the same in both boxes" ControlToCompare="PasswordBox" ControlToValidate="PasswordBox2" BackColor="#FFFFCC" ForeColor="#CC3300" Visible="True" Display="None">*</asp:CompareValidator>
        
        <br />
        <asp:Label ID="Label4" runat="server" Text="Please enter a string that contains at least one of the following characters: !,@,#,$,%,^,&"></asp:Label>

        <asp:TextBox runat="server" id="txtCustom" />
        <asp:CustomValidator runat="server" id="cusCustom" controltovalidate="txtCustom" onservervalidate="cusCustom_ServerValidate" errormessage="Text entered does not contain any of the characters!" />
         <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        <br />
        <asp:Label ID="CheckedOff" runat="server" Text=""></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dashed" ForeColor="Red"/>
    </div>
    </form>
</body>
</html>
