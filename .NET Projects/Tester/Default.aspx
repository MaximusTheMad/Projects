<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~\AdFile.xml" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~\Menu.xml"></asp:XmlDataSource>
        &nbsp;
        &nbsp;
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1" StaticSubMenuIndent="10px" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" >
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="25px" VerticalPadding="10px" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="25px" VerticalPadding="10px" />
            <StaticSelectedStyle BackColor="#FFCC66" />
        </asp:Menu>
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True"></asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SQL5035.SmarterASP.NET;Initial Catalog=DB_A1DD79_maxsZipCodeDB;User Id=DB_A1DD79_maxsZipCodeDB_admin;Password=medic952;" SelectCommand="SELECT * FROM ZIP_Codes WHERE State_Code='53' ORDER BY City"></asp:SqlDataSource>
        
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal" SelectedItemStyle-BorderStyle="Solid" RepeatColumns="20" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">

            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F7DE" />

            <ItemTemplate>
                
                <br />
                <br />
                <hr />
                City:
                <br />
                <asp:Label runat="server" ID="Label2" 
                    text='<%# Eval("City") %>' BackColor="#CC3300" ForeColor="White" />
                <br />
                <br />
                ZIP Code:
               
                <br />
                <asp:Label runat="server" ID="Label4" 
                    text='<%# Eval("ZIPCode") %>' BackColor="#0066CC" ForeColor="White" />
                <hr />
               
            </ItemTemplate>
            <AlternatingItemStyle BackColor="White" />
            <AlternatingItemTemplate>
                <br />
                <br />
                <hr />
                City:
                <br />
                <asp:Label runat="server" ID="Label2" 
                    text='<%# Eval("City") %>' BackColor="#0066CC" ForeColor="White" />
                <br />
                <br />
                ZIP Code:
               
                <br />
                <asp:Label runat="server" ID="Label4" 
                    text='<%# Eval("ZIPCode") %>' BackColor="#CC3300" ForeColor="White" />
                <hr />

            </AlternatingItemTemplate>

<SelectedItemStyle BorderStyle="Solid" BackColor="#CE5D5A" Font-Bold="True" ForeColor="White"></SelectedItemStyle>

        </asp:DataList>

        <asp:XmlDataSource ID="Source3" runat="server" DataFile="~\books.xml"></asp:XmlDataSource>
        &nbsp;

        <asp:GridView ID="GridView1" runat="server" XPath="catalog/book" DataSourceID="Source3" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowSorting="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <%# XPath("@id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                        <%# XPath("author") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <%# XPath("title") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Genre">
                    <ItemTemplate>
                        <%# XPath("genre") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <%# XPath("price") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Publish Date">
                    <ItemTemplate>
                        <%# XPath("publish_date") %>
                    </ItemTemplate>
                </asp:TemplateField>
         
            </Columns>


            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#0033CC" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />


        </asp:GridView>

        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="Source3" DataTextField="id" DataValueField="id">
        </asp:RadioButtonList>
        <asp:ListView ID="ListView1" runat="server" XPath="catalog/book" DataSourceID="Source3">

            <ItemTemplate>
                
              <div style="background-color: #00FF00; padding: 50px"> 
                  <hr />
               <asp:Label ID="IDLabel" runat="server" Text='<%# XPath("@id") %>' />
                         &nbsp;
                         &nbsp;
                        
                  <br />
                <asp:Label ID="Title" runat="server" Text=' <%# XPath("title") %>' />
                         &nbsp;
                         &nbsp;
                <br />
                    <asp:Label ID="Label5" runat="server" Text='<%# XPath("price") %>' />
                         &nbsp;
                         &nbsp;
                <br />
                  <hr />
                  </div> 
            </ItemTemplate>
            <AlternatingItemTemplate>

                <div style="background-color: #00ffff; padding: 50px"> 
                    <hr />
               <asp:Label ID="IDLabel" runat="server" Text='<%# XPath("@id") %>' />
                <br />
                <asp:Label ID="Title" runat="server" Text=' <%# XPath("title") %>' /></td>
                <br />
                    <asp:Label ID="Label5" runat="server" Text='<%# XPath("price") %>' />
                <br />
                    <hr />
                    </div>
            </AlternatingItemTemplate>
        </asp:ListView>
        
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>

                <br />
                <br />
                <hr />
                ZIP Code:
                <br />
                <asp:Label runat="server" ID="Label1" 
                    text='<%# Eval("ZIPCode") %>' />
                <br />
                <br />
                City:
                <br />
                <asp:Label runat="server" ID="Label3" 
                    text='<%# Eval("City") %>' />
                <hr />
               
            </ItemTemplate></asp:Repeater>
        
    </div>
    </form>
</body>
</html>
