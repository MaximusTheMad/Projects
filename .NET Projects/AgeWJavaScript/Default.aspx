<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Graduation Age Program w/Javascript</title>
    <style type="text/css">
        #form1 {
            height: 609px;
        }
    </style>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
    <script>

        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: 'default.aspx/GetDate',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (results) {
                    $("#CurrentDateLabel").val(results.d); 
                },
                error: function (err) {
                    alert(err.status + " - " + err.statusText);
                }
            });
        });
        
        
        function getAge() {
            var bYear = document.getElementById("BirthYear").value;
            var bMonth = document.getElementById("BirthMonth").value;
            var bDay = document.getElementById("BirthDay").value;
            var gYear = document.getElementById("GraduationYear").value;
            var gDay = document.getElementById("GraduationDay").value;
            var gMonth = document.getElementById("GradMonth").value;

            var realBirthMonth = (parseInt(bMonth) - 1).toString();
            var realGradMonth = (parseInt(gMonth) - 1).toString();
            var Birthdate = new Date(bYear, realBirthMonth, bDay);
            var Graddate = new Date(gYear, realGradMonth, gDay);
            
            var Years = Graddate.getFullYear() - Birthdate.getFullYear();

            Birthdate.setFullYear(Graddate.getFullYear());

            if (Graddate < Birthdate) {
                Years=Years-1;
            }

            document.getElementById("CalculatedAgeLabel").innerHTML = "You will be " + Years + " years old when you graduate";


        }
        
    </script>
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
        <input id="BirthMonth" type="text" />
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Day (DD)"></asp:Label>
        <br />
        <input id="BirthDay" type="text"/>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Year (YYYY)"></asp:Label>
        <br />
        <input id="BirthYear" type="text" />
    
    </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <div style="margin:3px; height: 64px; width: 1032px; position: absolute; top: 229px; left: 24px;" id="Top">
        <asp:TextBox ID="CurrentDateLabel" BorderColor="White" BorderStyle="None" BorderWidth="0" runat="server" Text="Graduation Date" Font-Italic="True" Font-Size="24pt" BackColor="#CCFF99" Value="RF" Width="856px" ReadOnly="True"></asp:TextBox>
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
        <div style="margin:3px; height: 190px; width: 668px; position: absolute; top: 626px; left: 48px;" id="SubmitandShow">
            <input id="Button1" type="button" style="height:42px; width:107px;" value="Submit" onclick="getAge()" />
            <br />
            <br />
            <br />
            <p id="CalculatedAgeLabel" style="font-weight:bold; font-size:24px; border-style:None; width:653px"></p>
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
        <input id="GradMonth" type="text"/>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Day (DD)"></asp:Label>
        <br />
        <input id="GraduationDay" type="text" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Year (YYYY)"></asp:Label>
        <br />
        <input id="GraduationYear" type="text" />
    
    </div>
        <br />
        <br />
        <br />
            <asp:Label ID="Instructions" runat="server" Font-Bold="False" Font-Size="24px" Text="Please enter your Date of Birth and Date Of Graduation below, then hit submit to get your age at Graduation" Font-Italic="True"></asp:Label>
    </form>
</body>
</html>
