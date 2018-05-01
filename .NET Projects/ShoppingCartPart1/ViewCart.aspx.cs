using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

public partial class ViewCart : System.Web.UI.Page
{
    private double totalWeight = 0;
    private double totalPrice = 0;
    private int totalCount = 0;
    private int numItems = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection myConnection = new SqlConnection("Data Source=SQL5026.SmarterASP.NET;Initial Catalog=DB_A1DD79_shoppingCartDB;User Id=DB_A1DD79_shoppingCartDB_admin;Password=medic952;");
        TableRow cartHeading = new TableRow();
        
        cartHeading.BorderStyle = BorderStyle.Solid;
        cartHeading.BorderColor = System.Drawing.Color.Red;
        cartHeading.Font.Bold = true;
        cartHeading.Cells.Add(addCell("Title"));
        cartHeading.Cells.Add(addCell("UnitPrice"));
        cartHeading.Cells.Add(addCell("Quantity"));
        cartHeading.Cells.Add(addCell("Extension"));
        cartHeading.Cells.Add(addCell("Weight"));

        myConnection.Open();
        List<String> cartItems = (List<String>)Session["CartItems"];
        var frequency = cartItems.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        DataTable cartItemData = new DataTable();
        //lineItems.Rows.Add(cartHeading);
        cartItemData.Columns.AddRange(new DataColumn[5] { new DataColumn("Title", typeof(String)), new DataColumn("Price", typeof(String)),
                new DataColumn("Quantity Ordered", typeof(String)), new DataColumn("Total Price", typeof(String)), new DataColumn("Weight", typeof(String))});
        for (int i=0;i<frequency.Count;i++)
        {
            if (frequency.ElementAt(i).Value != 0)
            {
                SqlCommand getTable = new SqlCommand("SELECT Title,Price,Weight FROM BookstoreTable WHERE Title='" + frequency.ElementAt(i).Key + "'", myConnection);

                
                
                TableRow cartItem = new TableRow();
                cartItem.BorderStyle = BorderStyle.Dotted;
                SqlDataReader readTableRow = getTable.ExecuteReader();
                while (readTableRow.Read())
                {
                    cartItem.Cells.Add(addCell(readTableRow["Title"].ToString()));
                    cartItem.Cells.Add(addCell("$" + readTableRow["Price"].ToString()));
                    cartItem.Cells.Add(addCell(frequency.ElementAt(i).Value.ToString()));
                    totalCount += frequency.ElementAt(i).Value;
                    double calculatedPrice = Double.Parse(readTableRow["Price"].ToString()) * frequency.ElementAt(i).Value;
                    totalPrice += calculatedPrice;
                    cartItem.Cells.Add(addCell("$"+calculatedPrice.ToString()));
                    cartItem.Cells.Add(addCell(readTableRow["Weight"].ToString() + " ounces"));
                    totalWeight+= Double.Parse(readTableRow["Weight"].ToString()) * frequency.ElementAt(i).Value;
                    cartItemData.Rows.Add(readTableRow["Title"].ToString(), "$" + readTableRow["Price"].ToString(), frequency.ElementAt(i).Value.ToString(), "$" + calculatedPrice.ToString(), readTableRow["Weight"].ToString() + " ounces");
                }


                //lineItems.Rows.Add(cartItem);

                numItems++;
                readTableRow.Close();
            }
            

        }
        CartItems.DataSource = cartItemData;
        CartItems.DataBind();
        TableRow totals = new TableRow();
        totals.Cells.Add(addCell(" "));
        totals.Cells.Add(addCell(" "));
        totals.Cells.Add(addCell("Count: " + totalCount));
        totals.Cells.Add(addCell("$" + totalPrice));
        totals.Cells.Add(addCell(totalWeight + " ounces"));
        lineItems.Rows.Add(totals);
    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Dashed;
        cell.BorderWidth = 2;
        cell.Text = pText;
        cell.Font.Bold = true;
        cell.CssClass = "BookTableCell";
        return cell;
    }
  


    protected void CheckOutButton_Click(object sender, EventArgs e)
    {
        Session["TotalItems"] = numItems;
        Session["TotalQuantity"] = totalCount;
        Session["TotalWeight"] = totalWeight;
        Session["TotalPrice"] = totalPrice;
        Response.Redirect("Checkout.aspx");
    }

    protected void ContinueShoppingButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx", true);
    }
}