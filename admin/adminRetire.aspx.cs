using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminRetire : System.Web.UI.Page
{
    retireinfo riObj = new retireinfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int Year = Convert.ToInt32(year.Text.Trim());
        string team = ddlteam.SelectedValue;
        int id = Convert.ToInt32(number.Text.Trim());
        int v_IsAdd = riObj.Addretireinfo(Year,team,id);
        if (v_IsAdd == 0)
            lblMsg.Text = "添加失败！请重试！";
        else
        {
            lblMsg.Text = "添加成功，可继续添加！";
        }



    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}