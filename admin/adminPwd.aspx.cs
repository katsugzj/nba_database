using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminPwd : System.Web.UI.Page
{
    AdminInfo aicObj = new AdminInfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }

    protected void btnChange_Click(object sender, EventArgs e)
    {
        string v_AdminName = Session["admin"].ToString();
        string v_AdminPwd = txtOldPwd.Text.Trim();
        string v_AdminPwdNew = txtNewPwd1.Text.Trim();
        int result = aicObj.AdminChangePwd(v_AdminName, v_AdminPwd, v_AdminPwdNew);
        if (result == 1)
            lblMsg.Text = "修改密码成功！";
        else
        {
            if (result == 2)
                lblMsg.Text = "旧密码错误！";
            else
                lblMsg.Text = "修改密码失败！";
        }
        txtNewPwd1.Text = "";
        txtNewPwd2.Text = "";
        txtOldPwd.Text = "";
    }
}