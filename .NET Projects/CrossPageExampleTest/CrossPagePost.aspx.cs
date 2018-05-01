using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePost : System.Web.UI.Page
{
    private Table tbl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (PreviousPage != null)
        {

            lblInfo.Text = "You came from a page titled " +
                PreviousPage.Title + "<br />";

            _Default prevPage = PreviousPage as _Default;
            if (prevPage != null)
            {
                lblInfo.Text += "Some text from the previous page: " + prevPage.Fullname() +
                  "<br />";
                //Table test = prevPage.getTable();
                //Page.Controls.Add(test);
                List<Order> orders = prevPage.getorders();
                tbl = new Table();
                tbl.BorderStyle = BorderStyle.Dotted;
                tbl.EnableViewState = true;

                foreach (Order ord in orders)
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
}