using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {


        OrdersLabel.Text = "Total Items: " + Session["TotalItems"].ToString();

        QuantityLabel.Text = "Total Quantity: " + Session["TotalQuantity"].ToString();
        WeightLabel.Text = "Total Weight: " + Session["TotalWeight"].ToString();

        ItemTotal.Text = "$" + Session["TotalPrice"];
        double totalCost = Double.Parse(Session["TotalPrice"].ToString());
        double shippingCost = Double.Parse(Session["TotalWeight"].ToString()) * 0.46;
        ShippingCost.Text = "$" + shippingCost;
        double netCost = totalCost + shippingCost;
        TotalCost.Text = "$" + netCost;

        if(Session["CustName"]!=null)
        {
            NameBox.Text = Session["CustName"].ToString();
        }
        if (Session["StreetName"] != null)
        {
            StreetBox.Text = Session["StreetName"].ToString();
        }
        if(Session["CityName"]!=null)
        {
            CityBox.Text = Session["CityName"].ToString();
        }
        if(Session["StateName"]!=null)
        {
            StateBox.Text = Session["StateName"].ToString();
        }
        if(Session["ZIP"]!=null)
        {
            ZipBox.Text = Session["ZIP"].ToString();
        }
        if(Session["EMAIL"]!=null)
        {
            EmailBox.Text = Session["EMAIL"].ToString();
        }


    }

    protected void cusCustom_ServerValidate(object source, ServerValidateEventArgs em)
    {
        if (!em.Value.Contains(".") && !em.Value.Contains("@"))
            em.IsValid = false;
        else
            em.IsValid = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!RequiredFieldValidator1.IsValid || !RequiredFieldValidator2.IsValid || !RequiredFieldValidator3.IsValid || !RequiredFieldValidator4.IsValid || !RequiredFieldValidator5.IsValid || !RequiredFieldValidator6.IsValid || !cusCustom.IsValid)
        {
            return;
        }
        else
        {
            int orderNum = 0;
            SqlConnection myConnection = new SqlConnection("Data Source=SQL5026.SmarterASP.NET;Initial Catalog=DB_A1DD79_shoppingCartDB;User Id=DB_A1DD79_shoppingCartDB_admin;Password=medic952; MultipleActiveResultSets = True");
            myConnection.Open();
            SqlTransaction transaction;
            
            

            SqlCommand cas = new SqlCommand("SELECT CompanyName, NextOrder FROM OrderTable WHERE Id = 10264;", myConnection);
            SqlDataReader orderNumReader = cas.ExecuteReader();
            String company = "";
            while (orderNumReader.Read())
            {
                orderNum = int.Parse(orderNumReader["NextOrder"].ToString());
                company = orderNumReader["CompanyName"].ToString();
            }

            orderNumReader.Close();
            Session["OrderNum"] = company + "-" + orderNum.ToString();
            Session["CustName"] = NameBox.Text;
            Session["StreetName"] = StreetBox.Text;
            Session["CityName"] = CityBox.Text;
            Session["StateName"] = StateBox.Text;
            Session["ZIP"] = ZipBox.Text;
            Session["EMAIL"] = EmailBox.Text;
            SqlCommand command = myConnection.CreateCommand();
            command.Connection = myConnection;
            command.CommandText="UPDATE dbo.OrderTable SET NextOrder = NextOrder + 1 WHERE Id = 10264;";
            command.BeginExecuteNonQuery();
            
            SmtpClient mailSender = new SmtpClient("smtp.office365.com");
            mailSender.Credentials = new System.Net.NetworkCredential("maxwell.winston@eagles.ewu.edu", "M3d1c952+");
            mailSender.Port = 587;
            mailSender.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.To.Add(Session["EMAIL"].ToString());
            mail.From = new MailAddress("maxwell.winston@eagles.ewu.edu");
            mail.Subject = "Bookstore Order Confirmation: " + Session["OrderNum"];
            mail.IsBodyHtml = true;
            mail.Body = "CSCD379 - ASP.Net Programming with C# <br/> <br/>" +
                "Your order has been processed <br/><br/>" +
                "Order number: " + Session["OrderNum"] + "<br/>";
            mail.Body += "<table style=\"width:100%\">" + "<tr><th>Title</th><th>Quantity Ordered</th><th>Unit Price</th><th>Combined Price</th>";
            List<String> cartItems = (List<String>)Session["CartItems"];
            var frequency = cartItems.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            for (int i = 0; i < frequency.Count; i++)
            {
                if (frequency.ElementAt(i).Value != 0)
                {
                    SqlCommand getTable = new SqlCommand("SELECT Title,Price FROM BookstoreTable WHERE Title='" + frequency.ElementAt(i).Key + "'", myConnection);
                    SqlDataReader sr = getTable.ExecuteReader();
                    while (sr.Read())
                    {
                        double price = Double.Parse(sr["Price"].ToString())*frequency.ElementAt(i).Value;
                        mail.Body += "<tr><td>" + sr["Title"].ToString() + "</td><td>" + frequency.ElementAt(i).Value.ToString() + "</td><td>" + sr["Price"].ToString()+ "</td><td>"+price.ToString()+"</td></tr>";
                    }
                }

            }
            mail.Body += "<br/><br/>Total Quantity: " + Session["TotalQuantity"].ToString() + "<br/>";
            double shippingCost = Double.Parse(Session["TotalWeight"].ToString()) * 0.46;
            mail.Body += "Shipping Cost: $" + shippingCost + "<br/>";
            double totalCost = Double.Parse(Session["TotalPrice"].ToString());
            double netCost = totalCost + shippingCost;
            mail.Body += "Total Order Cost: $" + netCost+"<br/><br/>";
            mail.Body += Session["CustName"].ToString()+"<br/>";
            mail.Body += Session["StreetName"].ToString() + "<br/>";
            mail.Body += Session["CityName"].ToString() + "<br/>";
            mail.Body += Session["StateName"].ToString() + "<br/>";
            mail.Body += Session["ZIP"].ToString() + "<br/><br/><br/>";
            mail.Body += "If you did not place an order with the EWU Bookstore, please contact <a href=\"mailto:support@EvergreenInteractive.com?Subject=Fradulant%20Order \">Support</a>";
            mailSender.Send(mail);

            myConnection.Close();
            Session["CartItems"] = new List<String>();
            Response.Redirect("CheckoutConfirmation.aspx");
        }
       
    }
}