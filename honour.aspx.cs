using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_honouraspx : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("./admin/adminLogin.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string hyear = Request.QueryString["honouryear"];
        if (hyear != null)
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM [V_honour] where honouryear = " + hyear;
            GridView1.DataBind();
        }
    }
}