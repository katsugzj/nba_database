using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminHonour : System.Web.UI.Page
{
    honourinfo hiObj = new honourinfo();
    playerinfo piObj = new playerinfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("adminLogin.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int Year = Convert.ToInt32(year.Text.Trim());
        string Player = ddlplayer.SelectedValue;
        int id = piObj.getPlayerNum(Player);
        Boolean Mvp = Convert.ToBoolean(mvp.SelectedIndex);
        Boolean playoffMvp = Convert.ToBoolean(playoffmvp.SelectedIndex);
        Boolean Dpoy = Convert.ToBoolean(DPOY.SelectedIndex);
        int allStar = allstar.SelectedIndex;
        int Bline = bestline.SelectedIndex;
        int BDline = bdline.SelectedIndex;
        //这里应该对用户的输入做一些长度校验和非法字符校验、防止SQL注入校验等，请自行完善
        int v_IsAdd = hiObj.Addhonourinfo(Year, id, Mvp, playoffMvp, Dpoy, allStar, Bline, BDline);
        if (v_IsAdd == 0)
            lblMsg.Text = "添加球员失败！请重试！";
        else
        {
            lblMsg.Text = "添加球员成功，可继续添加！";
        }



    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}