using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class gamedata : System.Web.UI.Page
{
    gamedatainfo gdiObj = new gamedatainfo();
    gameinfo giObj = new gameinfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        SqlDataSource1.SelectCommand = "select * from gamedata join player on playerid = id where gameid = " + id;
        GridView1.DataBind();
        DataTable gamedt = giObj.getInfobyId(Convert.ToInt32(id));
        DataTable dt = gdiObj.getScore(gamedt.Rows[0][1].ToString(), gamedt.Rows[0][2].ToString());
        Label1.Text = dt.Rows[0][3].ToString();
        Label2.Text = dt.Rows[0][4].ToString();
        Label3.Text = dt.Rows[0][5].ToString();
        Label4.Text = dt.Rows[0][6].ToString();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("./admin/adminLogin.aspx");
    }
    
}