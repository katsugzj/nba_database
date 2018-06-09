using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updateHonour : System.Web.UI.Page
{
    honourinfo hiObj = new honourinfo();
    playerinfo piObj = new playerinfo();

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
        int honouryear = Convert.ToInt32(Request.QueryString["honouryear"]);
        int playerid = Convert.ToInt32(Request.QueryString["playerid"]);
        DataTable dt = hiObj.getInfobyYearid(honouryear,playerid);
        DataTable playerdt = piObj.getInfobyId(playerid);
        year.Text = honouryear.ToString();
        ddlplayer.SelectedValue = playerdt.Rows[0][1].ToString();
        mvp.SelectedIndex = Convert.ToInt32(dt.Rows[0][2]);
        playoffmvp.SelectedIndex = Convert.ToInt32(dt.Rows[0][3]);
        DPOY.SelectedIndex = Convert.ToInt32(dt.Rows[0][4]);
        allstar.Text = dt.Rows[0][5].ToString();
        bestline.Text = dt.Rows[0][6].ToString();
        bdline.Text = dt.Rows[0][7].ToString();
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
        string Player = ddlplayer.SelectedValue;
        int id = piObj.getPlayerNum(Player);
        Boolean Mvp = Convert.ToBoolean(mvp.SelectedIndex);
        Boolean playoffMvp = Convert.ToBoolean(playoffmvp.SelectedIndex);
        Boolean Dpoy = Convert.ToBoolean(DPOY.SelectedIndex);
        int allStar = allstar.SelectedIndex;
        int Bline = bestline.SelectedIndex;
        int BDline = bdline.SelectedIndex;
        int v_IsAdd = hiObj.Updatehonourinfo(Year, id, Mvp, playoffMvp, Dpoy, allStar, Bline, BDline);
        if (v_IsAdd == 0)
            lblMsg.Text = "修改失败！请重试！";
        else
        {
            lblMsg.Text = "修改成功，可继续添加！";
        }
    }
}