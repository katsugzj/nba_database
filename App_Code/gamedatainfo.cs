using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gamedatainfo 的摘要说明
/// </summary>
public class gamedatainfo
{
    DBClass dbObj = new DBClass();

    //插入比赛数据
    public int Addgamedatainfo(int gameid,int playerid,int playingtime,int score,int rebound,int assist,int cap,int steal,int hit,int shot,int t_hit,int t_shot,int freehit,int freeshot,int foul)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addgamedata");
        //传参
        cmd.Parameters.AddWithValue("@gameid", gameid);
        cmd.Parameters.AddWithValue("@playerid", playerid);
        cmd.Parameters.AddWithValue("@playingtime", playingtime);
        cmd.Parameters.AddWithValue("@score", score);
        cmd.Parameters.AddWithValue("@rebound", rebound);
        cmd.Parameters.AddWithValue("@assist", assist);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@steal", steal);
        cmd.Parameters.AddWithValue("@hit", hit);
        cmd.Parameters.AddWithValue("@shot", shot);
        cmd.Parameters.AddWithValue("@t_hit", t_hit);
        cmd.Parameters.AddWithValue("@t_shot", t_shot);
        cmd.Parameters.AddWithValue("@freehit", freehit);
        cmd.Parameters.AddWithValue("@freeshot", freeshot);
        cmd.Parameters.AddWithValue("@foul", foul);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int UpdateGamedataInfo(int gameid, int playerid, int playingtime, int score, int rebound, int assist, int cap, int steal, int hit, int shot, int t_hit, int t_shot, int freehit, int freeshot, int foul)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_updategamedata");
        //传参
        cmd.Parameters.AddWithValue("@gameid", gameid);
        cmd.Parameters.AddWithValue("@playerid", playerid);
        cmd.Parameters.AddWithValue("@playingtime", playingtime);
        cmd.Parameters.AddWithValue("@score", score);
        cmd.Parameters.AddWithValue("@rebound", rebound);
        cmd.Parameters.AddWithValue("@assist", assist);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@steal", steal);
        cmd.Parameters.AddWithValue("@hit", hit);
        cmd.Parameters.AddWithValue("@shot", shot);
        cmd.Parameters.AddWithValue("@t_hit", t_hit);
        cmd.Parameters.AddWithValue("@t_shot", t_shot);
        cmd.Parameters.AddWithValue("@freehit", freehit);
        cmd.Parameters.AddWithValue("@freeshot", freeshot);
        cmd.Parameters.AddWithValue("@foul", foul);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public DataTable getInfobyIds(int gameid,int playerid)
    {
        string cmdText = "select * from gamedata where gameid = " + gameid + "and playerid = " + playerid;
        return dbObj.RunSQLtoDataTable(cmdText);
    }

    public DataTable getScore(string time,string team)
    {
        string cmdText = "DECLARE	@return_value int EXEC @return_value = [dbo].[gamescore] '"+time+"','"+team+"'";
        return dbObj.RunSQLtoDataTable(cmdText);
    }
}