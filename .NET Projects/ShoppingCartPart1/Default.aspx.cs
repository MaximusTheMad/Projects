using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    private List<BookDetails> booksInStock;
    private static int i = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["CartItems"]==null)
        {
            List<String> cartItems = new List<String>();
            Session["CartItems"] = cartItems;
        }
            booksInStock = new List<BookDetails>();
            SqlConnection myConnection = new SqlConnection("Data Source=SQL5026.SmarterASP.NET;Initial Catalog=DB_A1DD79_shoppingCartDB;User Id=DB_A1DD79_shoppingCartDB_admin;Password=medic952;");
            SqlCommand getTable = new SqlCommand("SELECT * FROM BookstoreTable", myConnection);
            myConnection.Open();
            LiteralControl listingGallery = new LiteralControl();
        LiteralControl listingGallery2 = new LiteralControl();
        String listing = "<div class='booklistings'>";
        listingGallery.Text = listing;
        PlaceHolder1.Controls.Add(listingGallery);
            SqlDataReader sqlDR = getTable.ExecuteReader();
            int count = 0;
            while (sqlDR.Read())
            {
                LiteralControl listingTest = new LiteralControl();
                LiteralControl listingTest2 = new LiteralControl();
                String list2 = "";
                String list3 = "";
            BookDetails man = new BookDetails(sqlDR["Title"].ToString(), sqlDR["Author"].ToString(), sqlDR["Description"].ToString(), double.Parse(sqlDR["Price"].ToString()), sqlDR["FullImage"].ToString());
                booksInStock.Add(man);
                list2 = @"<div class='listingdiv'><ul class='listing'>";
                list2 = list2 + "<li><img src=\"" + sqlDR["ThumbnailAddress"].ToString() + "\" class=\"thumbnail\"></a></li>";
                list2 = list2 + "<li class='TitleLine'>" + sqlDR["Title"].ToString() + "</li>";

                list2 = list2 + "<li class='Author'>" + sqlDR["Author"].ToString() + "</li>";
                list2 = list2 + "<li class='PriceLine'> $" + sqlDR["Price"].ToString() + "</li>";

                LinkButton _lb = new LinkButton();
                _lb.ID = count.ToString();
                _lb.Text = "Details";
                _lb.Click += Button1_Click;
            _lb.CssClass = "DetailButton";
                listingTest.Text = list2;
                PlaceHolder1.Controls.Add(listingTest);
                list3 = @"</ul></div>";
                PlaceHolder1.Controls.Add(_lb);
                listingTest2.Text = list3;
                PlaceHolder1.Controls.Add(listingTest2);
                count++;
            }
            String listing2 = "</div>";
            listingGallery2.Text = listing2;
            PlaceHolder1.Controls.Add(listingGallery2);
            sqlDR.Close();
            myConnection.Close();
    }


    

    protected void Button1_Click(object sender, EventArgs e)
    {
        LinkButton simp = (LinkButton)sender;
        int index = int.Parse(simp.ID.ToString());

        BookDetails retrieved = booksInStock[index];
        String url = "ViewDetails.aspx?";
        url = url + "Title=" + retrieved.getTitle()+"&";
        url = url + "Author=" + retrieved.getAuthor()+"&";
        url = url + "Description=" + retrieved.getDescription() + "&";
        url = url + "Price=" + retrieved.getPrice()+ "&";
        url = url + "FullAddress=" + retrieved.getFullAddress();
        Server.Transfer(url, true);
    }
}