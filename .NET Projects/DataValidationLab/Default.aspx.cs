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

    protected void cusCustom_ServerValidate(object source, ServerValidateEventArgs em)
    {
        if (!em.Value.Contains("!") && !em.Value.Contains("@") && !em.Value.Contains("#") && !em.Value.Contains("$") && !em.Value.Contains("%")
            && !em.Value.Contains("^") && !em.Value.Contains("&"))
            em.IsValid = false;
        else
            em.IsValid = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
            CheckedOff.Text = "Something is wrong";
       
        else if(NumberBox.Value==""|| txtCustom.Text=="")
        {
            CheckedOff.Text = "You must fill out all of the boxes";
        }
        else
            CheckedOff.Text = "Everything in this form is correct";
    }
}