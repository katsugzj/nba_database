using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updateTeam : System.Web.UI.Page
{
    teaminfo tiObj = new teaminfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
        if (!IsPostBack)
        {
            Bind();
        }
    }

    protected void Bind()
    {
        string name = Request.QueryString["name"];
        DataTable dt = tiObj.getInfobyName(name);
        teamname.Text = dt.Rows[0][0].ToString();
        arena.Text = dt.Rows[0][1].ToString();
        type.SelectedValue = dt.Rows[0][2].ToString();
        coach.Text = dt.Rows[0][3].ToString();
        addyear.Text = dt.Rows[0][4].ToString();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
    //保存修改
    protected void btnChange_Click(object sender, EventArgs e)
    {
        string teamName = teamname.Text.Trim();
        string Arena = arena.Text.Trim();
        int Type = int.Parse(type.SelectedValue);
        string Coach = coach.Text.Trim();
        string addYear = addyear.Text.Trim();
        int v_IsAdd = tiObj.Updateteaminfo(teamName, Arena, Type, Coach, addYear);
        if (v_IsAdd == 0)
            lblMsg.Text = "修改球队失败！请重试！";
        else
        {
            lblMsg.Text = "修改球队成功！";
        }
    }
}