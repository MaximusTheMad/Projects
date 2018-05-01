using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public List<Address> addresses;
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection myConnection = new SqlConnection("Data Source=SQL5026.SmarterASP.NET;Initial Catalog=DB_A1DD79_shoppingCartDB;User Id=DB_A1DD79_shoppingCartDB_admin;Password=medic952;");
        SqlCommand getTable = new SqlCommand("SELECT * FROM BookstoreTable", myConnection);
        myConnection.Open();
        SqlDataAdapter temp = new SqlDataAdapter(getTable);
        DataSet ds = new DataSet();
        temp.Fill(ds);
        DetailsView1.DataSource = ds;
        DetailsView1.PageIndexChanging += detailsView_PageIndexChanging;
        DetailsView1.DataBind();
    }
    protected void detailsView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        DetailsView1.PageIndex = e.NewPageIndex;
        DetailsView1.DataBind();
    }

}