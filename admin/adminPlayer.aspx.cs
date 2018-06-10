using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminPlayer : System.Web.UI.Page
{
    playerinfo piObj = new playerinfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string name = txtname.Text.Trim();
        string team = ddlteamname.SelectedValue;
        string no = num.Text.Trim();
        string height = txtHeight.Text.Trim();
        string weight = txtWeight.Text.Trim();
        string nation = country.Text.Trim();
        string rookie = rk.Text.Trim();
        string rank = ra.Text.Trim();
        int active = isActive.SelectedIndex;
        int v_IsAdd;
        try
        {
            v_IsAdd = piObj.Addplayerinfo(name, height, weight, team, Convert.ToInt32(no), nation, Convert.ToInt32(rookie), Convert.ToInt32(rank), Convert.ToBoolean(active));
        }
        catch
        {
            v_IsAdd = 2;
        }
        if (v_IsAdd == 0)
            lblMsg.Text = "添加球员失败！请重试！";
        else if (v_IsAdd == 1)
        {
            lblMsg.Text = "添加球员成功，可继续添加！";
            txtname.Text = "";
            num.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            country.Text = "";
            rk.Text = "";
            ra.Text = "";
        }
        else lblMsg.Text = "添加球员失败！该号码已退役！";



    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}