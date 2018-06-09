using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updateRetire : System.Web.UI.Page
{
    retireinfo riObj = new retireinfo();

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
        string teamname = Request.QueryString["teamname"];
        int retirenumber = Convert.ToInt32(Request.QueryString["retirenumber"]);
        DataTable dt = riObj.getInfobyNoteam(teamname, retirenumber);
        year.Text = dt.Rows[0][0].ToString();
        ddlteam.SelectedValue = dt.Rows[0][1].ToString();
        number.Text = dt.Rows[0][2].ToString();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
    //保存修改
    protected void btnChange_Click(object sender, EventArgs e)
    {
        int Year = Convert.ToInt32(year.Text.Trim());
        string team = ddlteam.SelectedValue;
        int id = Convert.ToInt32(number.Text.Trim());
        int v_IsAdd = riObj.Updateretireinfo(Year, team, id);
        if (v_IsAdd == 0)
            lblMsg.Text = "修改失败！请重试！";
        else
        {
            lblMsg.Text = "修改成功，可继续添加！";
        }
    }
}