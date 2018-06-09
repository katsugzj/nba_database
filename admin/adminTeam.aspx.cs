using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminteam : System.Web.UI.Page
{
    teaminfo tiObj = new teaminfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string teamName = teamname.Text.Trim();
        string Arena = arena.Text.Trim();
        int Type = int.Parse(type.SelectedValue);
        string Coach = coach.Text.Trim();
        string addYear = addyear.Text.Trim();
        int v_IsAdd = tiObj.Addteaminfo(teamName, Arena, Type,Coach,addYear);
        if (v_IsAdd == 0)
            lblMsg.Text = "添加球队失败！请重试！";
        else
        {
            lblMsg.Text = "添加球队成功，可继续添加！";
            teamname.Text = "";
            arena.Text = "";
            type.SelectedIndex = 0;
            coach.Text = "";
            addyear.Text = "";
        }



    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}