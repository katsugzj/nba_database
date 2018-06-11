using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class playerview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["playerid"];
        if (id != null)
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM [player] where id = " + id;
            GridView1.DataBind();
            SqlDataSource2.SelectCommand = "select * from gamedata,player,game where playerid = player.id and game.id = gameid and playerid =" + id;
            GridView2.DataBind();
        }
        else
        {
            SqlDataSource2.SelectCommand = "select * from gamedata,player,game where playerid = player.id and game.id = gameid";
            GridView2.DataBind();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("./admin/adminLogin.aspx");
    }
}