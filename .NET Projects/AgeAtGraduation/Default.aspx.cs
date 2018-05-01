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
        CalculatedAgeLabel.Text = "";
        CurrentDateLabel.Text = "The Current Date is " + System.DateTime.Today.ToString("d");
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        int birthMonth;
        int birthDay;
        int birthYear;
        int gradMonth;
        int gradDay;
        int gradYear;
        //First I need to make sure the user actually entered numbers
        if(!int.TryParse(BirthMonth.Text,out birthMonth) || !int.TryParse(BirthDay.Text, out birthDay) || !int.TryParse(BirthYear.Text, out birthYear))
        {
            BirthMonth.Text = "Invalid Date";
            BirthDay.Text = "Invalid Date";
            BirthYear.Text = "Invalid Date";
        }
        else if(!int.TryParse(GradMonth.Text, out gradMonth) || !int.TryParse(GraduationDay.Text, out gradDay) || !int.TryParse(GraduationYear.Text, out gradYear))
        {
            GradMonth.Text = "Invalid Date";
            GraduationDay.Text = "Invalid Date";
            GraduationYear.Text = "Invalid Date";
        }
        else
        {
            System.DateTime gradDate = new System.DateTime(gradYear, gradMonth, gradDay);
            System.DateTime birthDate = new System.DateTime(birthYear, birthMonth, birthDay);
            System.TimeSpan difference = gradDate.Subtract(birthDate);
            int yearsOld = difference.Days / 365;
            CalculatedAgeLabel.Text = "Your age when you graduate will be " + yearsOld + " years old";
        }

    }
}