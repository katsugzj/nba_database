using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updateGame : System.Web.UI.Page
{
    gameinfo giObj = new gameinfo();

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
        DataTable dt = giObj.getInfobyId(id);
        txttime.Text = dt.Rows[0][1].ToString();
        ddlhost.SelectedValue = dt.Rows[0][2].ToString();
        ddlvisitor.SelectedValue = dt.Rows[0][3].ToString();
        ddltype.SelectedValue = dt.Rows[0][4].ToString();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
    //保存修改
    protected void btnChange_Click(object sender, EventArgs e)
    {
        string time = txttime.Text.Trim();
        string host = ddlhost.SelectedValue;
        string visitor = ddlvisitor.SelectedValue;
        int type = int.Parse(ddltype.SelectedValue);
        int v_IsAdd = giObj.UpdateGameInfo(time, host, visitor, type);
        if (v_IsAdd == 0)
            lblMsg.Text = "修改比赛失败！请重试！";
        else
        {
            lblMsg.Text = "修改比赛成功！";
            txttime.Text = "";
        }
    }
}