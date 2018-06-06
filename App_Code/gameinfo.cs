using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gameinfo 的摘要说明
/// </summary>
public class gameinfo
{
    DBClass dbObj = new DBClass();

    //插入比赛信息
    //gametype 1为季前赛，2为常规赛，3为季后赛第一轮，4为季后赛第二轮，5为季后赛分区决赛，6为季后赛总决赛
    public int AddGameInfo(string gametime,string host,string visitor,int gametype)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addgame");
        //传参
        cmd.Parameters.AddWithValue("@gametime", gametime);
        cmd.Parameters.AddWithValue("@host", host);
        cmd.Parameters.AddWithValue("@visitor", visitor);
        cmd.Parameters.AddWithValue("@gametype", gametype);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int getGameNum(string date, string host)
    {
        string cmdText = "select id from game where gametime = " + date + "and host = '" + host + "'";
        int id = dbObj.RunSQLtoInt(cmdText);

        return id;
    }
}