using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void QueryStringLink_Click(object sender, EventArgs e)
    {
        Server.Transfer("QueryStringSender.aspx", true);
    }

    protected void CookieExampleLink_Click(object sender, EventArgs e)
    {
        Server.Transfer("CookieExample.aspx", true);
    }
}