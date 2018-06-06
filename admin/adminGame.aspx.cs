using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminGame : System.Web.UI.Page
{
    gameinfo giObj = new gameinfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string time = txttime.Text.Trim();
        string host = ddlhost.SelectedValue;
        string visitor = ddlvisitor.SelectedValue;
        int type = int.Parse(ddltype.SelectedValue);
        //这里应该对用户的输入做一些长度校验和非法字符校验、防止SQL注入校验等，请自行完善
        int v_IsAdd = giObj.AddGameInfo(time, host, visitor, type);
        if (v_IsAdd == 0)
            lblMsg.Text = "添加比赛失败！请重试！";
        else
        {
            lblMsg.Text = "添加比赛成功，可继续添加！";
            txttime.Text = "";
        }



    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}