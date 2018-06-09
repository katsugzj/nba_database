using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminData : System.Web.UI.Page
{
    gamedatainfo gdiObj = new gamedatainfo();
    playerinfo piObj = new playerinfo();
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
        playingtime.Text = "0";
        score.Text = "0";
        rebound.Text = "0";
        assist.Text = "0";
        cap.Text = "0";
        steal.Text = "0";
        hit.Text = "0";
        shot.Text = "0";
        thit.Text = "0";
        tshot.Text = "0";
        freehit.Text = "0";
        freeshot.Text = "0";
        foul.Text = "0";
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string time = txttime.Text.Trim();
        string host = ddlhost.SelectedValue;
        int num = giObj.getGameNum(time, host);
        string name = ddlplayer.SelectedValue;
        int playerid = piObj.getPlayerNum(name);
        int playtime = Convert.ToInt32(playingtime.Text.Trim());
        int Score = Convert.ToInt32(score.Text.Trim());
        int Rebound = Convert.ToInt32(rebound.Text.Trim());
        int Assist = Convert.ToInt32(assist.Text.Trim());
        int Cap = Convert.ToInt32(cap.Text.Trim());
        int Steal = Convert.ToInt32(steal.Text.Trim());
        int Hit = Convert.ToInt32(hit.Text.Trim());
        int Shot = Convert.ToInt32(shot.Text.Trim());
        int Thit = Convert.ToInt32(thit.Text.Trim());
        int Tshot = Convert.ToInt32(tshot.Text.Trim());
        int Fhit = Convert.ToInt32(freehit.Text.Trim());
        int Fshot = Convert.ToInt32(freeshot.Text.Trim());
        int Foul = Convert.ToInt32(foul.Text.Trim());
        int v_IsAdd = gdiObj.Addgamedatainfo(num, playerid, playtime,Score,Rebound,Assist,Cap,Steal,Hit,Shot,Thit,Tshot,Fhit,Fshot,Foul);
        if (v_IsAdd == 0)
            lblMsg.Text = "添加数据失败！请重试！";
        else
        {
            lblMsg.Text = "添加数据成功，可继续添加！";
            playingtime.Text = "0";
            score.Text = "0";
            rebound.Text = "0";
            assist.Text = "0";
            cap.Text = "0";
            steal.Text = "0";
            hit.Text = "0";
            shot.Text = "0";
            thit.Text = "0";
            tshot.Text = "0";
            freehit.Text = "0";
            freeshot.Text = "0";
            foul.Text = "0";

        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
}