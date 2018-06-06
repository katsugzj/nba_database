using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class newAdmin : System.Web.UI.Page
{
    AdminInfo acObj = new AdminInfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text.Trim() == "" || txtPwd.Text.Trim() == ""||txtrePwd.Text.Trim() == "")
            lblMsg.Text = "用户名和密码不能为空！";
        else if(txtPwd.Text.Trim()!= txtrePwd.Text.Trim())
        {
            //密码不一致
            lblMsg.Text = "密码不一致！";
            txtUsername.Text = "";
            txtPwd.Text = "";
        }
        else
        {
            bool v_AdminIsExist = acObj.AdminNameExist(txtUsername.Text.Trim());
            if (v_AdminIsExist)
            {
                acObj.AdminNew(txtUsername.Text.Trim(), txtPwd.Text.Trim());
                Session["admin"] = txtUsername.Text.Trim();
                Response.Redirect("adminIndex.aspx");
            }
            else //用户名已存在
            {
                //用户已存在
                lblMsg.Text = "用户已存在！";
                txtUsername.Text = "";
                txtPwd.Text = "";
            }
        }
    }
}