using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updatePlayer : System.Web.UI.Page
{
    playerinfo piObj = new playerinfo();
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
        int id = Convert.ToInt32(Request.QueryString["id"]);
        DataTable dt = piObj.getInfobyId(id);
        txtname.Text = dt.Rows[0][1].ToString();
        ddlteamname.SelectedValue = dt.Rows[0][4].ToString();
        txtHeight.Text = dt.Rows[0][2].ToString();
        txtWeight.Text = dt.Rows[0][3].ToString();
        num.Text = dt.Rows[0][5].ToString();
        country.Text = dt.Rows[0][6].ToString();
        rk.Text = dt.Rows[0][7].ToString();
        ra.Text = dt.Rows[0][8].ToString();
        isActive.SelectedIndex = Convert.ToInt32(dt.Rows[0][9]);
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
    //保存修改
    protected void btnChange_Click(object sender, EventArgs e)
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
        int v_IsAdd = piObj.Updateplayerinfo(name, height, weight, team, Convert.ToInt32(no), nation, Convert.ToInt32(rookie), Convert.ToInt32(rank), Convert.ToBoolean(active));
        if (v_IsAdd == 0)
            lblMsg.Text = "修改球员失败！请重试！";
        else
        {
            lblMsg.Text = "修改球员成功！";
        }
    }
}