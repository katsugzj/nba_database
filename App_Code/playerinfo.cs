using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gamedatainfo 的摘要说明
/// </summary>
public class playerinfo
{
    DBClass dbObj = new DBClass();

    //插入比赛数据
    public int Addplayerinfo(string playername, string playerheight, string playerweight, string team, int number, string nationality, int rookieyear, int rookierank,Boolean active)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addplayer");
        //传参
        cmd.Parameters.AddWithValue("@playername", playername);
        cmd.Parameters.AddWithValue("@playerheight", playerheight);
        cmd.Parameters.AddWithValue("@playerweight", playerweight);
        cmd.Parameters.AddWithValue("@team", team);
        cmd.Parameters.AddWithValue("@number", number);
        cmd.Parameters.AddWithValue("@nationality", nationality);
        cmd.Parameters.AddWithValue("@rookieyear", rookieyear);
        cmd.Parameters.AddWithValue("@rookierank", rookierank);
        cmd.Parameters.AddWithValue("@active", active);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int Updateplayerinfo(string playername, string playerheight, string playerweight, string team, int number, string nationality, int rookieyear, int rookierank, Boolean active)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_updateplayer");
        //传参
        cmd.Parameters.AddWithValue("@playername", playername);
        cmd.Parameters.AddWithValue("@playerheight", playerheight);
        cmd.Parameters.AddWithValue("@playerweight", playerweight);
        cmd.Parameters.AddWithValue("@team", team);
        cmd.Parameters.AddWithValue("@number", number);
        cmd.Parameters.AddWithValue("@nationality", nationality);
        cmd.Parameters.AddWithValue("@rookieyear", rookieyear);
        cmd.Parameters.AddWithValue("@rookierank", rookierank);
        cmd.Parameters.AddWithValue("@active", active);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int getPlayerNum(string name)
    {
        string cmdText = "select id from player where playername = '" + name + "'";
        int id = dbObj.RunSQLtoInt(cmdText);

        return id;
    }

    public int isPlayerInTeam(string name)
    {
        string cmdText = "select count(*) from player where name = '" + name + "'";
        return dbObj.RunSQLtoInt(cmdText);
    }

    public DataTable getInfobyId(int id)
    {
        string cmdText = "select * from player where id = " + id;
        return dbObj.RunSQLtoDataTable(cmdText);
    }
}