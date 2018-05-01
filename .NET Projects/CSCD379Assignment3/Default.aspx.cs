using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
public partial class _Default : System.Web.UI.Page
{
    private Table lineItems;
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbCommand cmd2;
        OleDbCommand cmd3;
        OleDbDataReader dr;
        OleDbDataReader dr2;
        OleDbDataReader dr3;

        try
        {

            int numberOfOrders=0;
            cn = new OleDbConnection();

            if (Request.UserHostAddress.ToString().Equals("::1"))
            {
                // Local server...
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Max\Documents\Visual Studio 2017\WebSites\CSCD379Assignment3\APP_DATA\Business.accdb;Persist Security Info=False;";
                //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\App_Data\Orders.accdb;Persist Security Info=False;";

            }

            else
            {
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=h:\root\home\mwinston2-001\www\cscd379Assignment3\appdata\BusinessDB.accdb;Persist Security Info=False;";
            }


            cmd = new OleDbCommand("SELECT COUNT(*) AS TotalOrderCount FROM Invoice WHERE Status='OPEN'", cn);
            cmd3 = new OleDbCommand("SELECT *  FROM Customer INNER JOIN Invoice ON Customer.CustNumber=Invoice.CustNumber WHERE Invoice.Status='Open' ORDER BY Customer.CustNumber ASC,InvoiceNumber ASC", cn);
            cn.Open();

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                numberOfOrders = int.Parse(dr["TotalOrderCount"].ToString());
            }
            dr.Close();

            dr3 = cmd3.ExecuteReader();

            int temp = 0;
            double totalSales = 0;
            double totalCombinedWeight = 0;
            int totalItemsSold = 0;
            while (dr3.Read())
            {
                temp = int.Parse(dr3["InvoiceNumber"].ToString());
                double totalOrder = 0;
                this.lineItems = new Table();
                lineItems.CssClass = "Table";
                TableRow HeaderRow = new TableRow();
                HeaderRow.CssClass = "HeadRow";
                HeaderRow.Cells.Add(addHeaderCell("Customer: " + dr3["Customer.CustNumber"].ToString() + " - " + dr3["Contact"].ToString()));
                HeaderRow.Cells.Add(addHeaderCell("Order#: " + dr3["InvoiceNumber"].ToString()));
                HeaderRow.Cells.Add(addHeaderCell("Order Date: " + dr3["OrderDate"].ToString()));
                lineItems.Rows.Add(HeaderRow);
                TableRow AddressRow = new TableRow();
                AddressRow.CssClass = "AddressRow";

                AddressRow.Cells.Add(addAddressCell(dr3["BillingAddress"].ToString()));
                lineItems.Rows.Add(AddressRow);
                TableRow HeadingRow = new TableRow();
                HeadingRow.CssClass = "HeadingRow";
                HeadingRow.Cells.Add(addHeaderCell("SKU"));
                HeadingRow.Cells.Add(addHeaderCell("Description"));
                HeadingRow.Cells.Add(addHeadCalcCell("Price"));
                HeadingRow.Cells.Add(addHeadCalcCell("Quantity"));
                HeadingRow.Cells.Add(addHeadCalcCell("Weight"));
                HeadingRow.Cells.Add(addHeadCalcCell("Extended Price"));
                HeadingRow.Cells.Add(addHeadCalcCell("Extended Wt."));
                HeadingRow.Cells.Add(addHeadCalcCell("Order Total"));

                lineItems.Rows.Add(HeadingRow);
                cmd2 = new OleDbCommand("SELECT * FROM ((Invoice INNER JOIN LineItem ON Invoice.InvoiceNumber = LineItem.InvoiceNumber) INNER JOIN Inventory ON LineItem.SKU = Inventory.SKU) WHERE Invoice.InvoiceNumber="+temp.ToString()+" ORDER BY Invoice.InvoiceNumber ASC, LineItem.LineNumber ASC ", cn);
                dr2 = cmd2.ExecuteReader();
                while(dr2.Read())
                {
                    
                    TableRow lineItem = new TableRow();
                    lineItem.Cells.Add(addCell(dr2["LineItem.SKU"].ToString()));
                    lineItem.Cells.Add(addCell(dr2["Description"].ToString()));
                    double unitPrice = double.Parse(dr2["UnitPrice"].ToString());
                    lineItem.Cells.Add(addCalcCell(unitPrice.ToString()));
                    int quantityOrdered = int.Parse(dr2["QuantityOrdered"].ToString());
                    totalItemsSold = totalItemsSold + quantityOrdered;
                    lineItem.Cells.Add(addCalcCell(quantityOrdered.ToString()));
                    double unitWeight = double.Parse(dr2["UnitWeight"].ToString());
                    lineItem.Cells.Add(addCalcCell(unitWeight.ToString()));
                    double totalPrice = unitPrice * quantityOrdered;
                    totalSales = totalSales + totalPrice;
                    lineItem.Cells.Add(addCalcCell(totalPrice.ToString()));
                    double totalWeight = unitWeight * quantityOrdered;
                    totalCombinedWeight = totalCombinedWeight + totalWeight;
                    lineItem.Cells.Add(addCalcCell(totalWeight.ToString()));
                    lineItems.Rows.Add(lineItem);
                    totalOrder = totalOrder + totalPrice;

                }
                TableRow totalOrderRow = new TableRow();
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addCell(""));
                totalOrderRow.Cells.Add(addHeadCalcCell("$"+totalOrder.ToString()));
                lineItems.Rows.Add(totalOrderRow);
                dr2.Close();
                Page.Controls.Add(lineItems);
            }
            this.lineItems = new Table();
            lineItems.CssClass = "TotalsTable";
            TableRow totalHeadings = new TableRow();
            totalHeadings.CssClass = "TotalHeader";
            totalHeadings.Cells.Add(addTotalHeadCell("Total Orders"));
            totalHeadings.Cells.Add(addTotalHeadCell("Total Sales"));
            totalHeadings.Cells.Add(addTotalHeadCell("Total Items"));
            totalHeadings.Cells.Add(addTotalHeadCell("Total Weight"));
            lineItems.Rows.Add(totalHeadings);
            TableRow totals = new TableRow();
            totals.CssClass = "totalList";
            totals.Cells.Add(addTotalListCell(numberOfOrders.ToString()));
            totals.Cells.Add(addTotalListCell("$" + totalSales.ToString()));
            totals.Cells.Add(addTotalListCell(totalItemsSold.ToString()));
            totals.Cells.Add(addTotalListCell(totalCombinedWeight.ToString()));
            lineItems.Rows.Add(totals);

            Page.Controls.Add(lineItems);
            dr3.Close();
            cn.Close();

        }
        catch (Exception error)
        {
            lblStatus.Text = error.StackTrace;
            return;

        }
        


    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "NormalCell";
        return cell;
    }

    private TableCell addHeadCalcCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "HeadCalcCell";
        return cell;
    }
    private TableCell addCalcCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "CalcCell";
        return cell;
    }

    private TableCell addHeaderCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "HeadCell";
        return cell;
    }

    private TableCell addAddressCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "AddressCell";
        return cell;
    }

    private TableCell addTotalListCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "TotalCell";
        return cell;
    }

    private TableCell addTotalHeadCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 0;
        cell.Text = pText;
        cell.CssClass = "HeadTotalCell";
        return cell;
    }
}