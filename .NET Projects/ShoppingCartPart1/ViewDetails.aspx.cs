using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewDetails : System.Web.UI.Page
{
    public static int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            int num = Session.Count;
            LiteralControl listingTest = new LiteralControl();
            LiteralControl listingTest2 = new LiteralControl();
            LiteralControl listingTest3 = new LiteralControl();
            String start = "<div class=\"StartOfDetails\">";

            listingTest2.Text = start;
            PlaceHolder1.Controls.Add(listingTest2);
            String coverImage = "<img src=\"" + Request.QueryString["FullAddress"] + "\" class=\"CoverImage\"/><br/>";
            listingTest.Text = coverImage;
            PlaceHolder1.Controls.Add(listingTest);
            
            Label lab1 = new Label();
            lab1.Text = Request.QueryString["Title"];
            lab1.Attributes.Add("runat", "server");
            lab1.CssClass = "TitleDetails";
            PlaceHolder1.Controls.Add(lab1);
            Label lab2 = new Label();
            lab2.Text = "<br/><b>Author:</b> "+Request.QueryString["Author"];
            lab2.Attributes.Add("runat", "server");
            lab2.CssClass = "AuthorDetails";
            PlaceHolder1.Controls.Add(lab2);
            Label lab3 = new Label();
            lab3.CssClass = "Description";
            lab3.Text = "<br/><b>Description:</b>"+Request.QueryString["Description"];
            lab3.Attributes.Add("runat", "server");
            PlaceHolder1.Controls.Add(lab3);
            
            Label lab5 = new Label();
            lab5.Text = "<br/>";
            lab5.Attributes.Add("runat", "server");
            Page.Controls.Add(lab5);
            Label lab4 = new Label();
            lab4.CssClass = "Price";
            lab4.Text = "<br/><b>Price:</b>$" + Request.QueryString["Price"] + "<br/>";
            lab4.Attributes.Add("runat", "server");
            PlaceHolder1.Controls.Add(lab4);
            String end = "</div>";
            listingTest3.Text = end;
            PlaceHolder1.Controls.Add(listingTest3);
            /**LinkButton addToCart = new LinkButton()
            {
                CssClass = "DetailsButton",
                Text = "Add To Cart"
            };
            lab5.Controls.Add(addToCart);
            Button viewCart = new Button();
            viewCart.Text = "View Cart";
            viewCart.CssClass = "DetailsButton";
            lab5.Controls.Add(viewCart);
            **/
        }
    }

    protected void ViewCartButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewCart.aspx");
    }

    protected void AddToCart_Click(object sender, EventArgs e)
    {
        String title = Request.QueryString["Title"];
        List<String> cartItems = (List<String>)Session["CartItems"];
        int quantity = int.Parse(QuantityOrdered.SelectedValue);
        for (int i = 0; i < quantity; i++)
        {
            cartItems.Add(title);
        }
        Session["CartItems"] = cartItems;
        Server.Transfer("ViewCart.aspx");

    }
   
}