using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QueryStringSender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            lstItems.Items.Add("Econo Sofa");
            lstItems.Items.Add("Supreme Leather Drapery");
            lstItems.Items.Add("Threadbare Carpet");
            lstItems.Items.Add("Antique Lamp");
            lstItems.Items.Add("Retro-Finish Jacuzzi");
        }
    }

    protected void cmdGo_Click(Object sender, EventArgs e)
    {
        if(lstItems.SelectedIndex==-1)
        {
            lblError.Text = "You must select an item.";
        }

        else
        {
            string url = "QueryStringRecipient.aspx?";
            url = url + "Item=" + lstItems.SelectedItem.Text + "&";
            url = url + "Mode=" + chkDetails.Checked.ToString();
            Response.Redirect(url);
        }
    }
}