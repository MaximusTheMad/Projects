using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManualValidation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(!RangeValidator1.IsValid)
        {
            return;
        }

        else
        {
            int temp = int.Parse(NumberTextField.Text);
            int sum = 0;
            while(temp!=0)
            {
                sum = sum + (temp % 10);
                temp = temp / 10;
            }
            if(sum%10!=0)
            {
                NumberTextField.Text = "Invalid number: numbers digits add up to " + sum;
            }
            else
            {
                NumberTextField.Text = "Input is Valid";
            }
        }
    }
}