using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teamview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string team = Request.QueryString["team"];
        if(team != null){
            SqlDataSource1.SelectCommand = "SELECT * FROM [V_team] where teamname = '" + team +"'";
            SqlDataSource2.SelectCommand = "select * from player where team = '" + team +"'";
            GridView1.DataBind();
            GridView2.DataBind();
        }
        else
        {
            SqlDataSource2.SelectCommand = "select * from player where team = 'noteam'";
            GridView2.DataBind();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("./admin/adminLogin.aspx");
    }
}