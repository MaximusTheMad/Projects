<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Graduation Age Program</title>
    <style type="text/css">
        #form1 {
            height: 609px;
        }
    </style>
</head>
<body>
    <header style="padding-bottom:10em; background-image: url('71WVOwRmIEL._SX355_.jpg'); background-size:100% 100%;"></header>
    <form id="form1" runat="server" style="background-color: #CCFF99; padding: 20px 0px 0px 20px">
    <div style="margin:3px; height: 238px; width: 320px; position: absolute; top: 367px; left: 53px;" id="BirthDate">
        <asp:Label ID="Label9" runat="server" Text="Birth Date" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="BirthMonthLabel2" runat="server" Text="Month (MM)"></asp:Label>
    
        <br />
        <asp:TextBox ID="BirthMonth" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Day (DD)"></asp:Label>
        <br />
        <asp:TextBox ID="BirthDay" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Year (YYYY)"></asp:Label>
        <br />
        <asp:TextBox ID="BirthYear" runat="server"></asp:TextBox>
    
    </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        \<div style="margin:3px; height: 64px; width: 1032px; position: absolute; top: 229px; left: 24px;" id="Top">
        <asp:Label ID="CurrentDateLabel" runat="server" Text="Graduation Date" Font-Italic="True" Font-Size="32pt"></asp:Label>
        <br />
        <br />
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <div style="margin:3px; height: 190px; width: 246px; position: absolute; top: 626px; left: 48px;" id="SubmitandShow">
            <asp:Button ID="Button1" runat="server" Height="42px" Text="Submit" Width="107px" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="CalculatedAgeLabel" runat="server" Font-Bold="True" Font-Size="24px" Text="Label"></asp:Label>
        <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    <div style="margin:3px; height: 238px; width: 320px; position: absolute; top: 367px; left: 400px;" id="GraduationDate">
        <asp:Label ID="Label5" runat="server" Text="Graduation Date" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="BirthMonthLabel0" runat="server" Text="Month (MM)"></asp:Label>
    
        <br />
        <asp:TextBox ID="GradMonth" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Day (DD)"></asp:Label>
        <br />
        <asp:TextBox ID="GraduationDay" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Year (YYYY)"></asp:Label>
        <br />
        <asp:TextBox ID="GraduationYear" runat="server"></asp:TextBox>
    
    </div>
        <br />
        <br />
        <br />
            <asp:Label ID="Instructions" runat="server" Font-Bold="False" Font-Size="24px" Text="Please enter your Date of Birth and Date Of Graduation below, then hit submit to get your age at Graduation" Font-Italic="True"></asp:Label>
    </form>
</body>
</html>
