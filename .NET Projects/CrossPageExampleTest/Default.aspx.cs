using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    private List<Order> theOrders;
    private Table tbl;

    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        if (IsPostBack == false)
        {
            try
            {
                this.theOrders = new List<Order>();
                //  Get database objects...
                //  Connect to database and open...
                cn = new OleDbConnection();

                if (Request.UserHostAddress.ToString().Equals("::1"))
                {
                    // Local server...
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\EWU\cscd379\Orders.accdb;Persist Security Info=False;";
                    //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\App_Data\Orders.accdb;Persist Security Info=False;";

                }
                else
                {
                    // Smarterasp as host...
                    //  E:\HostingSpaces\cp3t3rs\cscd379.com\wwwroot\Assign2\App_Data
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=h:\root\home\cp3t3rs-001\www\wwwroot\APP_DATA\Orders.accdb;Persist Security Info=False;";
                }

                // Create the SQL command...
                cmd = new OleDbCommand("SELECT * FROM Orders ORDER BY CusNum", cn);

                cn.Open();

                // Execute the SQL statement and get the dataset...
                dr = cmd.ExecuteReader();

                // Iterate over the dataset, create orders and add to collection...
                while (dr.Read())
                {
                    Order ord = new Order(int.Parse(dr["CusNum"].ToString()),
                                   dr["CusName"].ToString(),
                                   dr["Street"].ToString(),
                                   dr["City"].ToString(),
                                   dr["State"].ToString(),
                                   dr["Zip"].ToString(),
                                   int.Parse(dr["OrdNum"].ToString()),
                                   int.Parse(dr["LineNum"].ToString()),
                                   dr["SKU"].ToString(),
                                   dr["ItemDesc"].ToString(),
                                   int.Parse(dr["OrdQty"].ToString()),
                                   double.Parse(dr["UnitPrice"].ToString()),
                                   double.Parse(dr["UnitWeight"].ToString()));
                    theOrders.Add(ord);
                }



                dr.Close();
                cn.Close();
            }
            catch (Exception err)
            {
                lblStatus.Text = err.Message;
                return;
            }

        }  //  End !IsPostBack

        try
        {
            //  Restore the orders array from the viewstate...
            if (theOrders == null)
            {
                theOrders = (List<Order>)ViewState["theOrders"];
            }

            tbl = new Table();
            tbl.BorderStyle = BorderStyle.None;

            foreach (Order ord in theOrders)
            {
                TableRow row = new TableRow();
                row.BorderStyle = BorderStyle.Solid;

                row.Cells.Add(addCell(ord.Name));
                row.Cells.Add(addCell(ord.OrderNumber.ToString()));
                row.Cells.Add(addCell(ord.Description));
                row.Cells.Add(addCell(ord.Quantity.ToString()));
                row.Cells.Add(addCell(ord.Price.ToString()));

                tbl.Rows.Add(row);

            }
            Page.Controls.Add(tbl);
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

    public List<Order> getorders()
    {
        return theOrders;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        try
        {
            // Serialize the orders array to the viewstate...
            ViewState["theOrders"] = theOrders;
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

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        Server.Transfer("CrossPagePost.aspx", true);
    }
}