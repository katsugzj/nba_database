using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_updateData : System.Web.UI.Page
{
    gamedatainfo gdiObj = new gamedatainfo();
    gameinfo giObj = new gameinfo();
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
        int gameid = Convert.ToInt32(Request.QueryString["gameid"]);
        int playerid = Convert.ToInt32(Request.QueryString["playerid"]);
        DataTable dt = gdiObj.getInfobyIds(gameid,playerid);
        DataTable gamedt = giObj.getInfobyId(gameid);
        DataTable playerdt = piObj.getInfobyId(playerid);
        txttime.Text = gamedt.Rows[0][1].ToString();
        ddlhost.SelectedValue = gamedt.Rows[0][2].ToString();
        ddlplayer.SelectedValue = playerdt.Rows[0][1].ToString();
        playingtime.Text = dt.Rows[0][2].ToString();
        score.Text = dt.Rows[0][3].ToString();
        rebound.Text = dt.Rows[0][4].ToString();
        assist.Text = dt.Rows[0][5].ToString();
        cap.Text = dt.Rows[0][6].ToString();
        steal.Text = dt.Rows[0][7].ToString();
        hit.Text = dt.Rows[0][8].ToString();
        shot.Text = dt.Rows[0][9].ToString();
        thit.Text = dt.Rows[0][10].ToString();
        tshot.Text = dt.Rows[0][11].ToString();
        freehit.Text = dt.Rows[0][12].ToString();
        freeshot.Text = dt.Rows[0][13].ToString();
        foul.Text = dt.Rows[0][14].ToString();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("adminLogin.aspx");
    }
    //保存修改
    protected void btnChange_Click(object sender, EventArgs e)
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
        int v_IsAdd = gdiObj.UpdateGamedataInfo(num, playerid, playtime, Score, Rebound, Assist, Cap, Steal, Hit, Shot, Thit, Tshot, Fhit, Fshot, Foul);
        if (v_IsAdd == 0)
            lblMsg.Text = "修改数据失败！请重试！";
        else
        {
            lblMsg.Text = "修改数据成功，可继续添加！";
        }
    }
}