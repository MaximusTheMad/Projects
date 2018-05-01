using InvoiceLineItem.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                List<invoiceLineItem> orders = prevPage.getorders();
                tbl = new Table();
                tbl.BorderStyle = BorderStyle.Dotted;
                tbl.EnableViewState = true;

                foreach (invoiceLineItem ord in orders)
                {
                    TableRow row = new TableRow();
                    row.BorderStyle = BorderStyle.Solid;
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