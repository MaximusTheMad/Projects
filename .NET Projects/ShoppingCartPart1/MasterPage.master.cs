﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ReturnToMain(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx");
    }

    protected void ViewCartFromMenu(object sender, EventArgs e)
    {
        Server.Transfer("ViewCart.aspx");
    }
}
