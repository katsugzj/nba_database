using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class newLogin : System.Web.UI.Page
{
    AdminInfo acObj = new AdminInfo();

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            lblMsg.Text = "用户名和密码不能为空！";
        else
        {
            bool v_AdminIsExist = acObj.AdminExist(txtUsername.Text.Trim(), txtPwd.Text.Trim());
            if (v_AdminIsExist) //用户名和密码正确
            {
                Session["admin"] = txtUsername.Text.Trim();
                Response.Redirect("adminIndex.aspx");
            }
            else
            {
                //用户不存在
                lblMsg.Text = "用户名或密码错误！";
                txtUsername.Text = "";
                txtPwd.Text = "";
            }
        }
    }
}