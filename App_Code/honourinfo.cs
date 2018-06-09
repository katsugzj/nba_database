using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gamedatainfo 的摘要说明
/// </summary>
public class honourinfo
{
    DBClass dbObj = new DBClass();

    //插入比赛数据,最佳阵容0-2为1-3阵，3为无，最佳防守阵容0-1为1-2阵，2为无,全明星0-3分别为普通，首发，mvp，无
    public int Addhonourinfo(int honouryear, int playerid, Boolean regularseasonmvp, Boolean playoffmvp, Boolean dpoy, int allstar, int bestlineup, int bestdefensivelineup)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addhonour");
        //传参
        cmd.Parameters.AddWithValue("@honouryear", honouryear);
        cmd.Parameters.AddWithValue("@playerid", playerid);
        cmd.Parameters.AddWithValue("@regularseasonmvp", regularseasonmvp);
        cmd.Parameters.AddWithValue("@playoffmvp", playoffmvp);
        cmd.Parameters.AddWithValue("@dpoy", dpoy);
        cmd.Parameters.AddWithValue("@allstar", allstar);
        cmd.Parameters.AddWithValue("@bestlineup", bestlineup);
        cmd.Parameters.AddWithValue("@bestdefensivelineup", bestdefensivelineup);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int Updatehonourinfo(int honouryear, int playerid, Boolean regularseasonmvp, Boolean playoffmvp, Boolean dpoy, int allstar, int bestlineup, int bestdefensivelineup)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_updatehonour");
        //传参
        cmd.Parameters.AddWithValue("@honouryear", honouryear);
        cmd.Parameters.AddWithValue("@playerid", playerid);
        cmd.Parameters.AddWithValue("@regularseasonmvp", regularseasonmvp);
        cmd.Parameters.AddWithValue("@playoffmvp", playoffmvp);
        cmd.Parameters.AddWithValue("@dpoy", dpoy);
        cmd.Parameters.AddWithValue("@allstar", allstar);
        cmd.Parameters.AddWithValue("@bestlineup", bestlineup);
        cmd.Parameters.AddWithValue("@bestdefensivelineup", bestdefensivelineup);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public DataTable getInfobyYearid(int year,int id)
    {
        string cmdText = "select * from honour where honouryear =" + year + "and playerid =" + id;
        return dbObj.RunSQLtoDataTable(cmdText);
    }
}