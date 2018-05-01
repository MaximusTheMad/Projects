using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using InvoiceLineItem.App_Code;

public partial class _Default : System.Web.UI.Page
{
    private List<invoiceLineItem> LineItems;
    private Table lineItems;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;
        if(!IsPostBack)
        {
            
            try
            {
                this.LineItems = new List<invoiceLineItem>();

                cn = new OleDbConnection();

                if (Request.UserHostAddress.ToString().Equals("::1"))
                {
                    // Local server...
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Max\Documents\Visual Studio 2017\WebSites\CSCD379Assignment2\APP_DATA\Orders.accdb;Persist Security Info=False;";
                    //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\App_Data\Orders.accdb;Persist Security Info=False;";

                }

                else
                {
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=h:\root\home\mwinston2-001\www\cscd379dadc\appdata\Orders.accdb;Persist Security Info=False;";
                }

                cmd = new OleDbCommand("SELECT * FROM Customer INNER JOIN InvoiceLineItem ON Customer.CustomerNumber=InvoiceLineItem.CustomerNumber ORDER BY Customer.CustomerNumber", cn);

                cn.Open();
                
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    
                    int Test= int.Parse(dr["Customer.CustomerNumber"].ToString());
                    String name = dr["Name"].ToString();
                    String street = dr["Street"].ToString();
                    String city = dr["City"].ToString();
                    String state = dr["State"].ToString();
                    String Zip = dr["Zip"].ToString();
                    String order = dr["OrderNumber"].ToString();
                    String invoiceNum = dr["InvoiceSequenceNumber"].ToString();
                    String itemSKU = dr["ItemSKU"].ToString();
                    String ItemDescription = dr["ItemDescription"].ToString();
                    int QuantityOrdered = int.Parse(dr["QuantityOrdered"].ToString());
                    double unitPrice = double.Parse(dr["UnitPrice"].ToString());
                    double unitWeight = double.Parse(dr["UnitWeight"].ToString());
                    LineItems.Add(new invoiceLineItem(Test, name, street, city, state, Zip, order, invoiceNum, itemSKU, ItemDescription, QuantityOrdered, unitPrice, unitWeight));
                    
                    lblStatus.Text = "Added To List";
                }
                
                
                lblStatus2.Text = "The reader string is not the problem";

                dr.Close();
                cn.Close();
            }
            catch(Exception error)
            {
                lblStatus.Text = error.StackTrace;
                return;
                
            }
            

            
        }
        try
            {
            if (LineItems == null)
            {
                LineItems = (List<invoiceLineItem>)ViewState["LineItems"];
            }

            LineItems.Add(new invoiceLineItem(2001253, "naskj", "dnj", "sdnja", "sndja", "dsbnh", "DASNJMK", "asdnj", "asdnj", "dsjan", 99, 29.20, 1.23));
            lineItems = new Table();
            lineItems.BorderStyle = BorderStyle.None;

            foreach (invoiceLineItem ord in LineItems)
            {
                TableRow row = new TableRow();
                row.Cells.Add(addCell(ord.getCustomerNumber().ToString()));
                row.Cells.Add(addCell(ord.getName()));
                row.Cells.Add(addCell(ord.getStreet()));
                row.Cells.Add(addCell(ord.getCity()));
                row.Cells.Add(addCell(ord.getState()));
                row.Cells.Add(addCell(ord.getZIP()));
              
                row.Cells.Add(addCell(ord.getInvoiceSequenceNumber()));
                row.Cells.Add(addCell(ord.getItemSKU()));
                row.Cells.Add(addCell(ord.getItemDescription()));

                row.Cells.Add(addCell(ord.getQuantityOrdered().ToString()));
                row.Cells.Add(addCell(ord.getUnitPrice().ToString()));
                row.Cells.Add(addCell(ord.getUnitWeight().ToString()));
                row.Cells.Add(addCell(ord.getShippingCost().ToString()));
                lineItems.Rows.Add(row);

            }
            Page.Controls.Add(lineItems);
           
        }
        catch (Exception err)
        {
            lblStatus.Text = err.Message;
        }
    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Solid;
        cell.BorderWidth = 1;
        cell.Text = pText;

        return cell;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        try
        {
            // Serialize the orders array to the viewstate...
            ViewState["LineItems"] = LineItems;
        }
        catch (Exception err)
        {
            lblStatus.Text = err.Message;
        }
       
    }

    public string Fullname()
    {
        return "This is coming from a code-behind method.";
    }

    public List<invoiceLineItem> getorders()
    {
        return LineItems;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        Server.Transfer("CrossPagePost.aspx", true);
    }
}